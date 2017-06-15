using System;

namespace CreateRequests
{
    internal static class Program
    {
        private static void Main()
        {
            Test.Execute();
            
            #if DEBUG
            Console.WriteLine("Execute completed. Press any key.");
            Console.ReadKey();
            #endif
        }
    }
}