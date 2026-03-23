using Microsoft.AspNetCore.Mvc;
using MiniErp.MultiTenant.Entities;


namespace MiniErp.MultiTenant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 25000m
                }
                ,
                new Product
                {
                    Id = 2,
                    Name = "Mouse",
                    Price = 500m
                }
            };

            return Ok(products);
        }
    }
}