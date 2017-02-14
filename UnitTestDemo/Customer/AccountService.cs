using System;

namespace Cision.UnitTestDemo.Customer
{
    public class AccountService : IAccountService
    {
        private readonly ISecurityService _securityService;
        private readonly ICustomerDao _customerDao;

        public AccountService(ISecurityService securityService, ICustomerDao customerDao)
        {
            _securityService = securityService;
            _customerDao = customerDao;
        }

        public Customer GetCustomer(long userId, long customerId)
        {
            //if(_securityService.HasAccess(userId))
            //{
            return _customerDao.FindById(customerId);
            //}
            //else
            //{
            //    throw new UnauthorizedAccessException("Access Denied");
            //}
        }

        public void AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                _customerDao.AddCustomer(customer);
            }
            else
            {
                throw new ArgumentException("Invalid customer");
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            if (customer != null)
            {
                _customerDao.DeleteCustomer(customer);
            }
            else
            {
                throw new ArgumentException("Invalid customer");
            }
        }
    }
}
