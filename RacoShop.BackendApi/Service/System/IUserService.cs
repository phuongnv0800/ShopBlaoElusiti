using RacoShop.ViewModel.Common;
using RacoShop.ViewModel.System.Users;
using System;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.System
{
    public interface IUserService
    {
        Task<string> Authenicate(LoginRequest request);
        Task<bool> Delete(Guid id);
        Task<UserVm> GetById(Guid id);
        Task<UserVm> GetByUserName(string userName);
        Task<PagedList<UserVm>> GetUsersPaging(PagingRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<bool> RoleAssign(Guid id, RoleAssignRequest request);
        Task<bool> Update(Guid id, UserUpdateRequest request);
    }
}