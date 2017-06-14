using System;
using CreateRequests.Data;

namespace CreateRequests
{
    public static class Test
    {
        public static async void Execute()
        {
            var dataManager = new DataMаnager();
            var dtos = await dataManager.GetStandingOrders();
            foreach (var dto in dtos)
            {
                if (dto.LastDate.HasValue && dto.LastDate.Value.Date > DateTime.UtcNow.Date) continue;
                var nextRequestDate = dto.NextRequestDate?.Date ?? dto.FirstDate;

                if (nextRequestDate <= DateTime.UtcNow.Date)
                {
                    Console.WriteLine($"{dto.Id} {nextRequestDate.Date}");
                    // отправить запрос на создание реквеста
                }
            }
        }
    }
}