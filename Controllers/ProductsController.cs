using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products_API.Models;
using Products_API.Services.PruductService;

namespace Products_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
                _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return await _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetSingleProduct(int id)
        {
            var result = await _productService.GetSingleProduct(id);
            if (result is null)
                return NotFound("Sorry, but this product doesn't exist.");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(Product product)
        {
            var result = await _productService.AddProduct(product);
            return Ok(result);
        }

        [HttpPut("id")]
        public async Task<ActionResult<List<Product>>> UpdateProduct(int id, Product request)
        {
            var result = await _productService.UpdateProduct(id, request);
            if (result is null)
                return NotFound("Sorry, but this product doesn't exist.");
            return Ok(result);
        }

        [HttpDelete("id")]
        public async Task<ActionResult<List<Product>>> DeleteProduct(int id)
        {
            var result = await _productService.DeleteProduct(id);
            if (result is null)
                return NotFound("Sorry, but this product doesn't exist.");
            return Ok(result);
        }
    }
}
