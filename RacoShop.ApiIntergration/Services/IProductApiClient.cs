using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface IProductApiClient
    {
        Task<bool> CategoryAssign(int id, int categoryId);
        Task<bool> CreateProduct(ProductRequest request);
        Task<bool> DeleteProduct(int id);
        Task<PagedList<ProductVm>> GetAll(PagingRequest request);
        Task<ProductVm> GetById(int id);
        Task<bool> UpdateProduct(int id, ProductRequest request);
    }
}