﻿using System;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Common.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EPM.Wallet.Internal.Model
{
    public class CardReissueRequestDto : IDto<Guid>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid CardId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CardReissueType ReissueType { get; set; }
        public string Reason { get; set; }
    }
}