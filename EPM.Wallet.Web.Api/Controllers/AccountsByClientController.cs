using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using EPM.Wallet.Common;
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
            return _accountApi.GetAccountsByClient(clientId);
        }

        [HttpGet]
        [ResponseType(typeof(AccountDto))]
        [Route("{" + Ro.AccountId + ":guid}",
            Name = nameof(GetAccountByClient) + Ro.Route)]
        public IHttpActionResult GetAccountByClient(string clientId, Guid accountId)
        {
            return Ok(_accountApi.GetAccountByClient(clientId, accountId));
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
        public IHttpActionResult PostAccountsByClientTransferOutRequest(string clientId, Guid accountId,
            TransferOutRequestDto dto)
        {
            return
                StatusCode(_accountRequestApi.CreateAccountTransferOutRequest(clientId, accountId, dto)
                    ? HttpStatusCode.NoContent
                    : HttpStatusCode.Conflict);
        }
    }
}