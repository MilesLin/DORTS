using System;

namespace int_try
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string value = "a";
            try
            {
                var a = int.Parse(value);
                Console.WriteLine(a);
            }
            catch (FormatException e) when (e.Message.Contains("Input"))
            {
                Console.WriteLine("Format\n" + e.Message);
            }
            catch (Exception e)
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