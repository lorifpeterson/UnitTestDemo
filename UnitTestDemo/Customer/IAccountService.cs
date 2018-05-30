namespace UnitTestDemo.Customer
{
    public interface IAccountService
    {
        Customer GetCustomer(long userId, long customeId);
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
