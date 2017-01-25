using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Wallet.Models;
using Wallet.Models.Entities;

namespace Wallet.Controllers
{
    public class ClientAccountStatusController : ApiController
    {
        private WalletModel db = new WalletModel();

        // GET: api/ClientAccountStatus
        public IQueryable<ClientAccountStatus> GetClientAccountStatuses()
        {
            return db.ClientAccountStatuses;
        }

        // GET: api/ClientAccountStatus/5
        [ResponseType(typeof(ClientAccountStatus))]
        public async Task<IHttpActionResult> GetClientAccountStatus(int id)
        {
            ClientAccountStatus clientAccountStatus = await db.ClientAccountStatuses.FindAsync(id);
            if (clientAccountStatus == null)
            {
                return NotFound();
            }

            return Ok(clientAccountStatus);
        }

        // PUT: api/ClientAccountStatus/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClientAccountStatus(int id, ClientAccountStatus clientAccountStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientAccountStatus.Id)
            {
                return BadRequest();
            }

            db.Entry(clientAccountStatus).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientAccountStatusExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ClientAccountStatus
        [ResponseType(typeof(ClientAccountStatus))]
        public async Task<IHttpActionResult> PostClientAccountStatus(ClientAccountStatus clientAccountStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClientAccountStatuses.Add(clientAccountStatus);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = clientAccountStatus.Id }, clientAccountStatus);
        }

        // DELETE: api/ClientAccountStatus/5
        [ResponseType(typeof(ClientAccountStatus))]
        public async Task<IHttpActionResult> DeleteClientAccountStatus(int id)
        {
            ClientAccountStatus clientAccountStatus = await db.ClientAccountStatuses.FindAsync(id);
            if (clientAccountStatus == null)
            {
                return NotFound();
            }

            db.ClientAccountStatuses.Remove(clientAccountStatus);
            await db.SaveChangesAsync();

            return Ok(clientAccountStatus);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientAccountStatusExists(int id)
        {
            return db.ClientAccountStatuses.Count(e => e.Id == id) > 0;
        }
    }
}