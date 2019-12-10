using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace String_Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee
            {
                Id = 1,
                Name = "  Bob      ",
                Position = " Manager    ",
                Department = " IT                      ",
                EmployedDate = DateTime.Now
            };

            TrimString(emp);

            string result = JsonConvert.SerializeObject(emp);
            Console.WriteLine(result);

        }

        private static void TrimString(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properites = type.GetProperties();

            foreach (PropertyInfo property in properites)
            {
                if (property.PropertyType == typeof(string))
                {
                    object value = property.GetValue(obj);

                    WhetherTrimAttribute attr = property.GetCustomAttribute<WhetherTrimAttribute>();
                    if (attr != null)
                    {
                        if (attr.IsTrim)
                        {
                            var newValue = property.GetValue(obj).ToString().Trim();
                            property.SetValue(obj, newValue);
                        }
                    }
                    else
                    {
                        var newValue = property.GetValue(obj).ToString().Trim();
                        property.SetValue(obj, newValue);
                    }
                }
            }
        }
    }
}
