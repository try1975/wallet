using System;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface ICardNewRequestApi : ITypedApi<CardNewRequestDto, Guid> {
        bool CreateCardNewRequest(string clientId);
    }
}