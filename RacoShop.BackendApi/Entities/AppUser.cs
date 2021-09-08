using Microsoft.AspNetCore.Identity;
using RacoShop.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace RacoShop.BackendApi.Entities
{
    public class AppUser : IdentityUser<Guid>
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public Gender Gender { get; set; } = Gender.Male;

        public string Address { get; set; }

        public string Avatar { get; set; }

        public ICollection<Cart> Carts { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
