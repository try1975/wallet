using System;

namespace CreateRequests
{
    internal static class Program
    {
        private static void Main()
        {
            Test.Execute();
            
            #if DEBUG
            Console.ReadKey();
            #endif
        }
    }
}