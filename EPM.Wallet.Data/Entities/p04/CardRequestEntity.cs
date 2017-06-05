using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class CardRequestEntity : RequestEntity
    {
        public CardRequestType CardRequestType { get; set; }
        public int Limit { get; set; }
        public CardReissueType CardReissueType { get; set; }
        public string CardReissueReason { get; set; }
    }
}