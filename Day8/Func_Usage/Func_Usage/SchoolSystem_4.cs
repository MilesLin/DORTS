using System;
using System.Collections.Generic;
using System.Linq;
namespace Func_Usage
{
    public class SchoolSystem_4
    {
        public void Go()
        {
            List<Student> allStudents = GetStudents();
            List<Employee> allEmployees = GetEmployee();

            var result1 = Filter<Student>(allStudents, (x) => { 
                return x.Score >= 60;
            });

            var result2 = Filter<Student>(allStudents, (x) => {
                return x.Name == "Bob";
            });

            var result3 = Filter<Employee>(allEmployees, (x) => {
                return x.Name == "Kevin";
            });
        }

        private T Filter<T>(List<T> values, Func<T, bool> filter)
        {
            foreach (T item in values)
            {
                if (filter(item))
                {
                    return item;
                }
            }

            return default(T);
        }


        private List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Bob"},
                new Employee { Id = 2, Name = "Kevin"},
                new Employee { Id = 3, Name = "Mary"}
            };
        }

        private List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Bob", Score = 79 },
                new Student { Id = 2, Name = "Kevin", Score = 59 },
                new Student { Id = 3, Name = "Mary", Score = 40 },
                new Student { Id = 4, Name = "Mike", Score = 91 },
                new Student { Id = 5, Name = "John", Score = 80 }
            };
        }
    }
}