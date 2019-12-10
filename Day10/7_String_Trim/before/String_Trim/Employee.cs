﻿using Newtonsoft.Json;
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

        public string Name { get; set; }

        [JsonIgnore]
        public string Position { get; set; }
    }
}
