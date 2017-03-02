using System;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Common.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EPM.Wallet.Common.Model
{
    public class RequestDto : IDto<Guid>
    {
        private DateTime? _createdAt;
        public Guid Id { get; set; }
        public DateTime Date
        {
            get
            {
                return _createdAt ?? DateTime.UtcNow;
            }
            set { _createdAt = value; }
        }
        public string ClientId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RequestType Type { get; set; }
        public string SubType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RequestStatus Status { get; set; }
    }
}