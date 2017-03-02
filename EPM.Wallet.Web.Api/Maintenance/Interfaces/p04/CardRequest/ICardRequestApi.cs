using System;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardRequestApi : ITypedApi<CardRequestDto, Guid>
    {
        
    }
}