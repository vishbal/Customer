using Microsoft.AspNetCore.Mvc;
using CustomerApi.Services;
using CustomerApi.Models;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer
        [HttpGet]
        public List<Customer> GetAll()
        {
            return _customerService.GetAll();
        }

        // GET api/Customer/id
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
             return _customerService.GetById(id);
        }

        // POST api/Customer
        [HttpPost]
        public Customer AddCustomer([FromBody] Customer customer)
        {
            return _customerService.AddCustomer(customer);
        }

        // PUT api/Customer
        [HttpPut()]
        public Customer UpdateCustomer([FromBody] Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }

        // DELETE api/Customer
        [HttpDelete()]
        public bool Delete([FromBody] Customer customer)
        {
            return _customerService.DeleteCustomer(customer);
        }

        // DELETE api/Customer
        [HttpDelete("deleteAll")]
        public bool DeleteAll()
        {
            return _customerService.DeleteAll();
        }
    }
}
