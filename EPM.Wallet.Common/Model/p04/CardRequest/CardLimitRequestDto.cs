using System;
using EPM.Wallet.Common.Interfaces;
using Newtonsoft.Json;

namespace EPM.Wallet.Common.Model
{
    public class CardLimitRequestDto : IDto<Guid>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid CardId { get; set; }
        public int Limit { get; set; }
        
    }
}