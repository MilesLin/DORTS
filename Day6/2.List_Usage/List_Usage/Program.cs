using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace List_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string>();
            values.Add("Mike");
            values.Add("Bob");
            values.Add("Kevin");
            values.Add("Cam");
            values.Add("Mary");

            /*     移除 Kevin    */
            values.Remove("Kevin");
            //values.RemoveAt(2);

            /*     新增 Amy 到第三個位置    */
            values.Insert(2, "Amy");

            /*     將 Cam 改成 Cam Lin    */
            int camIndex = values.IndexOf("Cam");
            values[camIndex] = "Cam Lin";

            foreach (var item in values)
            {
                // 列印出
                // Mike
                // Bob
                // Amy
                // Cam Lin
                // Mary
                Console.WriteLine(item);
            }

        }
    }
}
