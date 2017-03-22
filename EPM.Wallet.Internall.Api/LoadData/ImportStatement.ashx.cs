﻿using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using EPM.Wallet.Data.SqlServer;
using EPM.Wallet.Data.SqlServer.QueryProcessors;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.LoadData
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class ImportStatement : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //if(!context.User.Identity.IsAuthenticated) return;

            var periodFrom = "";
            var periodTill = "";
            var statementData = new AccountStatementDataDto();

            context.Response.ContentType = "text/plain";
            context.Response.Cache.SetCacheability(HttpCacheability.NoCache);

            var sEnc = context.Request.Params["enc"];
            Encoding e;
            if ((!string.IsNullOrEmpty(sEnc)) && sEnc.Equals("utf-8", StringComparison.InvariantCultureIgnoreCase))
                e = Encoding.UTF8;
            else
                e = Encoding.GetEncoding(1251);

            var b = context.Request.BinaryRead(context.Request.TotalBytes);
            var s = e.GetString(b);
            var a = s.Split('\n');
            var bHead = Convert.FromBase64String(a[1]);
            var sHead = e.GetString(bHead);

            var iFileBase = 3;
            if (a[3].StartsWith("POINTSDATA=", StringComparison.InvariantCultureIgnoreCase))
            {
                iFileBase = 4;
            }

            var bFile = Convert.FromBase64String(a[iFileBase]);


            var aHead = sHead.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            var spl = new[] { '=' };
            var provider = new CultureInfo("en-GB");
            foreach (var t in aHead)
            {
                var aPair = t.Split(spl);
                if (aPair.Length < 2) continue;

                var strValue = "";
                if (Regex.IsMatch(aPair[1], @"\s([0-9.,]+)\s*", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace))
                {
                    strValue=Regex.Match(aPair[1], @"\s([0-9.,]+)\s*",
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
                        statementData.LoadedFrom = aPair[1];
                        break;

                    case "ContentType":
                        statementData.ContentType = aPair[1];
                        break;
                }
            }

            statementData.ValueDate = DateTime.Now;
            statementData.Period = $"{periodFrom}-{periodTill}";
            statementData.Content = bFile;

            // write statement to database
            IStatementApi statementApi = new StatementApi(new StatementQuery(new WalletContext()), new AccountQuery(new WalletContext()));
            statementApi.WriteAccountStatementData(statementData);

            context.Response.Write("OK");

        }

        public bool IsReusable => false;
    }
}