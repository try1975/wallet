using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Description;
using EPM.Wallet.Common;
using WalletWebApi.GetFiles;
using WalletWebApi.Maintenance;
using WalletWebApi.Model;

namespace WalletWebApi.Controllers
{
    [RoutePrefix(WalletConstants.ClientAppApi.AccountsByClient)]
    [Authorize]
    public class AccountsByClientController : ApiController
    {
        private readonly IAccountApi _accountApi;
        private readonly IAccountRequestApi _accountRequestApi;

        public AccountsByClientController(IAccountApi accountApi, IAccountRequestApi accountRequestApi)
        {
            _accountApi = accountApi;
            _accountRequestApi = accountRequestApi;
        }

        [HttpGet]
        [Route("", Name = nameof(GetAccountsByClient) + Ro.Route)]
        public IEnumerable<AccountDto> GetAccountsByClient(string clientId)
        {
            var list = _accountApi.GetAccountsByClient(clientId);
            var baseUri = $"{Request.RequestUri.Scheme}://{Request.RequestUri.Host}:{Request.RequestUri.Port}";
            var accountsByClient = list as AccountDto[] ?? list.ToArray();
            foreach (var account in accountsByClient)
            {
                if (!account.StatementId.HasValue) continue;

                var uri = $"{baseUri}/GetFiles/{nameof(GetStatementFile)}.ashx?id={account.StatementId}";
                account.LastStatementLink = new Uri(uri);
            }


            return accountsByClient;


        }

        [HttpGet]
        [ResponseType(typeof(AccountDto))]
        [Route("{" + Ro.AccountId + ":guid}",
            Name = nameof(GetAccountByClient) + Ro.Route)]
        public IHttpActionResult GetAccountByClient(string clientId, Guid accountId)
        {
            var dto = _accountApi.GetAccountByClient(clientId, accountId);
            if (!dto.StatementId.HasValue) return Ok(dto);

            var baseUri = $"{Request.RequestUri.Scheme}://{Request.RequestUri.Host}:{Request.RequestUri.Port}";
            var uri = $"{baseUri}/GetFiles/{nameof(GetStatementFile)}.ashx?id={dto.StatementId}";
            dto.LastStatementLink = new Uri(uri);
            return Ok(dto);
        }

        [HttpPost]
        [Route("", Name = nameof(PostAccountsByClientNewRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientNewRequest(string clientId, AccountNewRequestDto dto)
        {
            return
                StatusCode(_accountRequestApi.CreateAccountNewRequest(clientId, dto)
                    ? HttpStatusCode.NoContent
                    : HttpStatusCode.Conflict);
        }

        [HttpPost]
        [Route("{" + Ro.AccountId + ":guid}/" + WalletConstants.AccountByClientRoutes.Refill,
            Name = nameof(PostAccountsByClientRefillRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientRefillRequest(string clientId, Guid accountId, RefillRequestDto dto)
        {
            return
                StatusCode(_accountRequestApi.CreateAccountRefillRequest(clientId, accountId, dto).Result
                    ? HttpStatusCode.NoContent
                    : HttpStatusCode.Conflict);
        }

        [HttpPost]
        [Route("{" + Ro.AccountId + ":guid}/" + WalletConstants.AccountByClientRoutes.TransferToCard,
            Name = nameof(PostAccountsByClientTransferToCardRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientTransferToCardRequest(string clientId, Guid accountId,
            TransferToCardRequestDto dto)
        {
            return
                StatusCode(_accountRequestApi.CreateAccountTransferToCardRequest(clientId, accountId, dto)
                    ? HttpStatusCode.NoContent
                    : HttpStatusCode.Conflict);
        }

        [HttpPost]
        [Route("{" + Ro.AccountId + ":guid}/" + WalletConstants.AccountByClientRoutes.TransferOut,
            Name = nameof(PostAccountsByClientTransferOutRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientTransferOutRequest(string clientId, Guid accountId, TransferOutRequestDto dto)
        {
            var success = _accountRequestApi.CreateAccountTransferOutRequest(clientId, accountId, dto);
            if (!success) return StatusCode(HttpStatusCode.Conflict);

            using (var message = new MailMessage())
            {
                message.To.Add(AppGlobal.EmailAboutTransferOut);
                message.Body = $"ClientId: {clientId}\nAmount: {dto.Amount}";
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "Account TransferOut request";
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                try
                {
                    var smtpClient = new SmtpClient();
                    smtpClient.Send(message);
                }
                catch (Exception) {/*ignored*/}
            }
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}