using ForOC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ForOC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Kseniya Suvorova", Number = "+7 (999) 255-78-87" },
            new Customer { Id = 2, Name = "Nikita Dolgorukov", Number = "+7 (903) 777-23-23" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public ActionResult Post(Customer customer)
        {
            customers.Add(customer);
            return CreatedAtAction(nameof(Get), new { id = customer.Id }, customer);
        }
    }
}
