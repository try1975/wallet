using System;

namespace EPM.Wallet.Internal.Model
{
    public class MessageInternalDto :IDto<Guid>
    {
        public Guid Id { get; set; }
    }
}