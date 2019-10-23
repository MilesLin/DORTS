using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CountWays(10);

            Console.WriteLine(result);
        }

        private static int CountWays(int stages)
        {
            if (stages < 0)
            {
                return 0;
            }
            else if (stages == 0)
            {
                return 1;
            }
            else
            {
                return CountWays(stages - 1) + CountWays(stages - 2) + CountWays(stages - 3);
            }
        }
    }
}
