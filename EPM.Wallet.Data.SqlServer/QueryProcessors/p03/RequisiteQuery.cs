using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class RequisiteQuery : TypedQuery<RequisiteEntity, Guid>, IRequisiteQuery { }
}