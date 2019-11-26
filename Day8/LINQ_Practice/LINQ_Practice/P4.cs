using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P4
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請將 List<Student> 轉換成 Dictionary<int, Student>， Dictionary 的 Key 是 Student.Id
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            var result = data.ToDictionary(x => x.Id, x => x);

            // Assert
            var expected = new Dictionary<int, Student>
            {
                { 1, new Student { Id = 1, Name = "Bob Lee", Score = 79 } },
                { 2, new Student { Id = 2, Name = "Kevin Wu", Score = 59 } },
                { 3, new Student { Id = 3, Name = "Mary Lin", Score = 40 } },
                { 4, new Student { Id = 4, Name = "John Lee", Score = 80 } },
                { 5, new Student { Id = 5, Name = "Mike Cheng", Score = 91 } }
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
}