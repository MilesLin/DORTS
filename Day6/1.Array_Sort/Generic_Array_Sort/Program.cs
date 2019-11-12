using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Array_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
{
                new Employee { Id = 1, Name = "Bob" },
                new Employee { Id = 5, Name = "Kevin" },
                new Employee { Id = 3, Name = "Mary" },
                new Employee { Id = 6, Name = "Cam" },
                new Employee { Id = 4, Name = "Amy" },
                new Employee { Id = 2, Name = "Dennis" }
            };

            Array.Sort<Employee>(employees, new Employee());

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }
        }
    }

    public class Employee : IComparer<Employee>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Compare(Employee x, Employee y)
        {
            int firstId = x.Id;
            int secondId = y.Id;

            if (firstId < secondId)
            {
                return -1;
            }
            else if (firstId > secondId)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
