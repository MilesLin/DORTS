using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing
            int value = 99;
            object obj = value;

            Console.WriteLine(obj);

            // unboxing
            int value2 = (int)obj;
            Console.WriteLine(value2);

            // ArrayList
            ArrayList al = new ArrayList();
            al.Add(3); // boxing
            al.Add(2);
            al.Add(1);
            al.Add(4);
            al.Add(5);
            
            foreach (var item in al)
            {
                int val = (int)item; // unboxing
                Console.WriteLine(val);
            }
        }
    }
}
