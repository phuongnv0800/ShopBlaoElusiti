using RacoShop.ViewModel.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.System
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}