using Blazored.LocalStorage;
using RacoShop.ViewModel.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(HttpClient httpClient, ILocalStorageService localStorage) : base(httpClient, localStorage)
        {
        }
        public async Task<List<CategoryVm>> GetAll() => await GetFromJsonAsync<List<CategoryVm>>($"api/categories");

        public async Task<bool> CreateCategory(string name) => await CreateAsJsonAsync($"api/categories", name);
        public async Task<bool> UpdateCategory(int id, string name) => await UpdateAsJsonAsync($"api/categories/{id}", name);
        public async Task<bool> DeleteCategory(int id) => await DeleteAsync($"api/categories/{id}");
    }
}
