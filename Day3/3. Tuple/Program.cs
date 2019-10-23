using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string> tupleValue = TupleSample();
            Console.WriteLine(tupleValue.Item1);
            Console.WriteLine(tupleValue.Item2);

            (int v1, string v2) = NewTupleSample();
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }

        private static Tuple<int, string> TupleSample()
        {
            return Tuple.Create(10, "tuple string");
        }

        private static (int v1, string v2) NewTupleSample()
        {
            return (10, "new tuple string");
        }
    }
}