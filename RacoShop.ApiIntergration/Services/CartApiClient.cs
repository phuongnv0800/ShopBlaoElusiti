using Blazored.LocalStorage;
using RacoShop.ViewModel.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public class CartApiClient : BaseApiClient, ICartApiClient
    {
        public CartApiClient(HttpClient httpClient, ILocalStorageService localStorage) : base(httpClient, localStorage)
        {
        }
        public async Task<IEnumerable<CartVm>> GetByUserName(string userName) => await GetFromJsonAsync<IEnumerable<CartVm>>($"/api/carts/name/{userName}");
        public async Task<IEnumerable<CartVm>> Get(Guid userId) => await GetFromJsonAsync<IEnumerable<CartVm>>($"/api/carts/{userId}");
        public async Task<bool> AddToCart(CartRequest request) => await CreateAsJsonAsync($"/api/carts", request);
        public async Task<bool> DeleteProduct(Guid userId, int productId) => await DeleteAsync($"/api/carts/{userId}/{productId}");
    }
}
