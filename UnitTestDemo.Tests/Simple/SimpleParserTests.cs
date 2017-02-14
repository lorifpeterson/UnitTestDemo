using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cision.UnitTestDemo.Simple
{
    [TestClass]
    public class SimpleParserTests
    {
        [TestMethod]
        public void ParseAndSum_Send_1_2_and3_Returns6()
        {
            // Arrange
            int expectedResult = 6;
            SimpleParser parser = new SimpleParser();
            
            // Act
            int actualResult = parser.ParseAndSum("1,2,3");

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
