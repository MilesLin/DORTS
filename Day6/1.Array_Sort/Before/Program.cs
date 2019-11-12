using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
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

            // 排序 Employee ， Id 小的先列印

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
