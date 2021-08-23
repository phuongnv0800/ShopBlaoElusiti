using RacoShop.ViewModel.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface IRoleApiClient
    {
        Task<List<RoleVm>> GetAll();
    }
}