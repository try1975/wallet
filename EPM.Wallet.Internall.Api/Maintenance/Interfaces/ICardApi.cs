using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface ICardApi : ITypedApi<CardDto, Guid>
    {
        IEnumerable<CardDto> GetCardsByClient(string clientId);
    }
}