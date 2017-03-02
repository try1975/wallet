using System.Data.Entity;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class ClientQuery : TypedQuery<ClientEntity, string>, IClientQuery
    {
        public override  ClientEntity GetEntity(string id)
        {
            var client = base.GetEntity(id);
            Db.Entry(client).Collection(w => w.Cards).Load();
            //Db.Entry(client).Collection(w => w.ClientAccounts).Query().Include(d => d.BankAccount).Include(r => r.BankAccount.Bank).Load();
            Db.Entry(client).Collection(w => w.ClientAccounts).Query().Include(d => d.Requisite).Load();
            return client;
        }
    }
}