using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class CardDataMànager : TypedDataMànager<CardDto, Guid>, ICardDataMànager
    {
        public CardDataMànager() : base(WalletConstants.ClientAppApi.Cards)
        {
        }
    }
}