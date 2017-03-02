using System;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface ICardReissueRequestApi : ITypedApi<CardReissueRequestDto, Guid>
    {
        bool CreateCardReissueRequest(string clientId, CardReissueRequestDto dto);
    }
}