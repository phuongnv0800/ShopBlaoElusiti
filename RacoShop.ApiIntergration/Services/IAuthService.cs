using RacoShop.ViewModel.System.Users;
using System.Threading.Tasks;

namespace RacoShop.ApiIntergration.Services
{
    public interface IAuthService
    {
        Task<bool> Login(LoginRequest loginRequest);
        Task Logout();
    }
}