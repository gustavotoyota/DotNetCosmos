using DataWithMongoDB.Models;
using MongoDB.Driver;

namespace DataWithMongoDB.Repositories
{
    public class ProductRepository
    {
        private readonly IMongoCollection<Product> _products;

        public ProductRepository(IMongoClient mongoClient, IConfiguration configuration)
        {
            var database = mongoClient.GetDatabase(configuration["MongoDBSettings:DatabaseName"]);

            _products = database.GetCollection<Product>(configuration["MongoDBSettings:ProductsCollectionName"]);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _products.Find(product => true).ToListAsync();
        }

        public async Task<Product> GetById(string id)
        {
            return await _products.Find(product => product.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Product> Create(Product product)
        {
            await _products.InsertOneAsync(product);

            return product;
        }

        public async Task<bool> Update(string id, Product productIn)
        {
            productIn.Id = id;

            var result = await _products.ReplaceOneAsync(product => product.Id == id, productIn);

            return result.ModifiedCount > 0;
        }

        public async Task<bool> Remove(string id)
        {
            var result = await _products.DeleteOneAsync(product => product.Id == id);

            return result.DeletedCount > 0;
        }
    }
}
