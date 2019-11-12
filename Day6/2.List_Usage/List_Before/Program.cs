using System;
using System.Collections.Generic;

namespace List_Before
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> values = GetData();

            /*     移除 Id = 5 的資料  */

            /*     新增  new Employee() { Id = 6, Name "Amy" } 到第三個位置    */

            /*     將 Cam 改成 Cam Lin    */

            /*     排序，將編號(Id)較大的先列印    */

            foreach (var item in values)
            {
                // 列印出
                // 6: Mary
                // 4: Cam Lin
                // 3: Mary
                // 2: Dennis
                // 1: Bob
                Console.WriteLine($"{item.Id}: {item.Name}");
            }
        }

        private static List<Employee> GetData()
        {
            var values = new List<Employee>();
            values.Add(new Employee { Id = 1, Name = "Bob" });
            values.Add(new Employee { Id = 5, Name = "Kevin" });
            values.Add(new Employee { Id = 3, Name = "Mary" });
            values.Add(new Employee { Id = 4, Name = "Cam" });
            values.Add(new Employee { Id = 2, Name = "Dennis" });
            return values;
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}