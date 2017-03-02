using System;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface ICardNewRequestApi : ITypedApi<CardNewRequestDto, Guid> {
        bool CreateCardNewRequest(string clientId);
    }
}