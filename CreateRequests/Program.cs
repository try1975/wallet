using System;

namespace CreateRequests
{
    internal static class Program
    {
        private static void Main()
        {
            CheckStandingOrders.Execute();
            
            #if DEBUG
            Console.ReadKey();
            #endif
        }
    }
}