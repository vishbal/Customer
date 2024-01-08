using CustomerApi.Models;

namespace CustomerApi.Services
{
    public static class CustomerService
    {
        public static List<Customer> Customers = new List<Customer>();


        public static void CreateCustomers()
        {
            ClearCustomers();
            for (int i = 1; i <= 20; i++)
            {
                Customers.Add(new Customer
                {
                    Id = i,
                    FirstName = "Customer First Name - " + i,
                    LastName = "Customer Last Name - " + i,
                    CreatedDate = new DateTime(),
                    UpdatedDate = new DateTime(),
                    Email = "customer" + i + "@example.com"
                });
            }
        }
        public static void ClearCustomers()
        {
            Customers.Clear();
        }

        public static bool Exists(Customer customer)
        {
            return Customers.Any(x => x.Email == customer.Email);
        }

        public static Customer GetById(int id)
        {
            var customer = new Customer();
            if (Customers.Any(c => c.Id == id))
                customer = Customers.Find(c => c.Id == id);

            return customer;
        }


        public static Customer AddCustomer(Customer newCustomer)
        {
            if (!Exists(newCustomer))
            {
                newCustomer.Id = Customers.Max(c => c.Id) + 1;
                Customers.Add(newCustomer);
            }
            else
            {
                newCustomer = Customers.First(c => c.Email == newCustomer.Email);
            }
            return newCustomer;
        }

        public static Customer UpdateCustomer(Customer customer)
        {
            var existingCustomer = GetById(customer.Id);
            var index = Customers.IndexOf(existingCustomer);
            if (index > -1)
            {
                Customers[index] = customer;
                return Customers[index];
            }
            else
            {
                customer.Id = 0;
            }
            return customer;
        }

        public static bool DeleteCustomer(Customer customer)
        {
            if (Exists(customer))
            {
                var index = Customers.FindIndex(c => c.Id == customer.Id);
                Customers.RemoveAt(index);
                return true;
            }
            return false;
        }

    }


}
