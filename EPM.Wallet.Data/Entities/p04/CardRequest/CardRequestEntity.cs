using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class CardRequestEntity : RequestEntity
    {
        public CardRequestType CardRequestType { get; set; }
    }
}