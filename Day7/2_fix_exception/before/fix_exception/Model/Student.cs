using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix_exception.Model
{
    public class Student
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public Major Major { get; set; }
    }

    public enum Major
    {
        資訊工程,
        經濟,
        機械
    }
}
