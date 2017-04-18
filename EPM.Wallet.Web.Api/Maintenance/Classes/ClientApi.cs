using System.Data.Entity;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{

    public class ClientApi : TypedApi<ClientDto, ClientEntity, string>, IClientApi
    {
        private readonly IAccountQuery _accountQuery;

        public ClientApi(IClientQuery query, IAccountQuery accountQuery) : base(query)
        {
            _accountQuery = accountQuery;
        }

        public override ClientDto GetItem(string id)
        {
            var clientEntity = _query.GetEntities()
                .Where(z => z.Id.Equals(id))
                .Include(nameof(ClientEntity.Cards))
                .Include(nameof(ClientEntity.ClientAccounts))
                .FirstOrDefault()
                ;
            return Mapper.Map<ClientDto>(clientEntity);
            if (clientEntity == null) return Mapper.Map<ClientDto>(clientEntity);
            foreach (var clientAccountEntity in clientEntity.ClientAccounts)
            {
                //_query.GetDbContext().Entry(clientAccountEntity)
                //    .Reference(nameof(ClientAccountEntity.BankAccount))
                //    .Load()
                //    ;
                var accountEntity = _accountQuery.GetEntities()
                    .Where(z=>z.Id.Equals(clientAccountEntity.Id))
                    .Include(i=>i.BankAccount)
                    .Include(i => i.BankAccount.Bank)
                    .FirstOrDefault()
                    ;
                if (accountEntity != null)
                {
                    var requisiteEntity = new RequisiteEntity()
                    {
                        Name = accountEntity.Name,
                        BankName = accountEntity.BankAccount.Bank.Name,
                        BankAddress = "",
                        Bic = "",
                        Iban = accountEntity.BankAccount.Name,
                        OwnerName = accountEntity.Name
                    };
                    clientAccountEntity.Requisite = requisiteEntity;
                }
            }
            return Mapper.Map<ClientDto>(clientEntity);
        }
    }
}