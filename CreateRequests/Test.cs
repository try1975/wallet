using System;
using System.Diagnostics;
using CreateRequests.Data;
using EPM.Wallet.Common.Enums;

namespace CreateRequests
{
    public static class Test
    {
        public static async void Execute()
        {
            var dataManager = new DataMаnager();
            var isRepeate = true;
            while (isRepeate)
            {
                var dtos = await dataManager.GetStandingOrders();
                foreach (var dto in dtos)
                {
                    isRepeate = false;
                    if (dto.LastDate.HasValue && dto.LastDate.Value.Date > DateTime.UtcNow.Date) continue;
                    if (dto.StandingOrderStatus != StandingOrderStatus.Active) continue;
                    var nextRequestDate = dto.NextRequestDate?.Date ?? dto.FirstDate.Date;
                    if (nextRequestDate.Date > DateTime.UtcNow.Date.AddDays(1)) continue;
                    var line = $"{dto.Id} {nextRequestDate.Date}";
                    Console.WriteLine(line);
                    Debug.WriteLine(line);
                    // отправить запрос на создание реквеста
                    var result = dataManager.CreateRequest(dto.Id).Result;
                    if (result.Equals(Guid.Empty)) continue;
                    isRepeate = true;
                    break;
                }
            }
        }
    }
}