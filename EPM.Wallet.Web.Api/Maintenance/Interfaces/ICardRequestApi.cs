using System;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardRequestApi : ITypedApi<CardRequestDto, Guid>
    {
        
    }
}