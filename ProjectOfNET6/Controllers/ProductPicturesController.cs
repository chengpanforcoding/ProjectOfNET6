using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectOfNET6.Dtos;
using SideProjectForNET6.Models;
using SideProjectForNET6.Repository;

namespace ProjectOfNET6.Controllers
{
    [Route("api/products/{productId}/pictures")]
    [ApiController]
    public class ProductPicturesController : ControllerBase
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductPicturesController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetPictureListForProduct(Guid productId)
        {
            if (!_productRepository.ProductExist(productId))
            {
                return NotFound("找不到此商品");
            }
            var picturesFromRepo = _productRepository.GetPicturesByProductId(productId);
            if(picturesFromRepo == null || !picturesFromRepo.Any())
            {
                return NotFound("照片不存在");
            }

            return Ok(_mapper.Map<IEnumerable<ProductPictureDto>>(picturesFromRepo));
        }

        [HttpGet("{pictureId}",Name ="GetPicture")] //api/products/{productId}/pictures/{pictureId}
        public IActionResult GetPicture(Guid productId, int pictureId) //先取得主Domain 才能取得子Domain
                                                                       //避免暴露給Client 所以要求也要帶Guid的產品編號
        {
            if (!_productRepository.ProductExist(productId))
            {
                return NotFound("找不到此商品");
            }
            var pictureFromRepo = _productRepository.GetPictureByPictureId(pictureId);
            if(pictureFromRepo == null)
            {
                return NotFound("照片不存在");
            }
            return Ok(_mapper.Map<ProductPictureDto>(pictureFromRepo));
        }

        [HttpPost]
        public IActionResult CreateProductPicture([FromRoute]Guid productId, [FromBody] ProductPictureForCreationDto productPictureForCreation)
        {
            if (!_productRepository.ProductExist(productId))
            {
                return NotFound("找不到此商品");
            }
            var pictureModel = _mapper.Map<ProductPicture>(productPictureForCreation);
            _productRepository.AddProductPicture(productId, pictureModel);
            _productRepository.Save();
            var pictureToReturn = _mapper.Map<ProductPictureDto>(pictureModel);
            return CreatedAtRoute("GetPicture", new { productId = pictureToReturn.ProductId, pictureId = pictureToReturn.Id }, pictureToReturn);
        }

        [HttpDelete("{pictureId}")]
        public IActionResult DeleteProductPicture([FromRoute]Guid productId, [FromRoute] int pictureId)
        {
            if (!_productRepository.ProductExist(productId))
            {
                return NotFound("找不到此商品");
            }
            var pictureFromRepo = _productRepository.GetPictureByPictureId(pictureId);
            _productRepository.DeleteProductPicture(pictureFromRepo);
            _productRepository.Save();
            return NoContent();
        }
    }
}
