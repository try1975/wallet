using System;
using System.Diagnostics;
using System.Linq;
using CreateRequests.Data;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;

namespace CreateRequests
{
    public static class CheckStandingOrders
    {
        public static async void Execute()
        {
            var dataManager = new DataMаnager();
            var isRepeate = true;
            while (isRepeate)
            {
                isRepeate = false;
                var dtos = await dataManager.GetStandingOrders();
                var standingOrderDtos = dtos as StandingOrderDto[] ?? dtos.ToArray();
                Console.WriteLine($"Standing orders count: {standingOrderDtos.Count()}");
                foreach (var dto in standingOrderDtos)
                {
                    if (dto.IsInactive)
                    {
                        Console.WriteLine("Skip by IsInactive...");
                        continue;
                    }
                    if (dto.LastDate.HasValue && dto.LastDate.Value.Date > DateTime.UtcNow.Date)
                    {
                        Console.WriteLine("Skip by LastDate...");
                        continue;
                    }
                    var nextRequestDate = dto.NextRequestDate?.Date ?? dto.FirstDate.Date;
                    if (nextRequestDate.Date > DateTime.UtcNow.Date.AddDays(1))
                    {
                        Console.WriteLine($"Skip by NextDate {nextRequestDate.Date}...");
                        continue;
                    }
                    // отправить запрос на создание реквеста
                    Console.WriteLine($"Create request {nextRequestDate.Date}...");
                    var result = dataManager.CreateRequest(dto.Id).Result;
                    if (result.Equals(Guid.Empty)) continue;
                    isRepeate = true;
                    break;
                }
            }
            #if DEBUG
            Console.WriteLine($"{nameof(Execute)} completed. Press any key.");
            #endif
        }
    }
}