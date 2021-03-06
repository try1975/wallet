﻿using System;
using EPM.Wallet.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WalletWebApi.Model
{
    public class AccountDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string CurrencyId { get; set; }
        public string ClientId { get; set; }
        //public Guid BankAccountId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ClientAccountStatus ClientAccountStatus { get; set; }
        public decimal CurrentBalance { get; set; }

        public RequisiteDto Requisite { get; set; }

        [JsonIgnore]
        public Guid? StatementId { get; set; }

        public Uri LastStatementLink { get; set; }
    }
}