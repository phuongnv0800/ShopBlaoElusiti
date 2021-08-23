using RacoShop.ViewModel.Catalog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface ICartApiClient
    {
        Task<bool> AddToCart(CartRequest request);
        Task<bool> DeleteProduct(Guid userId, int productId);
        Task<IEnumerable<CartVm>> Get(Guid userId);
        Task<IEnumerable<CartVm>> GetByUserName(string userName);
    }
}