using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RacoShop.BackendApi.Service.Catalog;
using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("paging")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery]PagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }

        //https://localhost:port/product/1
        [HttpGet("{productId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _productService.GetById(productId);
            if (product == null)
                return BadRequest("Can't not find product");
            return Ok(product);
        }

        //https://localhost:port/product/1
        [HttpPost]
        //[Consumes("multipart/form-data")]//nhận kiểu dữ liệu truyền lên là form data
        public async Task<IActionResult> Create([FromBody]ProductRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _productService.GetById(productId);
            return Ok(product);
            //return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut("{productId}")]
        //call api with httpClient thi dung FromBody
        public async Task<IActionResult> Update([FromBody]ProductRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var affectedResult = await _productService.Update(request);
            if (affectedResult == 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _productService.Delete(productId);
            if (affectedResult == 0)
                return BadRequest();

            return Ok();
        }

        [HttpPut("{id}/categories")]
        public async Task<IActionResult> CategoryAssign(int id,[FromBody]int categoryId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _productService.CategoryAssign(id, categoryId);
            if (!result)
            {
                return BadRequest(result);
            }
            return Ok();
        }

    }
}
