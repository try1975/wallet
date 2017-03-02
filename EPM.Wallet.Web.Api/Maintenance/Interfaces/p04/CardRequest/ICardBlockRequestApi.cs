using System;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface ICardBlockRequestApi : ITypedApi<CardBlockRequestDto, Guid>
    {
        bool CreateCardBlockRequest(string clientId, Guid cardId);
    }
}