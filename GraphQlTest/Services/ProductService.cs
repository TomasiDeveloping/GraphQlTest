using GraphQlTest.Data;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;

namespace GraphQlTest.Services
{
    public class ProductService : IProduct
    {
        private readonly GraphQlDbContext _dbContext;

        public ProductService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            var productObj = _dbContext.Products.Find(id);
            productObj.Name = product.Name;
            productObj.Price = product.Price;
            _dbContext.SaveChanges();
            return productObj;
        }

        public void DeleteProduct(int id)
        {
            var productObj = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(productObj);
            _dbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.Find(id);
        }
    }
}
