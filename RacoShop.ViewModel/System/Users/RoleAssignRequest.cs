using RacoShop.ViewModel.Common;
using System;
using System.Collections.Generic;

namespace RacoShop.ViewModel.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }

        public List<SelectedItem> Roles { get; set; } = new List<SelectedItem>();
    }
}
