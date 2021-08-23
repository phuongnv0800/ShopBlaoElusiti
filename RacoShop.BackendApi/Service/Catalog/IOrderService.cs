using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.Catalog
{
    public interface IOrderService
    {
        Task<bool> Create(OrderRequest request);
        Task<PagedList<OrderVm>> GetAllPaging(PagingRequest request);
        Task<OrderVm> GetById(int orderId);
        Task<PagedList<OrderVm>> GetByUser(Guid userId, PagingRequest request);
        Task<bool> Update(OrderRequest request);
    }
}