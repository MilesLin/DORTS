using System;
using System.Threading;
using System.Threading.Tasks;

namespace Learn_async_await
{
    internal class Calculator
    {
        public async Task<int> GetSumAsync(int a, int b)
        {
            Console.WriteLine("步驟 2 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            int result = await Task.Run(() =>
            {
                Console.WriteLine("步驟 3 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
                return a + b;
            });

            Console.WriteLine("步驟 4 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            return result;
        }
    }
}