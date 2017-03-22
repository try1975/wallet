using System;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardLimitRequestApi : ITypedApi<CardLimitRequestDto, Guid>
    {
        bool CreateCardLimitRequest(string clientId, CardLimitRequestDto dto);
    }
}