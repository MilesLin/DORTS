using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PLINQ_PRACTICE
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();

            watch.Start();

            var numbers = Enumerable.Range(1, 10).ToList();

            // 請加入 PLINQ 的語法
            var data = numbers.Select(x =>
            {
                // Do Something ....
                Thread.Sleep(200);
                return Math.Sqrt(x);
            });

            foreach (var item in data)
            {
                Console.WriteLine($"Result: {item}");
            }

            watch.Stop();

            Console.WriteLine("Consume Time: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
