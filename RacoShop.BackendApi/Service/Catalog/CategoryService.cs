using Microsoft.EntityFrameworkCore;
using RacoShop.BackendApi.EF;
using RacoShop.BackendApi.Entities;
using RacoShop.ViewModel.Catalog;
using System.Collections.Generic;
using System.Linq;// su dung ham john
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.Catalog
{
    public class CategoryService : ICategoryService
    {
        private readonly ShopDbContext _context;

        public CategoryService(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryVm>> GetAll()
        {
            var query = from c in _context.Categories select new { c };
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.c.Name
            }).ToListAsync();
        }

        public async Task<int> Create(string name)
        {
            var category = new Category()
            {
                Name = name,
            };
            _context.Categories.Add(category);

            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(int id, string name)
        {
            var category = await _context.Categories.FindAsync(id);

            category.Name = name;
            _context.Categories.Update(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }
    }
}
