using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using RacoShop.BackendApi.Entities;

namespace RacoShop.BackendApi.Extensions
{
    public static class ShopDbContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //data seeding
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Smartphone"},
                new Category(){ Id= 2, Name = "Laptop"});
            modelBuilder.Entity<Product>().HasData(
                new Product(){
                Id = 1,
                Name = "Tempsoft",
                Price = 601,
                Quantity = 52,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 2,
                Name = "Alphazap",
                Price = 980,
                Quantity = 2,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 3,
                Name = "Cardguard",
                Price = 930,
                Quantity = 41,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 4,
                Name = "Otcom",
                Price = 852,
                Quantity = 6,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 5,
                Name = "Konklux",
                Price = 982,
                Quantity = 12,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 6,
                Name = "Transcof",
                Price = 840,
                Quantity = 12,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 7,
                Name = "Overhold",
                Price = 976,
                Quantity = 33,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 8,
                Name = "Zontrax",
                Price = 558,
                Quantity = 93,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 9,
                Name = "Rank",
                Price = 599,
                Quantity = 85,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 10,
                Name = "Trippledex",
                Price = 634,
                Quantity = 79,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 11,
                Name = "Zamit",
                Price = 652,
                Quantity = 21,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 12,
                Name = "Sonair",
                Price = 667,
                Quantity = 29,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 13,
                Name = "Konklab",
                Price = 704,
                Quantity = 13,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 14,
                Name = "Transcof",
                Price = 601,
                Quantity = 30,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 15,
                Name = "Zontrax",
                Price = 996,
                Quantity = 18,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 16,
                Name = "Ronstring",
                Price = 625,
                Quantity = 22,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 17,
                Name = "Alpha",
                Price = 591,
                Quantity = 23,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 18,
                Name = "Voltsillam",
                Price = 594,
                Quantity = 11,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 2,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 19,
                Name = "Fintone",
                Price = 820,
                Quantity = 18,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                },new Product() {
                Id = 20,
                Name = "Keylex",
                Price = 893,
                Quantity = 29,
                Description = "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.",
                CategoryId = 1,
                ImagePath = "b4985220-01b3-4701-a978-a8ba2b55b271.jpg"
                }
               );

            var roleId = Guid.NewGuid();
            var roleAdmin = Guid.NewGuid();
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = roleId,
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    Description = "Quản trị viên"
                },
                new AppRole()
                {
                    Id = Guid.NewGuid(),
                    Name = "customer",
                    NormalizedName = "CUSTOMER",
                    Description = "Khách hàng",
                }
            );

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = roleAdmin,
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "owlsng08@gmail.com",
                    NormalizedEmail = "OWLSNG08@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000,8,17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin1",
                    NormalizedUserName = "ADMIN1",
                    Email = "owlsng081@gmail.com",
                    NormalizedEmail = "OWLSNG081@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin2",
                    NormalizedUserName = "ADMIN2",
                    Email = "owlsng082@gmail.com",
                    NormalizedEmail = "OWLSNG082@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin3",
                    NormalizedUserName = "ADMIN3",
                    Email = "owlsng083@gmail.com",
                    NormalizedEmail = "OWLSNG083@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin4",
                    NormalizedUserName = "ADMIN4",
                    Email = "owlsng084@gmail.com",
                    NormalizedEmail = "OWLSNG084@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin5",
                    NormalizedUserName = "ADMIN5",
                    Email = "owlsng085@gmail.com",
                    NormalizedEmail = "OWLSNG085@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin6",
                    NormalizedUserName = "ADMIN6",
                    Email = "owlsng086@gmail.com",
                    NormalizedEmail = "OWLSNG086@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin7",
                    NormalizedUserName = "ADMIN7",
                    Email = "owlsng087@gmail.com",
                    NormalizedEmail = "OWLSNG087@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin8",
                    NormalizedUserName = "ADMIN8",
                    Email = "owlsng088@gmail.com",
                    NormalizedEmail = "OWLSNG088@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin9",
                    NormalizedUserName = "ADMIN9",
                    Email = "owlsng089@gmail.com",
                    NormalizedEmail = "OWLSNG089@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin0",
                    NormalizedUserName = "ADMIN0",
                    Email = "owlsng080@gmail.com",
                    NormalizedEmail = "OWLSNG080@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                },
                new AppUser
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin01",
                    NormalizedUserName = "ADMIN01",
                    Email = "owlsng0801@gmail.com",
                    NormalizedEmail = "OWLSNG0801@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Nguyễn",
                    LastName = "Phương",
                    Dob = new DateTime(2000, 8, 17),
                }
                );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = roleAdmin
            });
        }
    }
}
