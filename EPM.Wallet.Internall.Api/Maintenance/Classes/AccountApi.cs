using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class AccountApi : TypedApi<AccountDto, ClientAccountEntity, Guid>, IAccountApi
    {
        public AccountApi(IAccountQuery query) : base(query)
        {
        }

        public IEnumerable<AccountDto> GetAccountsByClient(string clientId)
        {
            var list = Query.GetEntities().Where(z=> z.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return Mapper.Map<List<AccountDto>>(list);
        }

        public AccountDto GetAccountByClient(string clientId, Guid accountId)
        {
            var entity = Query.GetEntity(accountId);
            if (entity == null) return null;
            if (!entity.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return null;
            return Mapper.Map<AccountDto>(entity);
        }

        public bool WriteEpmAccountBalance(string code, decimal balance)
        {
            try
            {
                var entity = Query.GetEntities().FirstOrDefault(z => z.Name.Equals(code, StringComparison.InvariantCultureIgnoreCase));
                if (entity == null) return false;
                entity.CurrentBalance = balance;
                Query.UpdateEntity(entity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                return false;
            }
            
        }
    }
}