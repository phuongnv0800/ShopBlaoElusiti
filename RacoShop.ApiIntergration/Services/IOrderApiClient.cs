using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using RacoShop.ViewModel.System.Users;
using System;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface IOrderApiClient
    {
        Task<bool> Create(OrderRequest request);
        Task<PagedList<OrderVm>> GetAll(PagingRequest request);
        Task<OrderVm> GetById(int orderId);
        Task<PagedList<OrderVm>> GetByUser(Guid userId, PagingRequest request);
        Task<bool> Update(OrderRequest request);
    }
}