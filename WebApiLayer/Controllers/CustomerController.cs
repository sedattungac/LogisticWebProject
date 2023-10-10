using BusinessLayer.Abstract;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebApiLayer.Controllers
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

        [HttpGet]
        public IActionResult Get()
        {
            var values = _customerService.TGetList();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _customerService.TGetById(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }
        
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _customerService.TAdd(customer);

            return CreatedAtAction(nameof(GetById), new { id = customer.CustomerId }, default);
        }

        [HttpPut]
        public IActionResult Update(Customer customer)
        {
            var foundedCustomer = _customerService.TGetById(customer.CustomerId);

            if (foundedCustomer == null)
            {
                return NotFound();
            }
            else
            {
                foundedCustomer.Name = customer.Name;
                foundedCustomer.Surname = customer.Surname;
                foundedCustomer.Representative = customer.Representative;
                foundedCustomer.Company = customer.Company;
                foundedCustomer.Telephone = customer.Telephone;
                foundedCustomer.RecordType = customer.RecordType;

                _customerService.TUpdate(foundedCustomer);
            }
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var foundedCustomer = _customerService.TGetById(id);
            
            if (foundedCustomer == null)
                return BadRequest();
          
            _customerService.TDelete(foundedCustomer);

            return NoContent();
        }

    }
}
