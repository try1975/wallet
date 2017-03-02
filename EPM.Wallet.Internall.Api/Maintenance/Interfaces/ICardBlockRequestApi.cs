using System;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface ICardBlockRequestApi : ITypedApi<CardBlockRequestDto, Guid>
    {
        bool CreateCardBlockRequest(string clientId, Guid cardId);
    }
}