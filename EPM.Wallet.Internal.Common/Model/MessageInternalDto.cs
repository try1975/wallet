using System;
using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.Internal.Model
{
    public class MessageInternalDto :IDto<Guid>
    {
        public Guid Id { get; set; }
    }
}