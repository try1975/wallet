using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class CardDataM�nager : TypedDataM�nager<CardDto, Guid>, ICardDataM�nager
    {
        public CardDataM�nager() : base(WalletConstants.ClientAppApi.Cards)
        {
        }
    }
}