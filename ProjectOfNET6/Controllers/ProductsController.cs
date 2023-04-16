using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SideProjectForNET6.Repository;

namespace ProjectOfNET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productRepository.GetProducts();
            return Ok(products);
        }
    }
}
