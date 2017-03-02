using System;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface ICardNewRequestApi : ITypedApi<CardNewRequestDto, Guid> {
        bool CreateCardNewRequest(string clientId);
    }
}