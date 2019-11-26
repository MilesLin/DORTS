using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P9
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請將 Course 的資料攤平，與 Student 放到同一個層級
                提示: 使用 SelectMany

                請參考此文章作答: https://dotblogs.com.tw/mileslin/2016/03/01/015739
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            var result = data.SelectMany(
                            // 第一個參數，代表每一筆Student各包含哪些Course
                            std => std.Course,
                            // 第二個參數，則是產生新的匿名型別
                            (std, crs) => new { std.Id, std.Name, crs.CourseName }
                        );

            // Assert
            var expected = new[]
            {
                new { Id=1, Name="Kevin", CourseName="數學" },
                new { Id=1, Name="Kevin", CourseName="國文"  },
                new { Id=2, Name="Bob", CourseName="數學"  }
            };
            expected.ToExpectedObject().ShouldMatch(result);
        }

        private List<Student> GetData()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Kevin",
                    Course = new List<Course>()
                    {
                        new Course(){
                            StudentId = 1,
                            CourseName = "數學"
                        },
                        new Course(){
                            StudentId = 1,
                            CourseName = "國文"
                        },
                    }
                },
                new Student()
                {
                    Id = 2,
                    Name = "Bob",
                    Course = new List<Course>()
                    {
                        new Course(){
                            StudentId = 2,
                            CourseName = "數學"
                        }
                    }
                }
            };
        }
    }
}