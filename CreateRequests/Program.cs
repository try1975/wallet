using System.Threading;

namespace CreateRequests
{
    internal static class Program
    {
        private static void Main()
        {
            CheckStandingOrders.Execute();
            Thread.Sleep(10000);
        }
    }
}