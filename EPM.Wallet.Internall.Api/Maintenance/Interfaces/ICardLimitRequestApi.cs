using System;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface ICardLimitRequestApi : ITypedApi<CardLimitRequestDto, Guid>
    {
        bool CreateCardLimitRequest(string clientId, CardLimitRequestDto dto);
    }
}