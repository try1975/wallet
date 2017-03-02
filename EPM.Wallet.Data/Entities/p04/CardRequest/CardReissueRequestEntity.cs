using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class CardReissueRequestEntity : CardRequestEntity
    {
        public CardReissueType CardReissueType { get; set; }
        public string CardReissueReason { get; set; }
    }
}