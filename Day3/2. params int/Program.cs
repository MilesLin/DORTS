using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int result = Add(1, 2, 3, 4, 5, 6, 7, 99);
            Console.WriteLine(result);
        }

        private static int Add(params int[] arg)
        {
            int result = 0;
            foreach (var item in arg)
            {
                result += item;
            }

            return result;
        }
    }
}