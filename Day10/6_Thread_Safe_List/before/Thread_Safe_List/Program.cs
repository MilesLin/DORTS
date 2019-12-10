using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Safe_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> r = new List<string>();
            
            var t1 = Task.Run(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    r.Add(i.ToString());
                }
            });

            var t2 = Task.Run(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    r.Add(i.ToString());
                }
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine($"共有 {r.Count} 筆資料");

        }
    }
}
