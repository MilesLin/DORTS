using fix_exception.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix_exception.Service
{
    public class StudentService
    {
        private static List<Student> _student = new List<Student>();

        public void Add(Student student)
        {
            _student.Add(student);
        }

        public List<Student> GetAll()
        {
            return _student;
        }
    }
}
