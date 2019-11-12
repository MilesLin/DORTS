using System;
using System.Collections.Generic;

namespace Dictionary_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new Dictionary<int, string>();
            values.Add(5, "Mike");
            values.Add(3, "Bob");
            values.Add(1, "Kevin");
            values.Add(4, "Cam");
            values.Add(2, "Mary");

            /*     移除 Key = 5 的資料    */
            values.Remove(3);

            /*     將 Cam 改成 Cam Lin    */
            values[4] = "Cam Lin";

            foreach (var item in values)
            {
                // 列印出
                // 5: Mike
                // 1: Kevin
                // 4: Cam Lin
                // 2: Mary
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Sex Sex{ get; set; }
    }

    public enum Sex
    {
        男,
        女
    }
}
