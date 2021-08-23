using RacoShop.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacoShop.ViewModel.Catalog
{
    public class OrderVm
    {
        public Guid UserId { get; set; }
        public int Id { set; get; }
        public DateTime DateCreated { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipPhone { set; get; }
        public OrderStatus Status { set; get; }

        public List<OrderList> OrderLists { get; set; }
    }
}
