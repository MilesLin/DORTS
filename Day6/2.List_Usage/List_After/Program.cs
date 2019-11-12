using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_After
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> values = GetData();

            /*     移除 Id = 5 的資料  */
            Employee removedEmp = null;
            foreach (var item in values)
            {
                if (item.Id == 5)
                {
                    removedEmp = item;
                }
            }
            values.Remove(removedEmp);
            //values.RemoveAll(x => x.Id == 5);

            /*     新增  new Employee() { Id = 6, Name "Amy" } 到第三個位置    */
            values.Insert(2, new Employee() { Id = 6, Name = "Amy" });

            /*     將 Cam 改成 Cam Lin    */
            foreach (var item in values)
            {
                if (item.Name == "Cam")
                {
                    item.Name = "Cam Lin";
                }
            }

            /*     將編號(Id)較大的先列印    */
            values.Sort(new Employee());
            values.Reverse();

            foreach (var item in values)
            {
                // 列印出
                // 6: Amy
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

    public class Employee : IComparer<Employee>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Compare(Employee x, Employee y)
        {
            int firstId = x.Id;
            int secondId = y.Id;

            if (firstId < secondId)
            {
                return -1;
            }
            else if (firstId > secondId)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
