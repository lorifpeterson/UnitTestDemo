using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Cision.UnitTestDemo.Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        public Mock<IUSD_ExchangeRateFeed> _mock { get { return new Mock<IUSD_ExchangeRateFeed>(); }  }

        [TestMethod]
        public void Add_OnePlusTwo_ReturnsThree()
        {
            var calculator = new Calculator(_mock.Object);      // Arrange
            int result = calculator.Add(1, 2);                  // Act
            Assert.AreEqual(result, 3);                         //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void Divide_NineDividedByZero_ThrowsDivideByZeroException()
        {
            var calculator = new Calculator(_mock.Object);
            calculator.Divide(9, 0);   
        }

        [TestMethod]
        public void ConvertUSD_SubmitOneUSD_Returns500()
        {
            // Arrange
            var expectedResult = 500;

            var mock = new Mock<IUSD_ExchangeRateFeed>();           // Create instance of Moq's "Mock" class with an interface
            mock.Setup(e => e.GetActualUSDValue()).Returns(500);    // Tell Moq what you want to happen with the dependency object.
            var calculator = new Calculator(mock.Object);           // Inject the calculator with the mocked object

            // Act
            var actualResult = calculator.ConvertUSD(1);

            
            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Exchange rate of 500 times 1 should return 500.  Bad math.");
        }

        [TestMethod]
        public void ConvertUSD_SubmitTenUSD_Returns4000()
        {
            // Arrange
            var expectedResult = 4000;

            var mock = new Mock<IUSD_ExchangeRateFeed>();           // Create instance of Moq's "Mock" class with an interface
            mock.Setup(e => e.GetActualUSDValue()).Returns(400);    // Tell Moq what you want to happen with the dependency object.
            var calculator = new Calculator(mock.Object);           // Inject the calculator with the mocked object

            // Act
            var actualResult = calculator.ConvertUSD(10);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Exchange rate of 400 times 10 should return 4000.  Bad math.");
        }
    }
}
