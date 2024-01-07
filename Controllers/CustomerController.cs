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


        // GET: api/<CustomerController>
        [HttpGet]
        public List<Customer> Get()
        {
            return CustomerService.Customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
             return CustomerService.GetById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public Customer AddCustomer([FromBody] Customer customer)
        {
            return CustomerService.AddCustomer(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut()]
        public Customer UpdateCustomer([FromBody] Customer customer)
        {
            return CustomerService.UpdateCustomer(customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete()]
        public bool Delete([FromBody] Customer customer)
        {
            return CustomerService.DeleteCustomer(customer);
        }
    }
}
