using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{

    public class StandingOrderApi : TypedApi<StandingOrderDto, StandingOrderEntity, Guid>, IStandingOrderApi
    {
        private readonly IRequisiteQuery _requisiteQuery;
        private readonly IAccountQuery _accountQuery;

        public StandingOrderApi(IStandingOrderQuery query, IRequisiteQuery requisiteQuery, IAccountQuery accountQuery) : base(query)
        {
            _requisiteQuery =  requisiteQuery;
            _accountQuery = accountQuery;
        }

        public IEnumerable<StandingOrderInfoDto> GetStandingOrdersByClient(string clientId)
        {
            var standingOrders = _query.GetEntities()
                .Where(m => m.ClientAccount.ClientId==clientId)
                ;
            
            var list = standingOrders.Join(_requisiteQuery.GetEntities(), o => o.RequisiteId, i => i.Id
                , (o, i) => new StandingOrderInfoDto()
                {
                    Id = o.Id,
                    Name = o.Name,
                    AccountId = o.ClientAccountId,
                    AccountName = o.ClientAccount.Name,
                    Amount = o.Amount,
                    CurrencyId = o.CurrencyId,
                    FirstDate = o.FirstDate,
                    LastDate = o.LastDate,
                    Frequency = o.Frequency,
                    Note = o.Note,
                    // Requisites
                    RequisiteId = o.RequisiteId,
                    BankName = i.BankName,
                    Iban = i.Iban,
                    BankAddress = i.BankAddress,
                    Bic = i.Bic,
                    OwnerName = i.OwnerName
                }
                )
                .OrderByDescending(r => r.Name)
                .ToList();
            return list;
        }

        public StandingOrderInfoDto PostStandingOrderByClient(string clientId, StandingOrderDto dto)
        {
            var account = _accountQuery.GetEntities().FirstOrDefault(z=>z.Id==dto.ClientAccountId && z.ClientId==clientId);
            if (account == null) return null;
            var requisite = _requisiteQuery.GetEntities().FirstOrDefault(z=>z.Id==dto.RequisiteId && z.ClientId==clientId);
            if (requisite == null) return null;
            var entity = Mapper.Map<StandingOrderEntity>(dto);
            entity = _query.InsertEntity(entity);
            var standingOrderInfoDto = Mapper.Map<StandingOrderInfoDto>(entity);
            standingOrderInfoDto.AccountId = account.Id;
            standingOrderInfoDto.AccountName = account.Name;
            standingOrderInfoDto.BankName = requisite.BankName;
            standingOrderInfoDto.Iban = requisite.Iban;
            standingOrderInfoDto.BankAddress = requisite.BankAddress;
            standingOrderInfoDto.Bic = requisite.Bic;
            standingOrderInfoDto.OwnerName = requisite.OwnerName;
            return standingOrderInfoDto;
        }

        public StandingOrderInfoDto PutStandingOrderByClient(string clientId, StandingOrderDto dto)
        {
            var account = _accountQuery.GetEntities().FirstOrDefault(z => z.Id == dto.ClientAccountId && z.ClientId == clientId);
            if (account == null) return null;
            var requisite = _requisiteQuery.GetEntities().FirstOrDefault(z => z.Id == dto.RequisiteId && z.ClientId == clientId);
            if (requisite == null) return null;
            var entity = Mapper.Map<StandingOrderEntity>(dto);
            entity = _query.UpdateEntity(entity);
            var standingOrderInfoDto = Mapper.Map<StandingOrderInfoDto>(entity);
            standingOrderInfoDto.AccountId = account.Id;
            standingOrderInfoDto.AccountName = account.Name;
            standingOrderInfoDto.BankName = requisite.BankName;
            standingOrderInfoDto.Iban = requisite.Iban;
            standingOrderInfoDto.BankAddress = requisite.BankAddress;
            standingOrderInfoDto.Bic = requisite.Bic;
            standingOrderInfoDto.OwnerName = requisite.OwnerName;
            return standingOrderInfoDto;
        }

        public bool DeleteStandingOrderByClient(string clientId, Guid id)
        {
            var entity = _query.GetEntities().FirstOrDefault(z => z.Id.Equals(id) && z.ClientAccount.ClientId.Equals(clientId));
            return entity != null && _query.DeleteEntity(id);
        }
    }
}