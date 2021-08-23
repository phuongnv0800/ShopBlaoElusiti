using Microsoft.EntityFrameworkCore;
using RacoShop.BackendApi.EF;
using RacoShop.BackendApi.Entities;
using RacoShop.Utilities.Constants;
using RacoShop.ViewModel.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacoShop.BackendApi.Service.Catalog
{
    public class CartService : ICartService
    {
        private readonly ShopDbContext _context;

        public CartService(ShopDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CartVm>> Get(Guid userId)
        {
            var query = from c in _context.Carts join p in _context.Products
                        on c.ProductId equals p.Id where c.UserId == userId select new { c , p};
            var carts = await query.Select(x => new CartVm()
            {
                UserId = x.c.UserId,
                ProductId = x.c.ProductId,
                Price = x.c.Price,
                Name  =x.p.Name,
                ImagePath = SystemConstants.BaseUrlImage + x.p.ImagePath,
                Quantity = x.c.Quantity,
                SubTotal = x.c.SubTotal,
                DateCreated = x.c.DateCreated
            }).ToListAsync();
            return carts;
        }
        public async Task<IEnumerable<CartVm>> GetByUserName(string userName)
        {
            var query = from c in _context.Carts
                        join p in _context.Products on c.ProductId equals p.Id
                        join u in _context.Users on c.UserId equals u.Id
                        select new { c, p, u };
            var carts = await query.Where(y=>y.u.UserName.Equals(userName)).Select(x => new CartVm()
            {
                UserId = x.c.UserId,
                ProductId = x.c.ProductId,
                Price = x.c.Price,
                Name = x.p.Name,
                ImagePath = SystemConstants.BaseUrlImage + x.p.ImagePath,
                Quantity = x.c.Quantity,
                SubTotal = x.c.SubTotal,
                DateCreated = x.c.DateCreated
            }).ToListAsync();
            return carts;
        }
        public async Task<bool> Create(CartRequest request)
        {
            var product = await _context.Products.FindAsync(request.ProductId);

            var query = from c in _context.Carts where c.UserId == request.UserId && c.ProductId == request.ProductId select c;
            var cart = await query.Select(x => new Cart()
            {
                ProductId = x.ProductId,
                UserId = x.UserId,
                Price = x.Price,
                DateCreated = x.DateCreated,
                Quantity = x.Quantity,
                SubTotal = x.SubTotal,
            }).FirstOrDefaultAsync();
            if (cart != null)
            {
                cart.Quantity = request.Quantity;
                cart.SubTotal = request.Quantity * product.Price;
                _context.Update(cart);
            }
            else
            {
                Cart newCart = new Cart()
                {
                    ProductId = request.ProductId,
                    UserId = request.UserId,
                    Price = product.Price,
                    DateCreated = DateTime.Now,
                    Quantity = request.Quantity,
                    SubTotal = request.Quantity * product.Price,
                };
                await _context.Carts.AddAsync(newCart);
            }
            
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(Guid userId, int productId)
        {
            var query = from c in _context.Carts where c.UserId == userId && c.ProductId == productId select c;
            var cart = await query.Select(x => new Cart()
            {
                ProductId = x.ProductId,
                UserId = x.UserId,
                Price = x.Price,
                DateCreated = x.DateCreated,
                Quantity = x.Quantity,
                SubTotal = x.SubTotal,
            }).FirstOrDefaultAsync();
            if (cart == null)
                return true;
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
