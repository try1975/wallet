using System;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface IBankApi : ITypedApi<BankDto, Guid> { }
}