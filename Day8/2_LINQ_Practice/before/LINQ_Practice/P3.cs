using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P3
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請輸出字串有包含 'a' ，並將輸出全部轉成大寫
            */

            // Arrange
            string[] data = { "Tom", "Dick", "Harry", "Mary", "Jay" };


            // 請更改這段程式碼，並完成題目
            IEnumerable<string> result = null;

            // Assert
            var expected = new List<string>
            {
                "HARRY",
                "MARY",
                "JAY"
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