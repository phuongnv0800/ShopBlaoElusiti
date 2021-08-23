using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RacoShop.BackendApi.Entities
{
    public class Product
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { set; get; }
        public int Quantity { get; set; }
        public int Rating { get; set; }
        public int RatingCount { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }

    }
}