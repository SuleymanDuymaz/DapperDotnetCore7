using API.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _productRepository.GetProductsAsync());
        }
        [HttpGet("GetAllProductListWithCategory")]
        public async Task<IActionResult> GetAllProductListWithCategory()
        {
            return Ok(await _productRepository.GetAllProductWithCategoryAsync());
        }

    }
}
