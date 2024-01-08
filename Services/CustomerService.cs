using CustomerApi.Data;
using CustomerApi.Models;

namespace CustomerApi.Services
{
    public class CustomerService: ICustomerService
    {
        public CustomerService() {
            if (CustomerData.Customers.Count == 0)
                CustomerData.CreateCustomers();
        }
         public void CreateCustomers()
        {
            CustomerData.CreateCustomers();
        }
        public void ClearCustomers()
        {
            CustomerData.ClearCustomers();
        }

        public bool Exists(Customer customer)
        {
            return CustomerData.Exists(customer);
        }

        public List<Customer> GetAll()
        {
            return CustomerData.GetAll();
        }

        public Customer GetById(int id)
        {
            return CustomerData.GetById(id);
        }


        public Customer AddCustomer(Customer newCustomer)
        {
            return CustomerData.AddCustomer(newCustomer);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return CustomerData.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(Customer customer)
        {
            return CustomerData.DeleteCustomer(customer);
        }

    }


}
