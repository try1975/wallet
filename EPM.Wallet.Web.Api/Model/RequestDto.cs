using System;
using EPM.Wallet.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WalletWebApi.Model
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
        [JsonIgnore]
        public string SubTypeOld { get; set; }

        public string SubType
        {
            get
            {
                if (SubTypeOld.Equals(nameof(AccountRequestType.TransferOut))) return "Transfer Out";
                if (SubTypeOld.Equals(nameof(AccountRequestType.TransferToCard))) return "Transfer To Card";
                if (SubTypeOld.Equals(nameof(AccountRequestType.Refill))) return "Inter Account Transfer";
                if (SubTypeOld.Equals(nameof(AccountRequestType.AccountTopUp))) return "Account TopUp";
                return SubTypeOld;
            }
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public RequestStatus Status { get; set; }
        //public RequisiteDto Requisite { get; set; }
    }
}