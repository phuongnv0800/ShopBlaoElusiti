using Microsoft.AspNetCore.Components;

namespace RacoShop.AdminApp.Features
{
    public class RedirectToLogin : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.NavigateTo("/login");
        }
    }
}
