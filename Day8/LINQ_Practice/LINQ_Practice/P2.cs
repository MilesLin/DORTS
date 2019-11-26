using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P2
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請按照成績由低到高排序，並且將資料型態從 Student 轉成 StudentViewModel
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            var result = data.OrderBy(x => x.Score)
                .Select(x => new StudentViewModel
                {
                    Name = x.Name,
                    Score = x.Score
                });

            // Assert
            var expected = new List<StudentViewModel>
            {
                new StudentViewModel { Name = "Mary Lin", Score = 40 },
                new StudentViewModel { Name = "Kevin Wu", Score = 59 },
                new StudentViewModel { Name = "Bob Lee", Score = 79 },
                new StudentViewModel { Name = "John Lee", Score = 80 },
                new StudentViewModel { Name = "Mike Cheng", Score = 91 }
            };

            expected.ToExpectedObject().ShouldMatch(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<StudentViewModel>));
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