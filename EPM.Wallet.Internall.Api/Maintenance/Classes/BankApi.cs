using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class BankApi : TypedApi<BankDto, BankEntity, Guid>, IBankApi
    {
        public BankApi(IBankQuery query) : base(query)
        {
        }
    }
}