using MiniErp.MultiTenant.Entities;
using MiniErp.MultiTenant.Data;
using MiniErp.MultiTenant.Dtos;

namespace MiniErp.MultiTenant.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public Product Create(CreateProductRequestDto request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price
            };

            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

    }
}
