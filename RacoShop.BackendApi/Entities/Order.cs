using RacoShop.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace RacoShop.BackendApi.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime DateCreated { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipPhone { set; get; }
        public OrderStatus Status { set; get; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Guid UserId { set; get; }
        public AppUser AppUser { get; set; }
    }
}
