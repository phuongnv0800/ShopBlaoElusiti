﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacoShop.ViewModel.Catalog
{
    public class CartVm
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { set; get; }

        public decimal Price { set; get; }
        public decimal SubTotal { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
