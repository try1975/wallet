using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface IRequisiteApi : ITypedApi<RequisiteDto, Guid>
    {
        IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId);
    }
}