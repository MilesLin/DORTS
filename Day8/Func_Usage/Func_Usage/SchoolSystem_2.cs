using System.Collections.Generic;
using System.Linq;
namespace Func_Usage
{
    public class SchoolSystem_2
    {
        public List<Student> GetPassedStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Bob", Score = 79 },
                new Student { Id = 2, Name = "Kevin", Score = 59 },
                new Student { Id = 3, Name = "Mary", Score = 40 },
                new Student { Id = 4, Name = "Mike", Score = 91 },
                new Student { Id = 5, Name = "John", Score = 80 }
            };

            //students.Where
            var result = FilterStudent(students);

            return result;
        }

        private List<Student> FilterStudent(List<Student> students)
        {
            List<Student> result = new List<Student>();

            foreach (var item in students)
            {
                if (item.Score >= 60)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}