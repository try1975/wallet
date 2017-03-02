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

        public CardsByClientController(ICardApi apiCard,
                                    ICardLimitRequestApi apiCardLimit,
                                    ICardReissueRequestApi apiCardReissue,
                                    ICardNewRequestApi apiCardNew,
                                    ICardBlockRequestApi apiCardBlock)
        {
            _apiCard = apiCard;
            _apiCardLimit = apiCardLimit;
            _apiCardReissue = apiCardReissue;
            _apiCardNew = apiCardNew;
            _apiCardBlock = apiCardBlock;
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
            return StatusCode(_apiCardLimit.CreateCardLimitRequest(clientId, dto) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
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
            return StatusCode(_apiCardReissue.CreateCardReissueRequest(clientId, dto) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
        }

        [HttpPost]
        [Route(WalletConstants.CardsByClientRoutes.New, Name = nameof(PostCardsByClientNew) + Ro.Route)]
        public IHttpActionResult PostCardsByClientNew(string clientId)
        {
            return StatusCode(_apiCardNew.CreateCardNewRequest(clientId) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
        }

        [HttpPost]
        [Route(WalletConstants.CardsByClientRoutes.Block + "/{" + Ro.CardId + ":guid}", Name = nameof(PostCardsByClientBlock) + Ro.Route)]
        public IHttpActionResult PostCardsByClientBlock(string clientId, Guid cardId)
        {
            return StatusCode(_apiCardBlock.CreateCardBlockRequest(clientId, cardId) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
        }
    }
}
