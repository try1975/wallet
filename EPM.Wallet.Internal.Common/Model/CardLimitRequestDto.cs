using System;
using Newtonsoft.Json;

namespace EPM.Wallet.Internal.Model
{
    public class CardLimitRequestDto : IDto<Guid>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid CardId { get; set; }
        public int Limit { get; set; }
        
    }
}