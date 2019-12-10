using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Trim
{
    public class Employee
    {
        public int Id { get; set; }

        [WhetherTrim(false)]
        public string Name { get; set; }

        //[JsonIgnore]
        [WhetherTrim(true)]
        public string Position { get; set; }

        public string Department { get; set; }

        public DateTime EmployedDate { get; set; }
    }
}
