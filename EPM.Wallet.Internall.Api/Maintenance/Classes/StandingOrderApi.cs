using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{

    public class StandingOrderApi : TypedApi<StandingOrderDto, StandingOrderEntity, Guid>, IStandingOrderApi
    {
        private readonly IAccountRequestQuery _accountRequestQuery;

        public StandingOrderApi(IStandingOrderQuery query, IAccountRequestQuery accountRequestQuery) : base(query)
        {
            _accountRequestQuery = accountRequestQuery;
        }

        public override IEnumerable<StandingOrderDto> GetItems()
        {
            return Query.GetEntities()
                .Include(z => z.ClientAccount.Client)
                .Include(z => z.Requisite)
                .Select(z => new StandingOrderDto()
                {
                    Id = z.Id,
                    ClientAccountId = z.ClientAccountId,
                    Amount = z.Amount,
                    CurrencyId = z.CurrencyId,
                    FirstDate = z.FirstDate,
                    LastDate = z.LastDate,
                    NextRequestDate = z.NextRequestDate,
                    Frequency = z.Frequency,
                    Note = z.Note,
                    RequisiteId = z.RequisiteId,
                    IsInactive = z.IsInactive,
                    AccountName = z.ClientAccount.Name,
                    ClientId = z.ClientAccount.ClientId,
                    ClientName = z.ClientAccount.Client.Name,
                    BankName = z.Requisite.BankName,
                    Iban = z.Requisite.Iban,
                    BankAddress = z.Requisite.BankAddress,
                    Bic = z.Requisite.Bic,
                    OwnerName = z.Requisite.OwnerName
                })
                .ToList();
        }

        public IEnumerable<StandingOrderDto> GetStandingOrdersByClient(string clientId)
        {
            var list = Query.GetEntities()
                .Where(m => m.ClientAccount.ClientId == clientId)
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
                ;
            return Mapper.Map<List<StandingOrderDto>>(list);
        }

        public AccountRequestDto CreateRequestByStandingOrder(Guid id)
        {
            var standingOrder = Query.GetEntities()
                .Include(z => z.ClientAccount.Client)
                .FirstOrDefault(z => z.Id.Equals(id) && !z.IsInactive)
                ;
            if (standingOrder == null) return null;

            if (standingOrder.LastDate.HasValue && standingOrder.LastDate.Value.Date <= DateTime.UtcNow.Date) return null;
            if (!standingOrder.NextRequestDate.HasValue) standingOrder.NextRequestDate = standingOrder.FirstDate.Date;
            if (!(standingOrder.NextRequestDate.Value.Date <= DateTime.UtcNow.Date.AddDays(1))) return null;
            var valueDate = standingOrder.NextRequestDate.Value.Date;

            switch (standingOrder.Frequency)
            {
                case Frequency.Weekly:
                    standingOrder.NextRequestDate = standingOrder.NextRequestDate.Value.Date.AddDays(7);
                    break;
                case Frequency.Monthly:
                    standingOrder.NextRequestDate = standingOrder.NextRequestDate.Value.Date.AddMonths(1);
                    break;
                case Frequency.Every4Weeks:
                    standingOrder.NextRequestDate = standingOrder.NextRequestDate.Value.Date.AddDays(28);
                    break;
                case Frequency.Every2Month:
                    standingOrder.NextRequestDate = standingOrder.NextRequestDate.Value.Date.AddMonths(2);
                    break;
                case Frequency.Quarterly:
                    standingOrder.NextRequestDate = standingOrder.NextRequestDate.Value.Date.AddMonths(3);
                    break;
                case Frequency.HalfYearly:
                    standingOrder.NextRequestDate = standingOrder.NextRequestDate.Value.Date.AddMonths(6);
                    break;
                case Frequency.Annually:
                    standingOrder.NextRequestDate = standingOrder.NextRequestDate.Value.Date.AddYears(1);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var request = _accountRequestQuery.GetEntities()
                .FirstOrDefault(z => z.StandingOrderId == standingOrder.Id && z.ValueDate == valueDate)
                ;
            if (request != null) return null;

            using (var dbContextTransaction = Query.GetDbContext().Database.BeginTransaction(IsolationLevel.RepeatableRead))
            {
                try
                {
                    Query.GetDbContext().Set<StandingOrderEntity>().AddOrUpdate(standingOrder);
                    var transferOut = new AccountRequestEntity()
                    {
                        ClientId = standingOrder.ClientAccount.ClientId,
                        RequestType = RequestType.Payment,
                        RequestStatus = RequestStatus.Pending,
                        AccountRequestType = AccountRequestType.TransferOut,
                        RequisiteId = standingOrder.RequisiteId,
                        StandingOrderId = standingOrder.Id,
                        ClientAccountId = standingOrder.ClientAccountId,
                        CurrencyId = standingOrder.CurrencyId,
                        AmountOut = standingOrder.Amount,
                        ValueDate = valueDate,
                        Note = standingOrder.Note
                    };
                    if (transferOut.ValueDate != null && transferOut.ValueDate.Value.Date < DateTime.UtcNow.Date)
                    {
                        transferOut.RequestStatus = RequestStatus.Rejected;
                        transferOut.Note = @"The request is rejected because the value date is in the past";
                    }
                    Query.GetDbContext().Set<AccountRequestEntity>().Add(transferOut);
                    Query.GetDbContext().SaveChanges();
                    dbContextTransaction.Commit();
                    return Mapper.Map<AccountRequestDto>(transferOut);
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    Debug.WriteLine(e);
                    Log.Error(e);
                    return null;
                }
            }
        }
    }
}