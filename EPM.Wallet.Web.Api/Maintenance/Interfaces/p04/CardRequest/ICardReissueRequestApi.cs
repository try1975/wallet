using System;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardReissueRequestApi : ITypedApi<CardReissueRequestDto, Guid>
    {
        bool CreateCardReissueRequest(string clientId, CardReissueRequestDto dto);
    }
}