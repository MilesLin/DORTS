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

            Console.WriteLine("步驟 1 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            Task<int> sum = cal.GetSumAsync(1, 10);
            Console.WriteLine("步驟 5 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("結果:" + sum.Result);
            Console.WriteLine("步驟 6 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            Console.Read();

        }
    }
}
