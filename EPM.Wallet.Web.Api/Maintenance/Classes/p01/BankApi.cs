using System;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace WalletWebApi.Maintenance
{
    public class BankApi : TypedApi<BankDto, BankEntity, Guid>, IBankApi
    {
        public BankApi(IBankQuery query) : base(query)
        {
        }
    }
}