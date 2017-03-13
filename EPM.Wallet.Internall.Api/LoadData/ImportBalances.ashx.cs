using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml.Linq;
using EPM.Wallet.Data.SqlServer;
using EPM.Wallet.Data.SqlServer.QueryProcessors;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.LoadData
{
    /// <summary>
    /// Summary description for ImportBalances
    /// </summary>
    public class ImportBalances : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            //if(!context.User.Identity.IsAuthenticated) return;
            context.Response.ContentType = "text/plain";

            var xmlText = context.Request.Params["EPMTORCDATA"];
            var accountBalances = new List<AccountBalance>();
            var xmlDoc = XDocument.Load(new StringReader(xmlText));

            if (xmlDoc.Root != null)
            {
                foreach (var element in xmlDoc.Root.Elements("AccountBalance"))
                {
                    var epmAccountBalance = new AccountBalance();
                    var xAttribute = element.Attribute("Code");
                    if (xAttribute != null)
                    {
                        epmAccountBalance.Code = xAttribute.Value;
                    }
                    xAttribute = element.Attribute("Balance");
                    if (xAttribute != null)
                    {
                        epmAccountBalance.Balance = Convert.ToDecimal(xAttribute.Value);
                    }
                    accountBalances.Add(epmAccountBalance);
                }
            }

            // write balances to accounts
            //var accountApi = DependencyResolver.Current.GetService<IAccountApi>();
            var responseText = "Ok";
            var accountApi = new AccountApi(new AccountQuery(new WalletContext()));
            foreach (var accountBalance in accountBalances)
            {
                var ok = accountApi.WriteEpmAccountBalance(accountBalance.Code, accountBalance.Balance);
                // TODO: add error details
                if (!ok) responseText = "Error";
            }
            context.Response.Write(responseText);
        }

        public bool IsReusable => false;

        private class AccountBalance
        {
            public string Code { get; set; }
            public decimal Balance { get; set; }
        }
    }
}