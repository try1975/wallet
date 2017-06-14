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

        public IEnumerable<StandingOrderDto> GetStandingOrdersByClient(string clientId)
        {
            var list = Query.GetEntities()
                .Where(m => m.ClientAccount.ClientId == clientId)
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
                ;
            return Mapper.Map<List<StandingOrderDto>>(list);
        }

        public Guid CreateRequestByStandingOrder(Guid id)
        {
            var standingOrder = Query.GetEntities()
                .Include(z => z.ClientAccount.Client)
                .FirstOrDefault(z => z.Id.Equals(id))
                ;
            if (standingOrder == null) return Guid.Empty;
            standingOrder.LastRequestDate = DateTime.UtcNow.Date.AddDays(1);
            switch (standingOrder.Frequency)
            {
                case Frequency.Weekly:
                    standingOrder.NextRequestDate = standingOrder.LastRequestDate.Value.Date.AddDays(7);
                    break;
                case Frequency.Monthly:
                    standingOrder.NextRequestDate = standingOrder.LastRequestDate.Value.Date.AddMonths(1);
                    break;
                case Frequency.Every4Weeks:
                    standingOrder.NextRequestDate = standingOrder.LastRequestDate.Value.Date.AddDays(28);
                    break;
                case Frequency.Every2Month:
                    standingOrder.NextRequestDate = standingOrder.LastRequestDate.Value.Date.AddMonths(2);
                    break;
                case Frequency.Quarterly:
                    standingOrder.NextRequestDate = standingOrder.LastRequestDate.Value.Date.AddMonths(3);
                    break;
                case Frequency.HalfYearly:
                    standingOrder.NextRequestDate = standingOrder.LastRequestDate.Value.Date.AddMonths(6);
                    break;
                case Frequency.Annually:
                    standingOrder.NextRequestDate = standingOrder.LastRequestDate.Value.Date.AddYears(1);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            var request = _accountRequestQuery.GetEntities()
                .FirstOrDefault(z=>z.StandingOrderId==standingOrder.Id && z.ValueDate==standingOrder.LastRequestDate)
                ;
            if(request!=null) return Guid.Empty;

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
                        ValueDate = standingOrder.LastRequestDate,
                        Note = standingOrder.Note
                    };
                    Query.GetDbContext().Set<AccountRequestEntity>().Add(transferOut);
                    Query.GetDbContext().SaveChanges();
                    dbContextTransaction.Commit();
                    return transferOut.Id;
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    Debug.WriteLine(e);
                    Log.Error(e);
                    return Guid.Empty;
                }
            }
        }
    }
}