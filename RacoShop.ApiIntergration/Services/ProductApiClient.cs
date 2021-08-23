using Blazored.LocalStorage;
using Microsoft.AspNetCore.WebUtilities;
using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        private readonly HttpClient _httpClient;

        public ProductApiClient(HttpClient httpClient,
                           ILocalStorageService localStorage) : base(httpClient, localStorage)
        {
            _httpClient = httpClient;
        }
        public async Task<PagedList<ProductVm>> GetAll(PagingRequest request)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = request.PageNumber.ToString(),
            };
            queryStringParam.Add("pageSize", request.PageSize.ToString());
            if (!string.IsNullOrWhiteSpace(request.Keyword))
                queryStringParam.Add("keyword", request.Keyword);
            //if (request.CategoryId != null)
            //    queryStringParam.Add("categoryId", request.CategoryId.ToString());
            string url = QueryHelpers.AddQueryString($"/api/products/paging", queryStringParam);

            return await _httpClient.GetFromJsonAsync<PagedList<ProductVm>>(url);
        }
        public async Task<ProductVm> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductVm>($"/api/products/{id}");
        }

        public async Task<bool> CreateProduct(ProductRequest request) => await CreateAsJsonAsync($"/api/products", request);

        public async Task<bool> UpdateProduct(int id, ProductRequest request) => await UpdateAsJsonAsync($"/api/products/{id}", request);

        public async Task<bool> DeleteProduct(int id) => await DeleteAsync($"/api/products/{id}");
        public async Task<bool> CategoryAssign(int id, int categoryId) => await UpdateAsJsonAsync($"/api/products/{id}/categories", categoryId);
    }
}