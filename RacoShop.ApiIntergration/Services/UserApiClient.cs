using Blazored.LocalStorage;
using Microsoft.AspNetCore.WebUtilities;
using RacoShop.ViewModel.Common;
using RacoShop.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        public UserApiClient(HttpClient httpClient, ILocalStorageService localStorageService)
            : base(httpClient, localStorageService)
        {
        }
        public async Task<PagedList<UserVm>> GetAll(PagingRequest request)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = request.PageNumber.ToString(),
            };
            queryStringParam.Add("pageSize", request.PageSize.ToString());
            if (!string.IsNullOrWhiteSpace(request.Keyword))
                queryStringParam.Add("keyword", request.Keyword);
            string url = QueryHelpers.AddQueryString($"/api/users/paging", queryStringParam);

            return await GetFromJsonAsync<PagedList<UserVm>>(url);
        }
        public async Task<UserVm> GetById(Guid id) => await GetFromJsonAsync<UserVm>($"/api/users/{id}");
        public async Task<UserVm> GetByUserName(string userName) => await GetFromJsonAsync<UserVm>($"/api/users/name/{userName}");
        public async Task<bool> Register(RegisterRequest request) => await CreateAsJsonAsync($"/api/users", request);
        public async Task<bool> Update(Guid id, UserUpdateRequest request) => await UpdateAsJsonAsync($"/api/users/{id}", request);
        public async Task<bool> Delete(Guid id) => await DeleteAsync($"/api/users/{id}");
        public async Task<bool> Assign(Guid id, RoleAssignRequest request) => await UpdateAsJsonAsync($"/api/users/{id}/roles", request);
    }
}
