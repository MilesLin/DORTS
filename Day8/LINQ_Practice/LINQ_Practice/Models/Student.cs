using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice.Models
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Degree Degree { get; set; }
        public List<Course> Course { get; set; }
    }

    public enum Degree
    {
        一年級,
        二年級,
        三年級
    }
}
