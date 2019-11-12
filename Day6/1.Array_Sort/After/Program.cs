using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
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

            Array.Sort(employees, new Employee());

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }
        }
    }

    public class Employee: IComparer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Compare(object x, object y)
        {
            int firstId = ((Employee)x).Id;
            int secondId = ((Employee)y).Id;

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
