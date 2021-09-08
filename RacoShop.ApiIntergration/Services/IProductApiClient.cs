using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface IProductApiClient
    {
        Task<bool> CategoryAssign(int id, int categoryId);
        Task<bool> CreateProduct(ProductRequest request);
        Task<bool> CreateProductImage(int productId, MultipartFormDataContent request);
        Task<bool> DeleteImage(int id);
        Task<bool> DeleteProduct(int id);
        Task<PagedList<ProductVm>> GetAll(PagingRequest request);
        Task<ProductVm> GetById(int id);
        Task<List<ProductImageVm>> GetImageAll(int productId);
        Task<ProductImageVm> GetImageById(int id);
        Task<bool> UpdateProduct(int id, ProductRequest request);
        Task<bool> UpdateProductImage(int productId, MultipartFormDataContent request);
    }
}