using System;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardNewRequestApi : ITypedApi<CardNewRequestDto, Guid> {
        bool CreateCardNewRequest(string clientId);
    }
}