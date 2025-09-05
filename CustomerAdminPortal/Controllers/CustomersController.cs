using CustomerAdminPortal.Data;
using CustomerAdminPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public CustomersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = dbContext.Customers.ToList();

            return Ok(customers);
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = dbContext.Customers.Find(id);
            if (customer is null)
            {
                return NotFound();
            }

            return Ok(customer);
        }




        [HttpPost]
        public IActionResult AddCustomer(AddCustomerDto addCustomerDto)
        {
            var customerEntity = new Customer()
            {
                Email = addCustomerDto.Email,
                Phone = addCustomerDto.Phone,
                Name = addCustomerDto.Name,
                Spend = addCustomerDto.Spend,
            };



            dbContext.Customers.Add(customerEntity);
            dbContext.SaveChanges();

            return Ok(customerEntity);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateCustomer(int id, UpdateCustomerDto updateCustomerDto)
        {
            var customer = dbContext.Customers.Find(id);
            if (customer is null)
            {
                return NotFound();
            }

            customer.Spend = updateCustomerDto.Spend;
            customer.Name = updateCustomerDto.Name;
            customer.Phone = updateCustomerDto.Phone;
            customer.Email = updateCustomerDto.Email;

            dbContext.SaveChanges();
            return Ok(customer);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = dbContext.Customers.Find(id);

            if(customer is null) return NotFound();

            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();
            return Ok("deleted");
        }

    }
}
