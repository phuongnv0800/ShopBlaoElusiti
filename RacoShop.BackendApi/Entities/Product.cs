using RacoShop.Utilities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RacoShop.BackendApi.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { set; get; }
        public int Quantity { get; set; }
        public float Rating { get; set; }
        public int RatingCount { get; set; }
        public int Discount { get; set; }
        public ProductColor ProductColor { get; set; }
        public ProductMovement ProductMovement { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category{ get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Cart> Carts { get; set; }

    }
}