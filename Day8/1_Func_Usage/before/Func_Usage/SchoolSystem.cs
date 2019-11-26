using System.Collections.Generic;

namespace Func_Usage
{
    public class SchoolSystem
    {
        public Student GetFirstPassedStudents()
        {
            List<Student> allStudents = GetData();

            Student result = this.FilterStudent(allStudents);

            return result;
        }

        private Student FilterStudent(List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Score >= 60)
                {
                    return item;
                }
            }

            return null;
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