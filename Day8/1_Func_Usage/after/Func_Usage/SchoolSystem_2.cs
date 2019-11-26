using System;
using System.Collections.Generic;
using System.Linq;
namespace Func_Usage
{
    public class SchoolSystem_2
    {
        public void Go()
        {
            // 各種不同的 Filter
            List<Student> allStudents = GetStudents();
            List<Employee> allEmployees = GetEmployee();

            var result1 = FilterStudentScore(allStudents);
            var result2 = FilterStudentName(allStudents);
            var result3 = FilterEmployeeName(allEmployees);

        }

        private Student FilterStudentScore(List<Student> students)
        {
            foreach (Student item in students)
            {
                if (item.Score >= 60)
                {
                    return item;
                }
            }

            return null;
        }

        private Student FilterStudentName(List<Student> students)
        {
            foreach (Student item in students)
            {
                if (item.Name == "Bob")
                {
                    return item;
                }
            }

            return null;
        }

        private Employee FilterEmployeeName(List<Employee> employees)
        {
            foreach (Employee item in employees)
            {
                if (item.Name == "Kevin")
                {
                    return item;
                }
            }

            return null;
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