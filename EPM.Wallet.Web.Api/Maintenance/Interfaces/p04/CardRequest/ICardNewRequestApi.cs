using System;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardNewRequestApi : ITypedApi<CardNewRequestDto, Guid> {
        bool CreateCardNewRequest(string clientId);
    }
}