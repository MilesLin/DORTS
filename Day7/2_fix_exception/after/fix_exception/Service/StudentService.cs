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
        private static Dictionary<string, Student> _student = new Dictionary<string, Student>
        {
            { "abc@abc.com", new Student{ Email = "abc@abc.com", Name = "Bob", Major = Major.機械 } },
            { "def@abc.com", new Student{ Email = "def@abc.com", Name = "Kevin", Major = Major.資訊工程 } },
            { "qwe@abc.com", new Student{ Email = "qwe@abc.com", Name = "Mary", Major = Major.經濟 } }
        };

        public void Add(Student student)
        {
            _student.Add(student.Email, student);
        }

        public bool IsExist(string email)
        {
            return _student.TryGetValue(email, out Student _);
        }

        public Dictionary<string, Student> GetAll()
        {
            return _student;
        }
    }
}
