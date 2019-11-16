using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_try
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "0";

            try
            {
                //var a = int.Parse(value);
                var a = float.Parse(value);
                Console.WriteLine(a);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format\n" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception\n" + e.Message);                
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
