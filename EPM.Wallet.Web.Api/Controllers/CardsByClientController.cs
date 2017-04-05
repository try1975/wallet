using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EPM.Wallet.Common;
using WalletWebApi.Maintenance;
using WalletWebApi.Model;

namespace WalletWebApi.Controllers
{
    [RoutePrefix(WalletConstants.ClientAppApi.CardsByClient)]
    [Authorize]
    public class CardsByClientController : ApiController
    {
        private readonly ICardLimitRequestApi _apiCardLimit;
        private readonly ICardReissueRequestApi _apiCardReissue;
        private readonly ICardNewRequestApi _apiCardNew;
        private readonly ICardBlockRequestApi _apiCardBlock;
        private readonly ICardApi _apiCard;
        private readonly ExchangeServiceMailSender _mailSender;
        private const string MailBodySuffix = "card request";

        public CardsByClientController(ICardApi apiCard,
                                    ICardLimitRequestApi apiCardLimit,
                                    ICardReissueRequestApi apiCardReissue,
                                    ICardNewRequestApi apiCardNew,
                                    ICardBlockRequestApi apiCardBlock,
                                    ExchangeServiceMailSender mailSender)
        {
            _apiCard = apiCard;
            _apiCardLimit = apiCardLimit;
            _apiCardReissue = apiCardReissue;
            _apiCardNew = apiCardNew;
            _apiCardBlock = apiCardBlock;
            _mailSender = mailSender;
        }

        [HttpGet]
        [Route("", Name = nameof(GetCardByClient) + Ro.Route)]
        public IEnumerable<CardDto> GetCardByClient(string clientId)
        {
            return _apiCard.GetCardsByClient(clientId);
        }


        [HttpPost]
        [Route(WalletConstants.CardsByClientRoutes.SetLimit, Name = nameof(PostCardsByClientSetLimit) + Ro.Route)]
        public IHttpActionResult PostCardsByClientSetLimit(string clientId, CardLimitRequestDto dto)
        {
            var success = _apiCardLimit.CreateCardLimitRequest(clientId, dto);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            var subject = $"[{clientId}]";
            var body = $"{WalletConstants.CardsByClientRoutes.SetLimit} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailCardSetLimit);
            return StatusCode(HttpStatusCode.Created);
        }

        /// <summary>
        ///  Card reissue request. ReissueType in (Other, Lost, Stolen, Damaged)
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(WalletConstants.CardsByClientRoutes.Reissue, Name = nameof(PostCardsByClientReissue) + Ro.Route)]
        public IHttpActionResult PostCardsByClientReissue(string clientId, CardReissueRequestDto dto)
        {
            var success = _apiCardReissue.CreateCardReissueRequest(clientId, dto);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            var subject = $"[{clientId}]";
            var body = $"{WalletConstants.CardsByClientRoutes.Reissue} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailCardReissue);
            return StatusCode(HttpStatusCode.Created);
        }

        [HttpPost]
        [Route(WalletConstants.CardsByClientRoutes.New, Name = nameof(PostCardsByClientNew) + Ro.Route)]
        public IHttpActionResult PostCardsByClientNew(string clientId)
        {
            var success = _apiCardNew.CreateCardNewRequest(clientId);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            var subject = $"[{clientId}]";
            var body = $"{WalletConstants.CardsByClientRoutes.New} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailCardNew);
            return StatusCode(HttpStatusCode.Created);
        }

        [HttpPost]
        [Route(WalletConstants.CardsByClientRoutes.Block + "/{" + Ro.CardId + ":guid}", Name = nameof(PostCardsByClientBlock) + Ro.Route)]
        public IHttpActionResult PostCardsByClientBlock(string clientId, Guid cardId)
        {
            var success = _apiCardBlock.CreateCardBlockRequest(clientId, cardId);
            if (!success) return StatusCode(HttpStatusCode.Conflict);
            // send email
            var subject = $"[{clientId}]";
            var body = $"{WalletConstants.CardsByClientRoutes.Block} {MailBodySuffix}";
            _mailSender.SendMail(subject, body, AppGlobal.EmailCardBlock);
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
