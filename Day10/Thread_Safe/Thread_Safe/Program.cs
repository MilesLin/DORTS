using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Safe
{
    class Program
    {
        private static object lockObj = new object();
        
        static void Main(string[] args)
        {
            int counter = 0;

            var t1 = Task.Run(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    lock (lockObj)
                    {
                        counter++;
                    }
                }
            });

            var t2 = Task.Run(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    lock (lockObj)
                    {
                        counter++;
                    }
                }
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine($"結果是: {counter}");
        }
    }
}
