using GraphQlTest.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlTest.Data
{
    public class GraphQlDbContext : DbContext
    {
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
