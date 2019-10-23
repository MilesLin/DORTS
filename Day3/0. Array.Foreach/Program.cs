using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 1, 2, 3 };
            Action<int> action = new Action<int>(Method);
            Array.ForEach(v, action);
        }

        private static void Method(int v)
        {
            Console.WriteLine(v);
        }
    }
}