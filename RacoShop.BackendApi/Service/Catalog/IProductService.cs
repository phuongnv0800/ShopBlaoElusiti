using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.Catalog
{
    public interface IProductService
    {
        Task<bool> CategoryAssign(int id, int categoryId);
        Task<int> Create(ProductRequest request);
        Task<int> Delete(int productId);
        Task<PagedList<ProductVm>> GetAllByCategoryId(int categoryId, PagingRequest request);
        Task<PagedList<ProductVm>> GetAllPaging(PagingRequest request);
        Task<ProductVm> GetById(int productId);
        Task<int> Update(ProductRequest request);
    }
}