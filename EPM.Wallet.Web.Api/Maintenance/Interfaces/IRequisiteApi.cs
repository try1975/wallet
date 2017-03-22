using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IRequisiteApi : ITypedApi<RequisiteDto, Guid>
    {
        IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId);
        RequisiteDto GetRequisiteByClient(string clientId, Guid id);
        RequisiteDto PostRequisiteByClient(string clientId, RequisiteDto dto);
        RequisiteDto PutRequisiteByClient(string clientId, RequisiteDto dto);
        bool DeleteRequisiteByClient(string clientId, Guid id);
    }
}