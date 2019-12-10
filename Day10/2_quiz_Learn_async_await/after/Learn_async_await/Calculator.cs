using System;
using System.Threading;
using System.Threading.Tasks;

namespace Learn_async_await
{
    internal class Calculator
    {
        public async Task<int> GetSumAsync(int a, int b)
        {
            Console.WriteLine($"步驟 {2} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            int result = await Task.Run(() =>
            {
                Thread.Sleep(100);
                Console.WriteLine($"步驟 {6} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
                return a + b;
            });

            Console.WriteLine($"步驟 {7} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            return result;
        }

        public async Task<int> GetSubAsync(int a, int b)
        {
            Console.WriteLine($"步驟 {4} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            int result = await Task.Run(() =>
            {
                Thread.Sleep(100);
                Console.WriteLine($"步驟 {9} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
                return a - b;
            });

            Console.WriteLine($"步驟 {10} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            return result;
        }
    }
}