using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x != 0)
            {
                Console.WriteLine($"while do {x}");
                break;
            }

            int y = 0;
            do
            {
                Console.WriteLine($"do while {y}");
                break;
            } while (y != 0);
        }
    }
}