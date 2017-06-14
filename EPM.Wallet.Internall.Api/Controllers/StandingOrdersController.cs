using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;
using System.Web.Http;

namespace WalletInternalApi.Controllers
{
    public class StandingOrdersController : TypedController<StandingOrderDto, Guid>
    {
        private readonly ExchangeServiceMailSender _mailSender;
        private readonly IAccountRequestApi _accountRequestApi;

        public StandingOrdersController(IStandingOrderApi api, IAccountRequestApi accountRequestApi, ExchangeServiceMailSender mailSender) : base(api)
        {
            _accountRequestApi = accountRequestApi;
            _mailSender = mailSender;
        }

        [HttpPost]
        [Route("api/StandingOrders/CreateRequest/{" + Ro.StandingOrderId + ":guid}",Name = nameof(CreateRequest) + Ro.Route)]
        public Guid CreateRequest(Guid standingOrderId)
        {
            var id = ((IStandingOrderApi)_api).CreateRequestByStandingOrder(standingOrderId);
            // send email
            if (id.Equals(Guid.Empty)) return id;
            var request = _accountRequestApi.GetItem(id);
            var clientId = request.ClientId;
            var subject = $"[{clientId}]";
            const string body = "Transfer Out request by Standing Order";
            _mailSender.SendMail(subject, body, AppGlobal.EmailAccountTransferOut);
            return id;
        }
    }
}
