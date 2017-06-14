using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class DirectDebitApi : TypedApi<DirectDebitDto, DirectDebitEntity, Guid>, IDirectDebitApi
    {
        public DirectDebitApi(IDirectDebitQuery query) : base(query)
        {
        }

        public override IEnumerable<DirectDebitDto> GetItems()
        {
            var directDebits = Query.GetEntities()
                .Include(nameof(DirectDebitEntity.SourceAccount))
                .Include(nameof(DirectDebitEntity.Card))
                ;

            var list = directDebits.Select(z => new DirectDebitDto()
            {
                Id = z.Id,
                SourceAccountId = z.SourceAccountId,
                SourceAccountName = z.SourceAccount.Name,
                CardId = z.CardId,
                CardNumber = z.Card.CardNumber,
                CurrencyId = z.CurrencyId,
                DebitFromOtherIfIncefitient = z.DebitFromOtherIfIncefitient
            }).ToList();
            return list;
        }
    }
}