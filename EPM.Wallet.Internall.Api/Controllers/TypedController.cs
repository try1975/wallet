﻿using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EPM.Wallet.Common.Interfaces;
using EPM.Wallet.Internall.Api.Maintenance;

namespace EPM.Wallet.Internall.Api.Controllers
{
    [Authorize]
    public abstract class TypedController<T, K> : ApiController where T : class, IDto<K>
    {
        protected readonly  ITypedApi<T, K> _api;

        protected TypedController(ITypedApi<T, K> api)
        {
            _api = api;
        }

        public IEnumerable<T> Get()
        {
            return _api.GetItems();
        }

        public IHttpActionResult Get(K id)
        {
            var dto = _api.GetItem(id);
            if (dto == null) return NotFound();
            return Ok(dto);
        }

        public IHttpActionResult Post(T creatingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dto = _api.AddItem(creatingDto);
            if (dto == null)
            {
                return BadRequest("POST failed.");
            }
            return CreatedAtRoute("DefaultApi", new { id = dto.Id }, dto);
        }

        public IHttpActionResult Put(T changedDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dto = _api.ChangeItem(changedDto);
            if (dto == null)
            {
                return BadRequest("PUT failed.");
            }
            return CreatedAtRoute("PutBankV1Route", new { id = dto.Id }, dto);
        }

        public IHttpActionResult Delete(K id)
        {
            return StatusCode(_api.RemoveItem(id) ? HttpStatusCode.NoContent : HttpStatusCode.Conflict);
        }
    }
  
}
