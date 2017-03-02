using System;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface ICardReissueRequestApi : ITypedApi<CardReissueRequestDto, Guid>
    {
        bool CreateCardReissueRequest(string clientId, CardReissueRequestDto dto);
    }
}