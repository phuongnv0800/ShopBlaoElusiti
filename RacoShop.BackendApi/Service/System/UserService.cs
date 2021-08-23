using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RacoShop.BackendApi.Entities;
using RacoShop.BackendApi.Service.Common;
using RacoShop.Utilities.Constants;
using RacoShop.ViewModel.Common;
using RacoShop.ViewModel.System.Users;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.System
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        private readonly IStorageService _storageService;

        public UserService(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration config,
            IStorageService storageService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
            _storageService = storageService;
        }

        public async Task<string> Authenicate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return "";
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded) return "";

            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FirstName + " " + user.LastName),
                new Claim(ClaimTypes.Role, string.Join(";", roles)),
                new Claim(ClaimTypes.Name, request.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_config["Jwt:ExpiryInDays"]));

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Delete(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return false;
            var result = await _userManager.DeleteAsync(user);//xoa user
            if (result.Succeeded)
                return false;
            return true;
        }

        public async Task<UserVm> GetById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return new UserVm();

            var roles = await _userManager.GetRolesAsync(user);
            var userVm = new UserVm()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                Dob = user.Dob,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Gender = user.Gender,
                Address = user.Address,
                Avatar = SystemConstants.BaseUrlImage +  user.Avatar,
                Roles = roles,
            };
            return userVm;
        }
        public async Task<UserVm> GetByUserName(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
                return new UserVm();

            var roles = await _userManager.GetRolesAsync(user);
            var userVm = new UserVm()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                Dob = user.Dob,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Gender = user.Gender,
                Address = user.Address,
                Avatar = SystemConstants.BaseUrlImage + user.Avatar,
                Roles = roles,
            };
            return userVm;
        }

        public async Task<PagedList<UserVm>> GetUsersPaging(PagingRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword));
            }
            //paging
            int totalRow = await query.CountAsync();
            var data = await query
                .Select(
                    x => new UserVm()
                    {
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        UserName = x.UserName,
                        Id = x.Id,
                        PhoneNumber = x.PhoneNumber,
                        Dob = x.Dob,
                        Gender = x.Gender,
                        Address = x.Address,
                        Avatar = SystemConstants.BaseUrlImage + x.Avatar,
                    }
                )
                .OrderBy(x => x.Id)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();
            // select
            var pagedResult = new PagedList<UserVm>()
            {
                MetaData = new MetaData()
                {
                    TotalCount = totalRow,
                    PageSize = request.PageSize,
                    CurrentPage = request.PageNumber,
                    TotalPages = (int)Math.Ceiling((double)totalRow / request.PageSize),
                },
                Items = data,
            };
            return pagedResult;
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                return false;
            }
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                return false;
            }

            user = new AppUser()
            {
                Dob = request.Dob,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Gender = request.Gender,
                Address = request.Address,
                Avatar = await SaveFile(request.AvatarLink),
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> RoleAssign(Guid id, RoleAssignRequest request)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return false;
            }
            var removedRoles = request.Roles.Where(x => x.Selected == false).Select(x => x.Name).ToList();

            //await _userManager.RemoveFromRolesAsync(user, removedRoles);
            foreach (var roleName in removedRoles)
            {
                if (await _userManager.IsInRoleAsync(user, roleName) == true)
                    await _userManager.RemoveFromRoleAsync(user, roleName);
            }

            var addedRoles = request.Roles.Where(x => x.Selected).Select(x => x.Name).ToList();
            foreach (var roleName in addedRoles)
            {
                if (await _userManager.IsInRoleAsync(user, roleName) == false)
                    await _userManager.AddToRoleAsync(user, roleName);
            }
            return true;
        }

        public async Task<bool> Update(Guid id, UserUpdateRequest request)
        {

            if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != id))
            {
                return false;
            }

            var user = await _userManager.FindByIdAsync(id.ToString());

            user.Dob = request.Dob;
            user.Email = request.Email;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.PhoneNumber = request.PhoneNumber;
            user.Gender = request.Gender;
            user.Address = request.Address;
            if(request.AvatarLink != null)
                user.Avatar = await SaveFile(request.AvatarLink);


            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
        private async Task<string> SaveFile(byte[] file)
        {
            var fileName = $"{Guid.NewGuid()}.jpg";
            await _storageService.SaveFileAsync(new MemoryStream(file), fileName);
            return fileName;
        }
    }
}
