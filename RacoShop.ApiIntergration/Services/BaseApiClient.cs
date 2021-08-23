using Blazored.LocalStorage;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public class BaseApiClient
    {
        private readonly HttpClient httpClient;
        private readonly ILocalStorageService localStorage;

        protected BaseApiClient(HttpClient httpClient, ILocalStorageService localStorage)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
        }

        protected async Task<T> GetFromJsonAsync<T>(string url)
        {
            var token = await localStorage.GetItemAsync<string>("authToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await httpClient.GetFromJsonAsync<T>(url);

            return response;
        }

        public async Task<bool> DeleteAsync(string url)
        {
            var token = await localStorage.GetItemAsync<string>("authToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await httpClient.DeleteAsync(url);

            //var body = await response.Content.ReadAsStringAsync();
            //return JsonSerializer.Deserialize<T>(body);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsJsonAsync<T>(string url, T request)
        {
            var token = await localStorage.GetItemAsync<string>("authToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await httpClient.PutAsJsonAsync(url, request);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateAsync(string url, MultipartFormDataContent request)
        {
            var token = await localStorage.GetItemAsync<string>("authToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await httpClient.PutAsync(url, request);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CreateAsJsonAsync<T>(string url, T request)
        {

            var token = await localStorage.GetItemAsync<string>("authToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await httpClient.PostAsJsonAsync(url, request);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> CreateAsync(string url, MultipartFormDataContent request)
        {

            var token = await localStorage.GetItemAsync<string>("authToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await httpClient.PostAsync(url, request);
            return response.IsSuccessStatusCode;
        }

        //public async Task<List<T>> GetListAsync<T>(string url, bool requiredLogin = false)
        //{
        //    var sessions = _httpContextAccessor
        //       .HttpContext
        //       .Session
        //       .GetString(SystemConstants.AppSettings.Token);
        //    var client = _httpClientFactory.CreateClient();
        //    client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

        //    var response = await client.GetAsync(url);
        //    var body = await response.Content.ReadAsStringAsync();
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var data = (List<T>)JsonConvert.DeserializeObject(body, typeof(List<T>));
        //        return data;
        //    }
        //    throw new Exception(body);
        //}
    }
}
