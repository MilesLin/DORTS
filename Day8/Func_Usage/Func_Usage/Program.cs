using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Usage
{
    class Program
    {
        static void Main(string[] args)
        {

            var school = new SchoolSystem();
            List<Student> result = school.GetPassedStudents();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}: {item.Score}");
            }

        }
    }
}
