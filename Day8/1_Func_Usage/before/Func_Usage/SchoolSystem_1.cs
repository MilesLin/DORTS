using System;
using System.Collections.Generic;
using System.Linq;
namespace Func_Usage
{
    public class SchoolSystem_1
    {
        public Student GetFirstPassedStudents()
        {
            List<Student> allStudents = GetData();

            // 把方法寫成變數
            Func<List<Student>, Student> filterStudent = null;

            Student result = filterStudent(allStudents);

            return result;
        }

        private List<Student> GetData()
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