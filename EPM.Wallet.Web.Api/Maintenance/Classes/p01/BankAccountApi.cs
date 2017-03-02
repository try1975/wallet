using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace WalletWebApi.Maintenance
{
    public class BankAccountApi : TypedApi<BankAccountDto, BankAccountEntity, Guid>, IBankAccountApi
    {
        public BankAccountApi(IBankAccountQuery query) : base(query)
        {
        }

        public IEnumerable<BankAccountDto> GetBankAccountsByBankId(Guid bankId)
        {
            var list = _query.GetEntities().Where(ba => ba.BankId == bankId).ToList();
            return Mapper.Map<List<BankAccountDto>>(list);
        }
        public IEnumerable<BankAccountDto> GetBankAccountsByBankName(string bankName)
        {
            var list = _query.GetEntities().Where(ba => ba.Bank.Name == bankName).ToList();
            return Mapper.Map<List<BankAccountDto>>(list);
        }
    }
}