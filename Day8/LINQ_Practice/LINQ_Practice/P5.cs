using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P5
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請檢查是否有至少一位學生高於 95 分的
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            bool result = data.Any(x => x.Score >= 95);

            // Assert
            var expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            /*
                題目: 請檢查是否全部學生都高於 60 分
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            bool result = data.All(x => x.Score >= 60);

            // Assert
            var expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod3()
        {
            /*
                題目: 請抓出第一個分數高於 90 分的學生
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            Student result = data.FirstOrDefault(x => x.Score >= 90);

            // Assert
            var expected = new Student { Id = 5, Name = "Mike Cheng", Score = 91 };

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