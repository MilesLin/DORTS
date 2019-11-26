﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Func_Usage
{
    public class SchoolSystem_3
    {
        public void Go()
        {
            // 用 Func 減少方法
            List<Student> allStudents = GetStudents();
            List<Employee> allEmployees = GetEmployee();

            var result1 = FilterStudent(allStudents, (x) => { 
                return x.Score >= 60;
            });

            var result2 = FilterStudent(allStudents, (x) => {
                return x.Name == "Bob";
            });

            var result3 = FilterEmployee(allEmployees, (x) => {
                return x.Name == "Kevin";
            });

        }

        private Student FilterStudent(List<Student> students, Func<Student, bool> filter)
        {
            foreach (Student item in students)
            {
                if (filter(item))
                {
                    return item;
                }
            }

            return null;
        }
        
        private Employee FilterEmployee(List<Employee> employees, Func<Employee, bool> filter)
        {
            foreach (Employee item in employees)
            {
                if (filter(item))
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