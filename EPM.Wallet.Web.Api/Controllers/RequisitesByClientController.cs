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
    [RoutePrefix(WalletConstants.ClientAppApi.RequisitesByClient)]
    [Authorize]
    public class RequisitesByClientController : ApiController
    {
        private readonly IRequisiteApi _requisiteApi;

        public RequisitesByClientController(IRequisiteApi requisiteApi)
        {
            _requisiteApi = requisiteApi;
        }   

        [HttpGet]
        [Route("", Name = nameof(GetRequisitesByClient) + Ro.Route)]
        public IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId)
        {
            return _requisiteApi.GetRequisitesByClient(clientId);
        }

        [HttpGet]
        [Route("{id:guid}", Name = nameof(GetRequisiteByClient) + Ro.Route)]
        [ResponseType(typeof(RequisiteDto))]
        public IHttpActionResult GetRequisiteByClient(string clientId, Guid id)
        {
            return Ok(_requisiteApi.GetRequisiteByClient(clientId, id));
        }

        [HttpPost]
        [ResponseType(typeof(RequisiteDto))]
        [Route("", Name = nameof(PostRequisiteByClient) + Ro.Route)]
        public IHttpActionResult PostRequisiteByClient(string clientId, RequisiteDto requisiteDto)
        {
            if (requisiteDto == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(_requisiteApi.PostRequisiteByClient(clientId, requisiteDto));
        }

        [HttpPut]
        [ResponseType(typeof(RequisiteDto))]
        [Route("", Name = nameof(PutRequisiteByClient) + Ro.Route)]
        public IHttpActionResult PutRequisiteByClient(string clientId, RequisiteDto changedDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dto = _requisiteApi.PutRequisiteByClient(clientId, changedDto);
            if (dto == null)
            {
                return BadRequest("PUT failed.");
            }
            return Ok(dto);
        }


        [HttpDelete]
        [Route("{id:guid}", Name = nameof(DeleteRequisiteByClient) + Ro.Route)]
        public IHttpActionResult DeleteRequisiteByClient(string clientId, Guid id)
        {
            return StatusCode(_requisiteApi.DeleteRequisiteByClient(clientId, id) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
        }
    }
}
