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
            Student result = school.GetFirstPassedStudents();
            Console.WriteLine($"{result.Name}: {result.Score}");
        }
    }
}
