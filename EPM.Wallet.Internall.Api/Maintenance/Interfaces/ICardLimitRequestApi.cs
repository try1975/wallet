using System;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface ICardLimitRequestApi : ITypedApi<CardLimitRequestDto, Guid>
    {
        bool CreateCardLimitRequest(string clientId, CardLimitRequestDto dto);
    }
}