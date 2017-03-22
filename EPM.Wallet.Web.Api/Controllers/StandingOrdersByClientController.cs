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
    [RoutePrefix(prefix: WalletConstants.ClientAppApi.StandingOrdersByClient)]
    [Authorize]
    public class StandingOrdersByClientController : ApiController
    {
        private readonly IStandingOrderApi _standingOrderApi;

        public StandingOrdersByClientController(IStandingOrderApi standingOrderApi)
        {
            _standingOrderApi = standingOrderApi;
        }

        [HttpGet]
        [Route("", Name = nameof(GetStandingOrdersByClient) + Ro.Route)]
        public IEnumerable<StandingOrderInfoDto> GetStandingOrdersByClient(string clientId)
        {
            return _standingOrderApi.GetStandingOrdersByClient(clientId);
        }

        [HttpPost]
        [ResponseType(typeof(StandingOrderInfoDto))]
        [Route("", Name = nameof(PostStandingOrderByClient) + Ro.Route)]
        public IHttpActionResult PostStandingOrderByClient(string clientId, StandingOrderDto standingOrderDto)
        {
            var dto = _standingOrderApi.PostStandingOrderByClient(clientId, standingOrderDto);
            if (dto != null)
            {
                return Content(HttpStatusCode.Created, dto);
            }
            return StatusCode(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [ResponseType(typeof(StandingOrderInfoDto))]
        [Route("", Name = nameof(PutStandingOrderByClient) + Ro.Route)]
        public IHttpActionResult PutStandingOrderByClient(string clientId, StandingOrderDto standingOrderDto)
        {
            var dto = _standingOrderApi.PutStandingOrderByClient(clientId, standingOrderDto);
            if (dto != null)
            {
                return Content(HttpStatusCode.OK, dto);
            }
            return StatusCode(HttpStatusCode.Conflict);
        }

        [HttpDelete]
        [Route("{id:guid}", Name = nameof(DeleteStandingOrderByClient) + Ro.Route)]
        public IHttpActionResult DeleteStandingOrderByClient(string clientId, Guid id)
        {
            return StatusCode(_standingOrderApi.DeleteStandingOrderByClient(clientId, id) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
        }
    }
}
