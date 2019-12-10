using System;
using System.Threading;
using System.Threading.Tasks;

namespace Learn_async_await
{
    internal class Calculator
    {
        public int GetSumAsync(int a, int b)
        {
            Console.WriteLine("步驟 2 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            return a + b;            
        }
    }
}