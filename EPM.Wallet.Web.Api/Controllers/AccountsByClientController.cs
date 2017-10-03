using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        private readonly ITransactionApi _transactionApi;
        private readonly ExchangeServiceMailSender _mailSender;
        private readonly IClientApi _clientApi;
        private const string MailBodySuffix = "account request";

        public AccountsByClientController(IAccountApi accountApi, 
                                        IAccountRequestApi accountRequestApi, 
                                        ITransactionApi transactionApi,
                                        IClientApi clientApi,
                                        ExchangeServiceMailSender mailSender)
        {
            _accountApi = accountApi;
            _accountRequestApi = accountRequestApi;
            _transactionApi = transactionApi;
            _mailSender = mailSender;
            _clientApi = clientApi;
        }

        [HttpGet]
        [Route("", Name = nameof(GetAccountsByClient) + Ro.Route)]
        public IEnumerable<AccountDto> GetAccountsByClient(string clientId)
        {
            var list = _accountApi.GetAccountsByClient(clientId);
            var dtos = list ?? new List<AccountDto>();
            var baseUri = $"{Request.RequestUri.Scheme}://{Request.RequestUri.Host}:{Request.RequestUri.Port}";
            foreach (var account in dtos)
            {
                if (!account.StatementId.HasValue) continue;

                var uri = $"{baseUri}/GetFiles/{nameof(GetStatementFile)}.ashx?id={account.StatementId}";
                account.LastStatementLink = new Uri(uri);
            }
            return dtos;
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

        [HttpGet]
        [Route("{" + Ro.AccountId + ":guid}/Transactions",
            Name = nameof(GetTransactionsByAccount) + Ro.Route)]
        public IEnumerable<TransactionDto> GetTransactionsByAccount(string clientId, Guid accountId, int from = 0, int count = 0)
        {
            var list = _transactionApi.GetTransactionsByAccount(clientId, accountId, from, count);
            var dtos = list ?? new List<TransactionDto>();
            return dtos;
        }

        //[HttpGet]
        //[Route("{" + Ro.AccountId + ":guid}/TransferOuts",
        //    Name = nameof(GetTransferOutsByAccount) + Ro.Route)]
        //public IEnumerable<TransactionDto> GetTransferOutsByAccount(string clientId, Guid accountId, int from = 0, int count = 0)
        //{
        //    return _transactionApi.GetTransactionsByAccount(clientId, accountId, from, count);
        //}

        [HttpPost]
        [Route("", Name = nameof(PostAccountsByClientNewRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientNewRequest(string clientId, AccountNewRequestDto dto)
        {
            var success = _accountRequestApi.CreateAccountNewRequest(clientId, dto);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            var subject = $"[{clientId}]";
            var body = $"{WalletConstants.AccountByClientRoutes.New} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailAccountNew);
            return StatusCode(HttpStatusCode.Created);
        }

        [HttpPost]
        [Route("{" + Ro.AccountId + ":guid}/" + WalletConstants.AccountByClientRoutes.Refill,
            Name = nameof(PostAccountsByClientRefillRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientRefillRequest(string clientId, Guid accountId, RefillRequestDto dto)
        {
            var success = _accountRequestApi.CreateAccountRefillRequest(clientId, accountId, dto);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            var subject = $"[{clientId}]";
            var body = $"{WalletConstants.AccountByClientRoutes.Refill} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailAccountRefill);
            return StatusCode(HttpStatusCode.Created);
        }

        [HttpPost]
        [Route("{" + Ro.AccountId + ":guid}/" + WalletConstants.AccountByClientRoutes.TransferToCard,
            Name = nameof(PostAccountsByClientTransferToCardRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientTransferToCardRequest(string clientId, Guid accountId, TransferToCardRequestDto dto)
        {
            var success = _accountRequestApi.CreateAccountTransferToCardRequest(clientId, accountId, dto);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            
            var subject = $"[{clientId}]";
            var body = $"{WalletConstants.AccountByClientRoutes.TransferToCard} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailAccountTransferToCard);
            return StatusCode(HttpStatusCode.Created);
        }

        [HttpPost]
        [Route("{" + Ro.AccountId + ":guid}/" + WalletConstants.AccountByClientRoutes.TransferOut,
            Name = nameof(PostAccountsByClientTransferOutRequest) + Ro.Route)]
        public IHttpActionResult PostAccountsByClientTransferOutRequest(string clientId, Guid accountId, TransferOutRequestDto dto)
        {
            var success = _accountRequestApi.CreateAccountTransferOutRequest(clientId, accountId, dto);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            var subject = $"[{_clientApi.GetItem(clientId).Name}]  [{_accountApi.GetItem(accountId).CurrencyId} account]";
            var body = $"{WalletConstants.AccountByClientRoutes.TransferOut} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailAccountTransferOut);
            return StatusCode(HttpStatusCode.Created);
        }
    }
}