using System;
using System.Threading.Tasks;

namespace Thread_Safe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int counter = 0;

            var t1 = Task.Run(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    counter++;
                }
            });

            var t2 = Task.Run(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    counter++;
                }
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine($"結果是: {counter}");
        }
    }
}