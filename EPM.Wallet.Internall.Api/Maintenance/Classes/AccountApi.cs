﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
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
    }
}