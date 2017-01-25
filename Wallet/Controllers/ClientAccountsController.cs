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
    public class ClientAccountsController : ApiController
    {
        private WalletModel db = new WalletModel();

        // GET: api/ClientAccounts
        public IQueryable<ClientAccount> GetClientAccounts()
        {
            return db.ClientAccounts;
        }

        // GET: api/ClientAccounts/5
        [ResponseType(typeof(ClientAccount))]
        public async Task<IHttpActionResult> GetClientAccount(int id)
        {
            ClientAccount clientAccount = await db.ClientAccounts.FindAsync(id);
            if (clientAccount == null)
            {
                return NotFound();
            }

            return Ok(clientAccount);
        }

        // PUT: api/ClientAccounts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClientAccount(int id, ClientAccount clientAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientAccount.Id)
            {
                return BadRequest();
            }

            db.Entry(clientAccount).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientAccountExists(id))
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

        // POST: api/ClientAccounts
        [ResponseType(typeof(ClientAccount))]
        public async Task<IHttpActionResult> PostClientAccount(ClientAccount clientAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClientAccounts.Add(clientAccount);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = clientAccount.Id }, clientAccount);
        }

        // DELETE: api/ClientAccounts/5
        [ResponseType(typeof(ClientAccount))]
        public async Task<IHttpActionResult> DeleteClientAccount(int id)
        {
            ClientAccount clientAccount = await db.ClientAccounts.FindAsync(id);
            if (clientAccount == null)
            {
                return NotFound();
            }

            db.ClientAccounts.Remove(clientAccount);
            await db.SaveChangesAsync();

            return Ok(clientAccount);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientAccountExists(int id)
        {
            return db.ClientAccounts.Count(e => e.Id == id) > 0;
        }
    }
}