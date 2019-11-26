using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P7
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請將學生按照 Degree 分組，分組後，請輸出該 Degree 有幾個人
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            
            // 一年級人數
            int degree1 = 0;
            // 二年級人數
            int degree2 = 0;
            // 三年級人數
            int degree3 = 0;
            var result = data.GroupBy(x => x.Degree);
            foreach (var item in result)
            {
                switch (item.Key)
                {
                    case Degree.一年級:
                        degree1 = item.Count();
                        break;
                    case Degree.二年級:
                        degree2 = item.Count();
                        break;
                    case Degree.三年級:
                        degree3 = item.Count();
                        break;
                }
            }

            // Assert
            Assert.AreEqual(3, degree1);
            Assert.AreEqual(1, degree2);
            Assert.AreEqual(1, degree3);
        }

        private List<Student> GetData()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Bob Lee", Score = 79, Degree = Degree.一年級 },
                new Student { Id = 2, Name = "Kevin Wu", Score = 59, Degree = Degree.一年級 },
                new Student { Id = 3, Name = "Mary Lin", Score = 40, Degree = Degree.二年級 },
                new Student { Id = 4, Name = "John Lee", Score = 80, Degree = Degree.一年級 },
                new Student { Id = 5, Name = "Mike Cheng", Score = 91, Degree = Degree.三年級 }
            };
        }
    }    
}