using DataWithMongoDB.Models;
using DataWithMongoDB.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DataWithMongoDB.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class MongoController : Controller
    {
        private readonly ProductRepository _productRepository;

        public MongoController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products = await _productRepository.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Product>> Get(string id)
        {
            var product = await _productRepository.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            await _productRepository.Create(product);

            return CreatedAtRoute("Get", new { id = product.Id?.ToString() }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Product productIn)
        {
            if (await _productRepository.Update(id, productIn))
            {
                return NoContent();
            } else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (await _productRepository.Remove(id))
            {
                return NoContent();
            } else
            {
                return NotFound();
            }
        }
    }
}
