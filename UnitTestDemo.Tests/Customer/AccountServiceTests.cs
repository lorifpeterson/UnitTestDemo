using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestDemo.Customer
{
    [TestClass]
    public class AccountServiceTests
    {
        // Sample using Manually written mocks
        [TestMethod]
        public void GetCustomer_CustomerId134_ReturnsSaraSmith()
        {
            // Arrange
            long userId = 123;
            long customerId = 134;
            Customer expectedResult = new Customer()
            {
                FirstName = "Sara",
                LastName = "Smith"
            };

            IAccountService service = new AccountService(new MockSecurityService(), new MockCustomerDao());

            // Act
            Customer actualResult = service.GetCustomer(userId, customerId);

            // Assert
            Assert.AreEqual(expectedResult.FirstName, actualResult.FirstName);
            Assert.AreEqual(expectedResult.LastName, actualResult.LastName);
        }

        // Samples using Moq

        [TestMethod]
        public void GetCustomer_ForAllUsers_ShouldCallHasAccessMethodOnce()
        {
            var security = new Mock<ISecurityService>();
            var customer = new Mock<ICustomerDao>();
            security.Setup(x => x.HasAccess(It.IsAny<long>())).Returns(true);

            IAccountService service = new AccountService(security.Object, customer.Object);
            
            service.GetCustomer(123, 456);
            
            security.Verify(s => s.HasAccess(123), Times.Exactly(1));
        }
        
        [TestMethod]
        [ExpectedException(typeof(System.UnauthorizedAccessException))]
        public void GetCustomer_UserDoesNotHaveAccess_UnauthorizedAccessExceptionIsThrown()
        {
            var security = new Mock<ISecurityService>();
            var customer = new Mock<ICustomerDao>();

            // setup the behavior to return false for security access
            security.Setup(x => x.HasAccess(It.IsAny<long>())).Returns(true);

            // Inject mocks for use in Account Service
            IAccountService service = new AccountService(security.Object, customer.Object);

            Customer actualResult = service.GetCustomer(123, 456);
        }

        

    }
}
