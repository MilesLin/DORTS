using ExpectedObjects;
using LINQ_Practice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class P8
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
                題目: 請將兩個陣列的值組合在一起
            */

            // Arrange
            int[] numbers = { 3, 5, 7 };
            string[] words = { "three", "five", "seven" };

            // 請更改這段程式碼，並完成題目
            IEnumerable<string> result = numbers.Zip(words, (n, w) => n + "=" + w);

            // Assert
            var expected = new List<string>
            {
                "3=three",
                "5=five",
                "7=seven"
            };

            expected.ToExpectedObject().ShouldMatch(result);
        }
    }    
}