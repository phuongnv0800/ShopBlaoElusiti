using RacoShop.ViewModel.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.Catalog
{
    public interface ICategoryService
    {
        Task<int> Create(string name);
        Task<int> Delete(int id);
        Task<IEnumerable<CategoryVm>> GetAll();
        Task<int> Update(int id, string name);
    }
}