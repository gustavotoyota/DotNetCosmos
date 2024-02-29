using DataWithMongoDB.Models;
using DataWithSQLite.Data;
using DataWithSQLite.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DataWithSQLite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private ProductRepository _productRepository;

        public ProductsController(SQLiteContext context)
        {
            _productRepository = new ProductRepository(context);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return Ok(await _productRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var product = await _productRepository.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {
            return Ok(await _productRepository.Create(product));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Put(int id, Product product)
        {
            var updatedProduct = await _productRepository.Update(id, product);

            if (updatedProduct == null)
            {
                return NotFound();
            }

            return Ok(updatedProduct);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _productRepository.Delete(id);

            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
