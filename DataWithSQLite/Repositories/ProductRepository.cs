using DataWithMongoDB.Models;
using DataWithSQLite.Data;
using Microsoft.EntityFrameworkCore;

namespace DataWithSQLite.Repositories
{
    public class ProductRepository
    {
        private readonly SQLiteContext _context;

        public ProductRepository(SQLiteContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> Create(Product product)
        {
            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product?> Update(int id, Product product)
        {
            var existingProduct = await _context.Products.FindAsync(id);

            if (existingProduct == null)
            {
                return null;
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            await _context.SaveChangesAsync();

            return existingProduct;
        }

        public async Task<bool> Delete(int id)
        {
            var existingProduct = await _context.Products.FindAsync(id);

            if (existingProduct == null)
            {
                return false;
            }

            _context.Products.Remove(existingProduct);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
