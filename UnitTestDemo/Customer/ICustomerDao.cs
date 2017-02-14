using System.Collections.Generic;

namespace Cision.UnitTestDemo.Customer
{
    public interface ICustomerDao
    {
        Customer FindById(long id);
        IList<Customer> FindByLastName(string name);
        IList<Customer> FindAll();
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
