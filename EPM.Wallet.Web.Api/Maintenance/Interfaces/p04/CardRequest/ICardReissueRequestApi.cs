using System;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardReissueRequestApi : ITypedApi<CardReissueRequestDto, Guid>
    {
        bool CreateCardReissueRequest(string clientId, CardReissueRequestDto dto);
    }
}