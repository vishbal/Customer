using CustomerApi.Models;

namespace CustomerApi.Services
{
    public interface ICustomerService
    {
        void CreateCustomers();
        void ClearCustomers();
        bool Exists(Customer customer);
        Customer GetById(int id);
        List<Customer> GetAll();
        Customer AddCustomer(Customer newCustomer);
        Customer UpdateCustomer(Customer newCustomer);
        bool DeleteCustomer(Customer newCustomer);
        bool DeleteAll();
    }
}
