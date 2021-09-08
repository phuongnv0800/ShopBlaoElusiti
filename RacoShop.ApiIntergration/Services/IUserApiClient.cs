using RacoShop.ViewModel.Common;
using RacoShop.ViewModel.System.Users;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface IUserApiClient
    {
        Task<bool> Assign(Guid id, RoleAssignRequest request);
        Task<bool> Delete(Guid id);
        Task<PagedList<UserVm>> GetAll(PagingRequest request);
        Task<UserVm> GetById(Guid id);
        Task<UserVm> GetByUserName(string userName);
        Task<bool> Register(RegisterRequest request);
        Task<bool> Update(Guid id, MultipartFormDataContent request);
    }
}