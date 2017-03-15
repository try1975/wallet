using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class MessageDataManager : TypedDataMаnager<MessageDto, Guid>, IMessageDataManager
    {
        public MessageDataManager() : base(WalletConstants.ClientAppApi.Messages)
        {
        }
    }
}