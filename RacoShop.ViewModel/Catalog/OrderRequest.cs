using RacoShop.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacoShop.ViewModel.Catalog
{
    public class OrderRequest
    {
        public Guid UserId { get; set; }
        public int Id { set; get; }
        [Required(ErrorMessage ="Nhập thông tin người nhận")]
        public string ShipName { set; get; }

        [Required(ErrorMessage = "Nhập địa chỉ người nhận")]
        public string ShipAddress { set; get; }

        [Required(ErrorMessage = "Nhập số điện thoại")]
        public string ShipPhone { set; get; }
        public OrderStatus Status { set; get; } = OrderStatus.InProgress;
    }
}
