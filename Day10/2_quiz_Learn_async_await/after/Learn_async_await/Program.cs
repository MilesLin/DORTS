using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learn_async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            Console.WriteLine($"步驟 {1} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            // 相加
            Task<int> sum = cal.GetSumAsync(1, 10);

            Console.WriteLine($"步驟 {3} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            // 相減
            Task<int> sub = cal.GetSubAsync(5, 3);

            Console.WriteLine($"步驟 {5} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            int sumResult = sum.Result;

            Console.WriteLine($"步驟 {8} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);

            int subResult = sub.Result;


            Console.WriteLine($"步驟 {11} => ThreadID : " + Thread.CurrentThread.ManagedThreadId);



            Console.WriteLine("結果:" + sumResult * subResult);

            Console.Read();

        }
    }
}
