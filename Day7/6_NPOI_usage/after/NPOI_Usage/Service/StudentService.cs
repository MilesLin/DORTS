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
        private static List<Student> _student = new List<Student>
        {
            {new Student{ Email = "abc@abc.com", Name = "Bob", Major = Major.機械 } },
            {new Student{ Email = "def@abc.com", Name = "Kevin", Major = Major.資訊工程 } },
            {new Student{ Email = "qwe@abc.com", Name = "Mary", Major = Major.經濟 } }
        };

        public List<Student> GetAll()
        {
            return _student;
        }
    }
}
