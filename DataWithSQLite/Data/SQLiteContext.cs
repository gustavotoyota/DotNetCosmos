using DataWithMongoDB.Models;
using Microsoft.EntityFrameworkCore;

namespace DataWithSQLite.Data
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
