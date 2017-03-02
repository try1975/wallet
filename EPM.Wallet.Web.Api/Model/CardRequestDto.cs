using System;

namespace WalletWebApi.Model
{
    public class CardRequestDto : RequestDto
    {
        public Guid? CardId { get; set; }
    }
}