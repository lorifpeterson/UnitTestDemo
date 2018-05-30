using System.Collections.Generic;
using System.Linq;

namespace UnitTestDemo.Customer
{
    public class MockCustomerDao : ICustomerDao
    {
        private List<Customer> _customers
        {
            get
            {
                return new List<Customer>()
                           {
                               new Customer() { Id = 134, FirstName = "Sara", LastName = "Smith", AccountNumber = 125500 },
                               new Customer() { Id = 456, FirstName = "Bill", LastName = "Jones", AccountNumber = 89760 },
                               new Customer() { Id = 8810, FirstName = "Bob", LastName = "Smith", AccountNumber = 200760}
                           };
            }
        }

        public Customer FindById(long id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public IList<Customer> FindByLastName(string name)
        {
            return _customers.Where(c => c.LastName == name).ToList();
        }

        public IList<Customer> FindAll()
        {
            return _customers;
        }


        public void AddCustomer(Customer customer)
        {
        }

        public void DeleteCustomer(Customer custome)
        {
        }
    }
}
