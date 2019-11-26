using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請過濾出名字有包含 Lee 的 Student
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            var result = data.Where(x => x.Name.Contains("Lee"));

            // Assert
            var expected = new[]
            {
                new { Id=1, Name="Bob Lee" },
                new { Id=4, Name="John Lee" }
            };
            expected.ToExpectedObject().ShouldMatch(result);
        }

        private List<Student> GetData()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Bob Lee", Score = 79 },
                new Student { Id = 2, Name = "Kevin Wu", Score = 59 },
                new Student { Id = 3, Name = "Mary Lin", Score = 40 },
                new Student { Id = 4, Name = "John Lee", Score = 80 },
                new Student { Id = 5, Name = "Mike Cheng", Score = 91 }
            };
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}