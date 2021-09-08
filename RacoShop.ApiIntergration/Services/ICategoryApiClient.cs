using RacoShop.ViewModel.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface ICategoryApiClient
    {
        Task<bool> CreateCategory(string name);
        Task<bool> DeleteCategory(int id);
        Task<List<CategoryVm>> GetAll();
        Task<bool> UpdateCategory(int id, string name);
    }
}