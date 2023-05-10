using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using ProjectOfNET6.Dtos;
using ProjectOfNET6.ResourceParameters;
using SideProjectForNET6.Models;
using SideProjectForNET6.Repository;
using System.Text.RegularExpressions;

namespace ProjectOfNET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductsController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpGet] // api/products?keyword=xxx 下略
        [HttpHead]
        public IActionResult GetProducts(
            [FromQuery] ProductResourceParameters parameters //小於lessThan , 大於largerThan , 等於equalTo ex. lessThan3   largerThan5    equalTo2
            )
        {
            var productsFromRepo = _productRepository.GetProducts(parameters.Keyword, parameters.RatingOperator, parameters.RatingValue);
            if (productsFromRepo == null || !productsFromRepo.Any())
            {
                return NotFound("目前沒有商品");
            }
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(productsFromRepo);
            return Ok(productsDto);
        }
        [HttpGet("{productId}",Name = "GetProductById")]
        [HttpHead("{productId}")]
        public IActionResult GetProduct(Guid productId)
        {
            var productFromRepo = _productRepository.GetProduct(productId);
            if (productFromRepo == null)
            {
                return NotFound($"查無此商品{productId}");
            }
            var productDto = _mapper.Map<ProductDto>(productFromRepo);
            return Ok(productDto);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductForCreationDto productForCreationDto)
        {
            var productModel = _mapper.Map<Product>(productForCreationDto);
            _productRepository.AddProduct(productModel);
            _productRepository.Save();
            var productToReturn = _mapper.Map<ProductDto>(productModel); //若新增成功後，將此資料再回傳給API aka Restful的API自我發現級別(http201 create)
            return CreatedAtRoute("GetProductById", new { productId = productToReturn.Id }, productToReturn); //三個參數  1.要使用的API   2.此API需要的參數   3.數據實體
                                                                                                              //Response回傳後會塞在Header的Location內
        }
        [HttpPut("{productId}")]
        public IActionResult UpdateProduct([FromRoute]Guid productId,[FromBody]ProductForUpdateDto productForUpdateDto)
        {
            if (!_productRepository.ProductExist(productId))
            {
                return NotFound("此商品不存在");
            }
            var productFromRepo = _productRepository.GetProduct(productId);

            _mapper.Map(productForUpdateDto, productFromRepo); //這裡透過automapper把dto映射給entity model，含有上下文context的model即會自動追蹤變更內容，所以save後就可以update寫回資料庫
                                                               //要記得註冊mapper的映射規則 (ProductForUpdateDto To Product)
            _productRepository.Save();

            return NoContent();
        }

        [HttpPatch("{productId}")] //需要多註冊Microsoft.AspNetCore.Mvc.NewtonsoftJson服務 否則會報json value無法convert為json patch 的例外
        public IActionResult PartiallyUpdateProduct([FromRoute]Guid productId, [FromBody] JsonPatchDocument<ProductForUpdateDto> patchDocument)
        {
            if (!_productRepository.ProductExist(productId))
            {
                return NotFound("此商品不存在");
            }
            var productFromRepo = _productRepository.GetProduct(productId);

            //先將資料庫所撈出的實體 映射為 更新類型的dto
            var productToPatch = _mapper.Map<ProductForUpdateDto>(productFromRepo);

            //再把送入的patch資料，apply給映射完成的productToPatch變數，完成資料的patch更新
            patchDocument.ApplyTo(productToPatch, ModelState); //此時productToPatch已成功更新補丁資料，並加入ModelState以供下方數據驗證

            //先執行數據驗證，因為JsonPatchDocument無法自己掛上先前的數據驗證，因此要手動使用ModelState來進行數據驗證
            if (!TryValidateModel(productToPatch))
            {
                return ValidationProblem(ModelState);
            }

            //接著和put操作一樣，把dto數據map給entity model，讓上下文context自動追蹤變更內容
            _mapper.Map(productToPatch, productFromRepo);

            //儲存
            _productRepository.Save();

            return NoContent();

        }

        [HttpDelete("{productId}")]
        public IActionResult DeleteProduct([FromRoute]Guid productId)
        {
            if (!_productRepository.ProductExist(productId))
            {
                return NotFound("此商品不存在");
            }
            var productFromRepo = _productRepository.GetProduct(productId);
            _productRepository.DeleteProduct(productFromRepo);
            _productRepository.Save();

            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteProductsByIDs([FromQuery]List<Guid> productIDs)
        {
            if(productIDs == null)
            {
                return BadRequest();
            }
            var productsFromRepo = _productRepository.GetProductByIDList(productIDs);

            if(productsFromRepo == null)
            {
                return NotFound("商品不存在");
            }

            _productRepository.DeleteProducts(productsFromRepo);
            _productRepository.Save();

            return NoContent();
        }
    }
}
