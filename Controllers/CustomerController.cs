using Microsoft.AspNetCore.Mvc;
using CustomerApi.Services;
using CustomerApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {
            if (CustomerService.Customers.Count() == 0)
                CustomerService.CreateCustomers();
        }


        // GET: api/Customer
        [HttpGet]
        public List<Customer> GetAll()
        {
            return CustomerService.Customers;
        }

        // GET api/Customer/id
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
             return CustomerService.GetById(id);
        }

        // POST api/Customer
        [HttpPost]
        public Customer AddCustomer([FromBody] Customer customer)
        {
            return CustomerService.AddCustomer(customer);
        }

        // PUT api/Customer
        [HttpPut()]
        public Customer UpdateCustomer([FromBody] Customer customer)
        {
            return CustomerService.UpdateCustomer(customer);
        }

        // DELETE api/Customer
        [HttpDelete()]
        public bool Delete([FromBody] Customer customer)
        {
            return CustomerService.DeleteCustomer(customer);
        }
    }
}
