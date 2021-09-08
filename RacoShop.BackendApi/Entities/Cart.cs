using System;

namespace RacoShop.BackendApi.Entities
{
    public class Cart
    {
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public decimal SubTotal { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { set; get; }
        public Product Product { get; set; }

        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
