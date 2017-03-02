using System;

namespace EPM.Wallet.Internal.Model
{
    public class CardRequestDto : RequestDto
    {
        public Guid? CardId { get; set; }
    }
}