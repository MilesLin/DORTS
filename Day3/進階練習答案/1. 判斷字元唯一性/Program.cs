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
            while (true)
            {
                char[] memo = new char[128];
                Console.WriteLine("請輸入字串: ");
                string value = Console.ReadLine();

                int index = 0;
                bool isDuplicated = false;
                foreach (char item in value)
                {
                    if (Array.IndexOf(memo, item) > -1)
                    {
                        Console.WriteLine($"{item} 為重複字元 {Environment.NewLine}");
                        isDuplicated = true;
                        break;
                    }
                    else
                    {
                        memo.SetValue(item, index);
                        index++;
                    }
                }

                if (!isDuplicated)
                {
                    Console.WriteLine($"{value} 無重複字元 {Environment.NewLine}");
                }
            }

        }
    }
}
