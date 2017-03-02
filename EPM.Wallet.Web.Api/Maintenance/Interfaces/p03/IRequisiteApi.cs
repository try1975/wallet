using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IRequisiteApi : ITypedApi<RequisiteDto, Guid>
    {
        IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId);
    }
}