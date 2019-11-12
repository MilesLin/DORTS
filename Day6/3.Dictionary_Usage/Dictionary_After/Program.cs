using System;
using System.Collections.Generic;

namespace Dictionary_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> values = GetData();

            /*     新增  new Employee() { Id = 6, Name "Amy", Sex = Sex.女 } 資料 */
            values.Add(6, new Employee() { Id = 6, Name = "Amy", Sex = Sex.女 });

            /*     移除 Key = 5 的資料  */
            values.Remove(5);

            /*     將 Cam 改成 Cam Lin    */
            values[4].Name = "Cam LIn";

            foreach (var item in values)
            {
                // 列印出
                // 1: Bob
                // 3: Mary
                // 4: Cam LIn
                // 2: Dennis
                // 6: Amy
                Console.WriteLine($"{item.Key}: {item.Value.Name}");
            }
        }

        private static Dictionary<int, Employee> GetData()
        {
            var values = new Dictionary<int, Employee>();
            values.Add(1, new Employee { Id = 1, Name = "Bob", Sex = Sex.男 });
            values.Add(5, new Employee { Id = 5, Name = "Kevin", Sex = Sex.男 });
            values.Add(3, new Employee { Id = 3, Name = "Mary", Sex = Sex.女 });
            values.Add(4, new Employee { Id = 4, Name = "Cam", Sex = Sex.男 });
            values.Add(2, new Employee { Id = 2, Name = "Dennis", Sex = Sex.男 });
            return values;
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Sex Sex { get; set; }
    }

    public enum Sex
    {
        男,
        女
    }
}
