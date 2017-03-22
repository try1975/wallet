using System;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class TransactionApi : TypedApi<TransactionDto, TransactionEntity, Guid>, ITransactionApi
    {
        public TransactionApi(ITransactionQuery query) : base(query)
        {
        }
    }
}