using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P6
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
             *  前提概要:
                  現在有 20 筆 Student 資料，而你要做分頁效果，目前預設每頁是 5 筆資料，
                所以如果現在要看第 1 頁的資料，則取得 Id = 1 ~ Id = 5 的 5 筆 Student 資料
                如果是第 2 頁的話，則取得 Id = 6 ~ Id = 10 的 5 筆 Student 資料，以此類推

                題目: 請用 LINQ 抓出第 3 頁的資料
            */

            // Arrange
            var data = GetData();

            // 請更改這段程式碼，並完成題目
            int pageNumber = 5;
            IEnumerable<Student> result = null;

            // Assert
            var expected = new List<Student>
            {
                new Student { Id = 11, Name = "qq Bob Lee", Score = 79 },
                new Student { Id = 12, Name = "aa Kevin Wu", Score = 59 },
                new Student { Id = 13, Name = "uu Mary Lin", Score = 40 },
                new Student { Id = 14, Name = "kk John Lee", Score = 80 },
                new Student { Id = 15, Name = "pp Mike Cheng xx", Score = 91 }
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
                new Student { Id = 5, Name = "Mike Cheng xx", Score = 91 },
                new Student { Id = 6, Name = "Bob Lee yy", Score = 79 },
                new Student { Id = 7, Name = "Kevin Wu zz", Score = 59 },
                new Student { Id = 8, Name = "Mary Lin aa", Score = 40 },
                new Student { Id = 9, Name = "John Lee bb", Score = 80 },
                new Student { Id = 10, Name = "Mike Cheng cc", Score = 91 },
                new Student { Id = 11, Name = "qq Bob Lee", Score = 79 },
                new Student { Id = 12, Name = "aa Kevin Wu", Score = 59 },
                new Student { Id = 13, Name = "uu Mary Lin", Score = 40 },
                new Student { Id = 14, Name = "kk John Lee", Score = 80 },
                new Student { Id = 15, Name = "pp Mike Cheng xx", Score = 91 },
                new Student { Id = 16, Name = "mm Bob Lee yy", Score = 79 },
                new Student { Id = 17, Name = "Kevin Wu Wu zz", Score = 59 },
                new Student { Id = 18, Name = "Mary Mi Lin aa", Score = 40 },
                new Student { Id = 19, Name = "John Pi Lee bb", Score = 80 },
                new Student { Id = 20, Name = "Mike Gu Cheng cc", Score = 91 },
            };
        }
    }    
}