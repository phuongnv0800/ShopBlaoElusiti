using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacoShop.BackendApi.Service.Catalog;
using RacoShop.ViewModel.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(Guid userId)
        {
            var cart = await _cartService.Get(userId);
            if (cart == null)
                return BadRequest();
            return Ok(cart);
        }
        [HttpGet("name/{userName}")]
        public async Task<IActionResult> GetByUserName(string userName)
        {
            var cart = await _cartService.GetByUserName(userName);
            if (cart == null)
                return BadRequest();
            return Ok(cart);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CartRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var cart = await _cartService.Create(request);
            if (!cart)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{userId}/{productId}")]
        public async Task<IActionResult> Delete(Guid userId, int productId)
        {
            var affectedResult = await _cartService.Delete(userId,productId);
            if (!affectedResult)
                return BadRequest();

            return Ok();
        }
    }
}
