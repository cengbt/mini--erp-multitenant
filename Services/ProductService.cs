using MiniErp.MultiTenant.Entities;

namespace MiniErp.MultiTenant.Services
{
    public class ProductService
    {
        public List<Product> GetAll()
        {
            var products = new List<Product>()
            { 
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 25000m
                },
                new Product
                {
                    Id = 2,
                    Name = "Mouse",
                    Price = 500m
                }
            };
            return products;
        }

    }
}
