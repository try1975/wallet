using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.SqlServer;
using EPM.Wallet.Data.SqlServer.QueryProcessors;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.LoadData
{
    /// <summary>
    /// Summary description for ImportTransactons
    /// </summary>
    public class ImportTransactons : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //if(!context.User.Identity.IsAuthenticated) return;
            context.Response.ContentType = "text/plain";
            var xmlText = context.Request.Params["EPMTORCDATA"];

            var serializer = new XmlSerializer(typeof(Statement));
            var reader = new StringReader(xmlText);
            var statement = (Statement)serializer.Deserialize(reader);
            reader.Close();
            var responseText = "Ok";

            if (statement?.AccountsData == null)
            {
                context.Response.Write(responseText);
                return;
            }

            var walletContext = new WalletContext();
            var accountQuery = new AccountQuery(walletContext);
            var transactionQuery = new TransactionQuery(walletContext);
            var transactionApi = new TransactionApi(transactionQuery, accountQuery);

            foreach (var accountData in statement.AccountsData)
            {
                var accountEntity = accountQuery.GetEntities().FirstOrDefault(z => z.Name.Equals(accountData.Code));
                if (accountEntity == null)
                {
                    responseText += $"\r\nCode={accountData.Code} - not found.";
                    continue;
                }

                var dFromDate = DateTime.ParseExact(accountData.FromDateUni, "yyyyMMdd", CultureInfo.InvariantCulture);
                var fromDate = dFromDate; //new DateTimeOffset(dFromDate);
                var dToDate = DateTime.ParseExact(accountData.ToDateUni, "yyyyMMdd", CultureInfo.InvariantCulture);
                dToDate = dToDate.AddDays(1);
                var toDate = dToDate; // new DateTimeOffset(dToDate);
                DeleteExistingTransactions(transactionQuery, accountEntity, fromDate, toDate, transactionApi);

                if (accountData.Transactions == null) continue;
                foreach (var transactionData in accountData.Transactions)
                {
                    var transactionDto = CreateTransactionDto(transactionData, accountEntity);
                    transactionApi.AddItem(transactionDto);
                }
            }
            context.Response.Write(responseText);
        }

        private static TransactionDto CreateTransactionDto(TransactionData transactionData, ClientAccountEntity accountEntity)
        {
            var dRegisterDate = DateTime.ParseExact(transactionData.RegisterDate, "yyyyMMdd HH:mm:ss",
                CultureInfo.InvariantCulture);
            var registerDate = new DateTimeOffset(dRegisterDate, TimeSpan.Zero);
            var dValueDate = DateTime.ParseExact(transactionData.ValueDate, "yyyyMMdd", CultureInfo.InvariantCulture);
            var valueDate = new DateTimeOffset(dValueDate, TimeSpan.Zero);
            var amount = int.Parse(transactionData.Amount)/100;
            var amountInCurrency = int.Parse(transactionData.AmountInCurrency)/100;

            var transactionDto = new TransactionDto
            {
                AccountId = accountEntity.Id,
                RegisterDate = registerDate,
                ValueDate = valueDate,
                CurrencyId = transactionData.CurrencyId,
                Amount = amount,
                AmountInCurrency = amountInCurrency,
                FromTo = $"{transactionData.Merchant}/{transactionData.MerchantPlace}",
                Note = transactionData.Description,
            };
            return transactionDto;
        }

        private static void DeleteExistingTransactions(TransactionQuery transactionQuery, ClientAccountEntity accountEntity,
            DateTime fromDate, DateTime toDate, TransactionApi transactionApi)
        {
            var deletedTransactions =
                transactionQuery.GetEntities()
                    .Where(z => z.AccountId == accountEntity.Id && z.RegisterDate >= fromDate && z.RegisterDate < toDate)
                    .OrderBy(z => z.RegisterDate)
                    .ToList();
            foreach (var deletedTransaction in deletedTransactions)
            {
                transactionApi.RemoveItem(deletedTransaction.Id);
            }
        }

        public bool IsReusable => false;

        [Serializable]
        [XmlRoot("Statement")]
        public class Statement
        {
            [XmlElement("AccountData")]
            public AccountData[] AccountsData { get; set; }
        }

        [Serializable]
        public class AccountData
        {
            [XmlAttribute("Debits")]
            public string Debits { get; set; }

            [XmlAttribute("Credits")]
            public string Credits { get; set; }

            [XmlAttribute("NewBalance")]
            public string NewBalance { get; set; }

            [XmlAttribute("PrevBalance")]
            public string PrevBalance { get; set; }

            [XmlAttribute("Code")]
            public string Code { get; set; }

            [XmlAttribute("AccountNum")]
            public string AccountNum { get; set; }

            [XmlAttribute("AccountName")]
            public string AccountName { get; set; }

            [XmlAttribute("ToDate")]
            public string ToDate { get; set; }

            [XmlAttribute("FromDate")]
            public string FromDate { get; set; }

            [XmlAttribute("ToDateUni")]
            public string ToDateUni { get; set; }

            [XmlAttribute("FromDateUni")]
            public string FromDateUni { get; set; }

            [XmlElement("Transaction")]
            public TransactionData[] Transactions { get; set; }
        }

        [Serializable]
        public class TransactionData
        {
            [XmlAttribute("EXTERNALLID")]
            public int Id { get; set; }

            [XmlAttribute("TRANSDESC")]
            public string Description { get; set; }

            [XmlAttribute("TYPENAME")]
            public string TypeName { get; set; }

            [XmlAttribute("SUM")]
            public string Sum { get; set; }

            [XmlAttribute("MERCHANDPLACE")]
            public string MerchantPlace { get; set; }

            [XmlAttribute("MERCHAND")]
            public string Merchant { get; set; }

            [XmlAttribute("ACCOMPLISHMENT")]
            public string Date { get; set; }

            [XmlAttribute("RegisterDate")]
            public string RegisterDate { get; set; }

            [XmlAttribute("ValueDate")]
            public string ValueDate { get; set; }

            [XmlAttribute("Amount")]
            public string Amount { get; set; }

            [XmlAttribute("AmountInCurrency")]
            public string AmountInCurrency { get; set; }

            [XmlAttribute("CurrencyId")]
            public string CurrencyId { get; set; }
        }
    }
}