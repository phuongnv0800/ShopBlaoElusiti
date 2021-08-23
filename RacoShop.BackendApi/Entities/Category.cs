using System.Collections.Generic;

namespace RacoShop.BackendApi.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
