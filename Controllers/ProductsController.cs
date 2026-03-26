using Microsoft.AspNetCore.Mvc;
using MiniErp.MultiTenant.Services;
using MiniErp.MultiTenant.Dtos;

namespace MiniErp.MultiTenant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        
        [HttpPost]
        public IActionResult Create(CreateProductRequestDto request)
        {
            var createdProduct = _productService.Create(request);
            return Ok(createdProduct);
        }

    }
}