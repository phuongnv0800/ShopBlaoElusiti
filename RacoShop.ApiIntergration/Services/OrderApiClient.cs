using Blazored.LocalStorage;
using Microsoft.AspNetCore.WebUtilities;
using RacoShop.ApiIntergration.Services;
using RacoShop.ViewModel.Catalog;
using RacoShop.ViewModel.Common;
using RacoShop.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public class OrderApiClient : BaseApiClient, IOrderApiClient
    {
        public OrderApiClient(HttpClient httpClient, ILocalStorageService localStorage) : base(httpClient, localStorage)
        {
        }
        public async Task<PagedList<OrderVm>> GetAll(PagingRequest request)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = request.PageNumber.ToString(),
            };
            queryStringParam.Add("pageSize", request.PageSize.ToString());
            if (!string.IsNullOrWhiteSpace(request.Keyword))
                queryStringParam.Add("keyword", request.Keyword);
            string url = QueryHelpers.AddQueryString($"/api/orders/paging", queryStringParam);
            return await GetFromJsonAsync<PagedList<OrderVm>>(url);
        }

        public async Task<OrderVm> GetById(int orderId) => await GetFromJsonAsync<OrderVm>($"api/orders/{orderId}");
        public async Task<PagedList<OrderVm>> GetByUser(Guid userId, PagingRequest request)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = request.PageNumber.ToString(),
            };
            queryStringParam.Add("pageSize", request.PageSize.ToString());
            if (!string.IsNullOrWhiteSpace(request.Keyword))
                queryStringParam.Add("keyword", request.Keyword);
            string url = QueryHelpers.AddQueryString($"/api/orders/{userId}/paging", queryStringParam);
            return await GetFromJsonAsync<PagedList<OrderVm>>(url);
        }

        public async Task<bool> Create(OrderRequest request) => await CreateAsJsonAsync($"api/orders", request);
        public async Task<bool> Update(OrderRequest request) => await UpdateAsJsonAsync($"api/orders/{request.Id}", request);
    }

}
