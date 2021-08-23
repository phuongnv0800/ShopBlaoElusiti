using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using RacoShop.BackendApi.EF;
using RacoShop.ViewModel.Common;
using RacoShop.Utilities.Exceptions;
using RacoShop.BackendApi.Service.Common;
using RacoShop.ViewModel.Catalog;
using RacoShop.BackendApi.Entities;
using System.Text;
using System.Net.Http.Headers;
using RacoShop.Utilities.Constants;

namespace RacoShop.BackendApi.Service.Catalog
{
    public class ProductService : IProductService
    {
        private readonly ShopDbContext _context;
        private readonly IStorageService _storageService;

        public ProductService(ShopDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> Create(ProductRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                Name = request.Name,
                Description = request.Description,
                Quantity = request.Quantity,
            };

            if (request.ImageByte != null)
            {
                product.ImagePath = await SaveFile(request.ImageByte);
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<int> Update(ProductRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null)
                throw new RacoShopException($"Can't not find product with Id: {request.Id}");
            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;
            product.Quantity = request.Quantity;
            if (request.ImageByte != null)
            {
                await _storageService.DeleteFileAsync(product.ImagePath);
                product.ImagePath = await SaveFile(request.ImageByte);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
                throw new RacoShopException($"Can't not find product {productId}");
            await _storageService.DeleteFileAsync(product.ImagePath);
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<ProductVm> GetById(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            var category = await _context.Categories.FindAsync(product.CategoryId);
            if (product == null)
                throw new RacoShopException($"Can't not find product with Id: {productId}");

            var productVm = new ProductVm()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
                CategoryName = category.Name,
                ImagePath = SystemConstants.BaseUrlImage + product.ImagePath,
            };
            return productVm;
        }

        public async Task<PagedList<ProductVm>> GetAllPaging(PagingRequest request)
        {
            var query = from p in _context.Products join c in _context.Categories on p.CategoryId equals c.Id select new { p, c };
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.p.Name.Contains(request.Keyword));
            int totalRow = await query.CountAsync();
            var data = await query
                .Select(x => new ProductVm()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    Price = x.p.Price,
                    Description = x.p.Description,
                    ImagePath = SystemConstants.BaseUrlImage + x.p.ImagePath,
                    CategoryId = x.p.CategoryId,
                    CategoryName =x.c.Name,
                    Quantity = x.p.Quantity
                })
                .OrderBy(x=>x.Id)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();
            // select
            var pagedResult = new PagedList<ProductVm>()
            {
                MetaData = new MetaData()
                {
                    TotalCount = totalRow,
                    PageSize = request.PageSize,
                    CurrentPage = request.PageNumber,
                    TotalPages = (int)Math.Ceiling((double)totalRow / request.PageSize),
                },
                Items = data,
            };
            return pagedResult;
        }

        public async Task<PagedList<ProductVm>> GetAllByCategoryId(int categoryId, PagingRequest request)
        {
            var query = from p in _context.Products join c in _context.Categories on p.CategoryId equals c.Id select new { p, c };
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.p.Name.Contains(request.Keyword));
            //filter de tim kiem
            if (categoryId != 0)
                query = query.Where(x => x.p.CategoryId == categoryId);

            //paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductVm()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    Price = x.p.Price,
                    Description = x.p.Description,
                    ImagePath = SystemConstants.BaseUrlImage + x.p.ImagePath,
                    CategoryId = x.p.CategoryId,
                    CategoryName = x.c.Name,
                    Quantity = x.p.Quantity
                })
                .OrderBy(x => x.Id)
                .AsSplitQuery()
                .ToListAsync();
            // select
            var pagedResult = new PagedList<ProductVm>()
            {
                MetaData = new MetaData()
                {
                    TotalCount = totalRow,
                    PageSize = request.PageSize,
                    CurrentPage = request.PageNumber,
                    TotalPages = (int)Math.Ceiling((double)totalRow / request.PageSize),
                },
                Items = data,
            };
            return pagedResult;
        }

        public async Task<bool> CategoryAssign(int id, int categoryId)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return false;
            }
            product.CategoryId = categoryId;
            await _context.SaveChangesAsync();

            return true;
        }

        private async Task<string> SaveFile(byte[] file)
        {
            var fileName = $"{Guid.NewGuid()}.jpg";
            await _storageService.SaveFileAsync(new MemoryStream(file), fileName);
            return fileName;
        }
    }
}
