using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface ITransactionApi : ITypedApi<TransactionDto, Guid>
    {
        IEnumerable<TransactionDto> GetTransactionsByAccount(string clientId, Guid accountId);
    }
}