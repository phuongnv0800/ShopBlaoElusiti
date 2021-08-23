using Blazored.LocalStorage;
using RacoShop.ViewModel.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public class RoleApiClient : BaseApiClient, IRoleApiClient
    {
        public RoleApiClient(HttpClient httpClient, ILocalStorageService localStorage) : base(httpClient, localStorage)
        {
        }
        public async Task<List<RoleVm>> GetAll() => await GetFromJsonAsync<List<RoleVm>>($"api/roles");
    }
}
