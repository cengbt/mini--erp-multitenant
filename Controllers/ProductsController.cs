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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            
            if(product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }
        
        [HttpPost]
        public IActionResult Create(CreateProductRequestDto request)
        {
            var createdProduct = _productService.Create(request);
            return Ok(createdProduct);
        }

    }
}