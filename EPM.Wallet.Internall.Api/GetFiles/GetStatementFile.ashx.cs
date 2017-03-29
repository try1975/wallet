using System;
using System.IO;
using System.Web;
using EPM.Wallet.Data.SqlServer;
using EPM.Wallet.Data.SqlServer.QueryProcessors;

namespace WalletInternalApi.GetFiles
{
    /// <summary>
    /// Summary description for GetStatementFile
    /// </summary>
    public class GetStatementFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //if (!context.User.Identity.IsAuthenticated)
            //{
            //    context.Response.StatusCode = (int) HttpStatusCode.Unauthorized;
            //    return;
            //}

            // read from database
            var id = new Guid(context.Request.Params["Id"]);
            //context.Response.ContentType = "application/pdf";
            
            var statementQuery = new StatementQuery(new WalletContext());
            var statement = statementQuery.GetEntity(id);
            if (statement != null)
            {
                //var filename= Path.ChangeExtension(statement.LoadedFrom, ".pdf");
                var filename = statement.LoadedFrom;
                context.Response.AddHeader("content-disposition", $"attachment; filename={filename}");
                context.Response.BinaryWrite(statement.Content);
            }

        }

        public bool IsReusable => false;
    }
}