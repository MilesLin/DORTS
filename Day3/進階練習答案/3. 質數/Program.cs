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
            for (int i = 2; i < 101; i++)
            {
                if (PrimeNaive(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        private static bool PrimeNaive(int n)
        {
            if (n < 2)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
