using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入字串: ");

                string value = Console.ReadLine();
                (string origin, string compressed) = CompressString(value);

                Console.WriteLine($"原本的字串是{origin} 壓縮後字串: {compressed} {Environment.NewLine}");
            }
        }
        
        private static (string origin, string compressed) CompressString(string value)
        {
            StringBuilder sb = new StringBuilder();
            int countConsecutive = 0;
            for (int i = 0; i < value.Length; i++)
            {
                countConsecutive++;
                if (i + 1 >= value.Length || value[i] != value[i + 1])
                {
                    sb.Append($"{value[i]}{countConsecutive}");
                    countConsecutive = 0;
                }
            }

            return (value, sb.ToString());
        }
    }
}