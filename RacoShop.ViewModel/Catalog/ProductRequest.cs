using Microsoft.AspNetCore.Http;

namespace RacoShop.ViewModel.Catalog
{
    public class ProductRequest
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public byte[] ImageByte { get; set; }
        public IFormFile ImagePath { get; set; }
    }
}
