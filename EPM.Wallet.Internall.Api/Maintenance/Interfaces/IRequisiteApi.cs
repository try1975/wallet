using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface IRequisiteApi : ITypedApi<RequisiteDto, Guid>
    {
        IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId);
    }
}