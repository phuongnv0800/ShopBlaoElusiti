using RacoShop.ViewModel.Catalog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.Catalog
{
    public interface ICartService
    {
        Task<bool> Create(CartRequest request);
        Task<bool> Delete(Guid userId, int productId);
        Task<IEnumerable<CartVm>> Get(Guid userId);
        Task<IEnumerable<CartVm>> GetByUserName(string userName);
    }
}