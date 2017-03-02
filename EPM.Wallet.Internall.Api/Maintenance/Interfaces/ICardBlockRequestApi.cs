using System;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface ICardBlockRequestApi : ITypedApi<CardBlockRequestDto, Guid>
    {
        bool CreateCardBlockRequest(string clientId, Guid cardId);
    }
}