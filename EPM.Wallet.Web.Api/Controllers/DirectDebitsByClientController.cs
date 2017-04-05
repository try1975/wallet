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
    [RoutePrefix(prefix: WalletConstants.ClientAppApi.DirectDebitsByClient)]
    [Authorize]
    public class DirectDebitsByClientController : ApiController
    {
        private readonly IDirectDebitApi _directDebitApi;

        public DirectDebitsByClientController(IDirectDebitApi directDebitApi)
        {
            _directDebitApi = directDebitApi;
        }

        [HttpGet]
        [Route("", Name = nameof(GetDirectDebitsByClient) + Ro.Route)]
        public IEnumerable<DirectDebitDto> GetDirectDebitsByClient(string clientId)
        {
            return _directDebitApi.GetDirectDebitsByClient(clientId);
        }

        [HttpPost]
        [ResponseType(typeof(DirectDebitDto))]
        [Route("", Name = nameof(PostDirectDebitByClient) + Ro.Route)]
        public IHttpActionResult PostDirectDebitByClient(string clientId, DirectDebitDto directDebitDto)
        {
            var dto = _directDebitApi.PostDirectDebitByClient(clientId, directDebitDto);
            if (dto != null)
            {
                return Content(HttpStatusCode.Created, dto);
            }
            return StatusCode(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [ResponseType(typeof(DirectDebitDto))]
        [Route("", Name = nameof(PutDirectDebitByClient) + Ro.Route)]
        public IHttpActionResult PutDirectDebitByClient(string clientId, DirectDebitDto directDebitDto)
        {
            var dto = _directDebitApi.PutDirectDebitByClient(clientId, directDebitDto);
            if (dto != null)
            {
                return Content(HttpStatusCode.OK, dto);
            }
            return StatusCode(HttpStatusCode.Conflict);
        }

        [HttpDelete]
        [Route("{id:guid}", Name = nameof(DeleteDirectDebitByClient) + Ro.Route)]
        public IHttpActionResult DeleteDirectDebitByClient(string clientId, Guid id)
        {
            return StatusCode(_directDebitApi.DeleteDirectDebitByClient(clientId, id) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
        }
    }
}
