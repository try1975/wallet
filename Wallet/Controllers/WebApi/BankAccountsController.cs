using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Wallet.Models;
using Wallet.Models.Entities;

namespace Wallet.Controllers.WebApi
{
    public class BankAccountsController : ApiController
    {
        private WalletModel db = new WalletModel();

        // GET: api/BankAccounts
        public IQueryable<BankAccount> GetBankAccounts()
        {
            return db.BankAccounts.Include("Bank");
        }

        // GET: api/BankAccounts/5
        [ResponseType(typeof(BankAccount))]
        public async Task<IHttpActionResult> GetBankAccount(int id)
        {
            BankAccount bankAccount = await db.BankAccounts.FindAsync(id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return Ok(bankAccount);
        }

        // PUT: api/BankAccounts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBankAccount(int id, BankAccount bankAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bankAccount.Id)
            {
                return BadRequest();
            }

            db.Entry(bankAccount).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankAccountExists(id))
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

        // POST: api/BankAccounts
        [ResponseType(typeof(BankAccount))]
        public async Task<IHttpActionResult> PostBankAccount(BankAccount bankAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Bank bank = await db.Banks.FindAsync(bankAccount.Bank.Id);
            if (bank != null)
            {
                bankAccount.Bank = bank;
            }


            db.BankAccounts.Add(bankAccount);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bankAccount.Id }, bankAccount);
        }

        // DELETE: api/BankAccounts/5
        [ResponseType(typeof(BankAccount))]
        public async Task<IHttpActionResult> DeleteBankAccount(int id)
        {
            BankAccount bankAccount = await db.BankAccounts.FindAsync(id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            db.BankAccounts.Remove(bankAccount);
            await db.SaveChangesAsync();

            return Ok(bankAccount);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BankAccountExists(int id)
        {
            return db.BankAccounts.Count(e => e.Id == id) > 0;
        }
    }
}