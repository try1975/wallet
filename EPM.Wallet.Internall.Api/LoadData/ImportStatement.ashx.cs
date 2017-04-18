using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using EPM.Wallet.Data.SqlServer;
using EPM.Wallet.Data.SqlServer.QueryProcessors;
using EPM.Wallet.Internal.Model;
using log4net;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.LoadData
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class ImportStatement : IHttpHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void ProcessRequest(HttpContext context)
        {
            //if(!context.User.Identity.IsAuthenticated) return;

            var periodFrom = "";
            var periodTill = "";
            var statementData = new AccountStatementDataDto();

            context.Response.ContentType = "text/plain";
            context.Response.Cache.SetCacheability(HttpCacheability.NoCache);

            var sEnc = context.Request.Params["enc"];
            Encoding encoding;
            if ((!string.IsNullOrEmpty(sEnc)) && sEnc.Equals("utf-8", StringComparison.InvariantCultureIgnoreCase))
                encoding = Encoding.UTF8;
            else
                encoding = Encoding.GetEncoding(1251);

            var b = context.Request.BinaryRead(context.Request.TotalBytes);
            var s = encoding.GetString(b);
            var a = s.Split('\n');
            var bHead = Convert.FromBase64String(a[1]);
            var sHead = encoding.GetString(bHead);

            var iFileBase = 3;
            if (a[3].StartsWith("POINTSDATA=", StringComparison.InvariantCultureIgnoreCase))
            {
                iFileBase = 4;
            }

            var bFile = Convert.FromBase64String(a[iFileBase]);


            var aHead = sHead.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
            var spl = new[] {'='};
            var provider = new CultureInfo("en-GB");
            foreach (var t in aHead)
            {
                var aPair = t.Split(spl);
                if (aPair.Length < 2) continue;

                var strValue = "";
                if (Regex.IsMatch(aPair[1], @"\s([0-9.,]+)\s*",
                    RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace))
                {
                    strValue = Regex.Match(aPair[1], @"\s([0-9.,]+)\s*",
                        RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace).Groups[1].Value;
                }
                decimal decimalResult;

                switch (aPair[0])
                {
                    case "cardNumber":
                        statementData.AccountName = aPair[1];
                        break;

                    case "periodFrom":
                        periodFrom = aPair[1];
                        break;

                    case "periodTill":
                        periodTill = aPair[1];
                        break;

                    case "prevBalance":
                        if (decimal.TryParse(strValue, NumberStyles.Number, provider, out decimalResult))
                        {
                            statementData.PreviousBalance = decimalResult;
                        }
                        break;

                    case "newBalance":
                        if (decimal.TryParse(strValue, NumberStyles.Number, provider, out decimalResult))
                        {
                            statementData.NewBalance = decimalResult;
                        }
                        break;

                    case "newCredits":
                        if (decimal.TryParse(strValue, NumberStyles.Number, provider, out decimalResult))
                        {
                            statementData.Credits = decimalResult;
                        }
                        break;

                    case "newCharges":
                        if (decimal.TryParse(strValue, NumberStyles.Number, provider, out decimalResult))
                        {
                            statementData.Debits = decimalResult;
                        }
                        break;

                    case "LoadFrom":
                        statementData.LoadedFrom = Path.ChangeExtension(aPair[1], "*.pdf");
                        break;

                    case "ContentType":
                        statementData.ContentType = aPair[1];
                        break;
                }
            }

            statementData.ValueDate = DateTime.Now;
            statementData.Period = $"{periodFrom}-{periodTill}";
            statementData.Content = bFile;

            try
            {
                // write statement to database
                using (var walletContext = new WalletContext())
                {
                    IStatementApi statementApi = new StatementApi(new StatementQuery(walletContext),
                        new AccountQuery(walletContext));
                    if (statementApi.WriteAccountStatementData(statementData))
                    {
                        context.Response.Write($"OK [{statementData.AccountName}]");
                    }
                    else
                    {
                        context.Response.Write("Error");
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                context.Response.Write("Error");
                context.Response.Write(e.ToString());
                //throw;
                
            }
        }
 
        public bool IsReusable => false;
    }
}