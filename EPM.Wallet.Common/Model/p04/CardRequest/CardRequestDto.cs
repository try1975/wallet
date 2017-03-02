using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Common.Model
{
    public class CardRequestDto : RequestDto
    {
        public Guid? CardId { get; set; }
    }
}