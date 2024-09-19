using Microsoft.AspNetCore.Mvc;
using ForOC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ForOC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Товар1", Price = 23.0M },
            new Product { Id = 2, Name = "Товар2", Price = 41.0M }
        };
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(products);
        }
        [HttpPost]
        public ActionResult Post(Product product)
        {
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }
    }
}
