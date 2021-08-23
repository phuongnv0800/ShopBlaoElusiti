using Microsoft.AspNetCore.Http;

namespace RacoShop.ViewModel.Catalog
{
    public class ProductVm
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImagePath{ get; set; }
        public byte[] ImageByte { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}