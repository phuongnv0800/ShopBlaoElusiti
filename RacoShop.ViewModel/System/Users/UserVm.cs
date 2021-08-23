using RacoShop.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RacoShop.ViewModel.System.Users
{
    public class UserVm
    {
        public Guid Id { get; set; }

        [Display(Name ="Tên tài khoản")]
        public string UserName { get; set; }

        [Display(Name = "Tên")]
        public string FirstName { get; set; }

        [Display(Name = "Họ")]
        public string LastName { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string Avatar { get; set; }

        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        public IList<string> Roles { get; set; }
    }
}
