using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace String_Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee
            {
                Id = 1,
                Name = "  Bob      ",
                Position = " Manager    ",
                Department = " IT                      ",
                EmployedDate = DateTime.Now
            };

            string result = JsonConvert.SerializeObject(emp);
            Console.WriteLine(result);

        }        
    }
}
