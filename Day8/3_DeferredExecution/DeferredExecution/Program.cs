using System;
using System.Collections.Generic;
using System.Linq;

namespace DeferredExecution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Bob Lee", Score = 79 },
                new Student { Id = 2, Name = "Kevin Wu", Score = 59 },
            };

            var filterResult = students.Where(x => x.Score > 60);

            students.Add(new Student { Id = 3, Name = "Mary Yan", Score = 80 });

            foreach (var item in filterResult)
            {
                Console.WriteLine($"{item.Name}: {item.Score}");
            }
        }
    }
}