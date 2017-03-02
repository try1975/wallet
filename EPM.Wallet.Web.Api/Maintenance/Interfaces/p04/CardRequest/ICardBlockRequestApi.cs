using System;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardBlockRequestApi : ITypedApi<CardBlockRequestDto, Guid>
    {
        bool CreateCardBlockRequest(string clientId, Guid cardId);
    }
}