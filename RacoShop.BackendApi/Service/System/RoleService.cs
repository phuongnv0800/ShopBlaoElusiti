﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RacoShop.BackendApi.Entities;
using RacoShop.ViewModel.System.Roles;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.System
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles.Select(x => new RoleVm()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToListAsync();

            return roles;
        }
    }
}
