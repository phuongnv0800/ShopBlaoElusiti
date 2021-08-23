using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RacoShop.BackendApi.Migrations
{
    public partial class updateBase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("715fb82a-706c-47a0-8502-0cd8ca6d2192"), "f86db1e7-6d02-408b-82ac-dd3cf8165000", "Quản trị viên", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ba1575dc-3173-4ad3-af8e-d4b995d383cd"), "61cb6783-1ee1-47b1-83a7-3b5bb50065d4", "Khách hàng", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1603f9e2-212c-4342-9d2c-30963cb3f5ff"), 0, null, null, "ffa46559-8a7f-46b5-9a94-2c2f61473c0b", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng08@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG08@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEAKyjAsKuaCZCk9ZwDpyWpF0xe2xmLUwSVq7Mjun34cVKGkUAFmMWCn85wqOMiyCGw==", null, false, "1e29f5b9-b559-4558-ae64-c5eb781ee7d4", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("edf75882-6030-46e7-a664-cf1c583a6d35"), 0, null, null, "7af94f75-f077-4643-9b54-131cf7697f51", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng081@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG081@GMAIL.COM", "ADMIN1", "AQAAAAEAACcQAAAAEBdOQkZivt6pmCGH5MA1boIQHnk+FGn137rIhr9OsPs5zbYXlx2fL2TZmsDpei2Syw==", null, false, "5083cff5-02bf-4e00-89b3-9108b0883768", false, "admin1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("563c701e-3607-4939-9386-99c3cf505f9a"), 0, null, null, "9c451185-a260-4116-bd56-638de6304d2e", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng082@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG082@GMAIL.COM", "ADMIN2", "AQAAAAEAACcQAAAAEFf5VOuaUxuWEt9Fap8SejUjs5cNVUXasFAKmZfm4lAAQB5dP7MbCkqTuXQMcGMwsw==", null, false, "d48833a1-4b3d-4cb7-a123-4c0c905444b1", false, "admin2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cf4af71a-e43f-4939-b3cb-393726484351"), 0, null, null, "cfbead22-ac9d-4f94-a6a5-476730dc04a3", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng083@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG083@GMAIL.COM", "ADMIN3", "AQAAAAEAACcQAAAAEMfQYUGBoNRnbQfCtJj+TNdQWc9iutmcL56y+90IOGSu68HzzVmmOzhx+BnYgT2o+g==", null, false, "e9e166b2-7d5f-4953-9dbf-659cd110f8b9", false, "admin3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("df077755-5e69-4cef-a8a3-68f47a5d6b92"), 0, null, null, "b870dfd4-68d9-43a5-b0d7-b56413af1c92", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng084@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG084@GMAIL.COM", "ADMIN4", "AQAAAAEAACcQAAAAEK3OVCnOkqgBeCuWygyU/gQ+Q24aN+XsipwS6OqIIMCP2cSYcDfald+oi9QwUDJmhg==", null, false, "2700d4ab-9128-40d7-a3ee-3048bf1fa1e3", false, "admin4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("dd39a0d2-37a3-4ad3-9de0-97731020bb4d"), 0, null, null, "ad4d2905-d00b-49bf-b7e4-c69386d9d85a", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng085@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG085@GMAIL.COM", "ADMIN5", "AQAAAAEAACcQAAAAEAvTSx9XrNMQGj8wRC0eTqQEnk6g//AwH6Yyk7QbfleOTYPU73B88vOOCTEgbmJHDw==", null, false, "d4600b8e-917b-4e4e-8def-c0c804f0075a", false, "admin5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("63b37c25-4902-4f70-bee2-b2b7ad4cb892"), 0, null, null, "e8c7ee25-179c-40da-9473-c0da76b32588", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng086@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG086@GMAIL.COM", "ADMIN6", "AQAAAAEAACcQAAAAEEBhY+GOGbuAa5JV68h8VWdC/Zl+LTWKmUGDZybbau4QlhPzIG3q2lk0wtskN29DIQ==", null, false, "88277ddb-8b3b-4bf0-9c73-f8d78a87f14c", false, "admin6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7a49b107-6c2b-4d0a-b726-5f8094ef801f"), 0, null, null, "8590d378-89f4-4c68-9b91-bae5cf3aa6dd", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng087@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG087@GMAIL.COM", "ADMIN7", "AQAAAAEAACcQAAAAECOti41TIHyhmauaGKwOHAHo2KnJ5VZVzY3ujs2b7kUvDZvDzj/EXPtxfsN9GjrOPA==", null, false, "d080a4c3-573d-41f3-8f79-12c83bc1e32e", false, "admin7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4e07bb3d-7839-48bb-9299-dc7b5a0921ab"), 0, null, null, "17df9d25-e7c7-4538-ab0b-960569e1f5bb", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng088@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG088@GMAIL.COM", "ADMIN8", "AQAAAAEAACcQAAAAEGO9H5xrmm1oe0+0dTt8yEkpDHGbrpLtpUdsSrfFCf100C/AM16WwAM9rQj2fzwRTQ==", null, false, "5e17faf1-4497-4d0b-a412-0456a202bc6b", false, "admin8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cf5645f5-0d8c-4454-b77f-a95d0afa0255"), 0, null, null, "37568ea6-a741-4f76-bc03-546ab3900e32", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng089@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG089@GMAIL.COM", "ADMIN9", "AQAAAAEAACcQAAAAECubhxroCpDUXvS8JeTG5hmaHWMbSRiR8IVcZxipzQfaIxf1VSL3+0V/YyTp5p9LvQ==", null, false, "d0a59fe1-fe47-4e70-92f0-57bf54886cc2", false, "admin9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0764f8cd-f9ab-4045-8bef-f2378964a320"), 0, null, null, "1d731f76-5b55-4a11-a463-0279ee564e96", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng080@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG080@GMAIL.COM", "ADMIN0", "AQAAAAEAACcQAAAAEK86bOnbc8Y2YFFY5fyltiz3J2vvBUVxPgNCkBHVC9DlngjVA2PCm82NfxEi+38OdA==", null, false, "ab772e94-89aa-4fd9-8b4a-ff059c2cb66f", false, "admin0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3250cfdc-6f22-4c8f-b5f0-aeff85e417a5"), 0, null, null, "bdb36f7b-0c66-460e-8dfd-d4043fb6c2db", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng0801@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG0801@GMAIL.COM", "ADMIN01", "AQAAAAEAACcQAAAAEJ7hoH3aXORcu2YS5Jg3jApflAJUMv24fzpkysaSkCKx/hBVIQVYERYOprDDEvNTkw==", null, false, "5ca879a9-eb8b-40ad-9391-33c426d303b3", false, "admin01" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Smartphone" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Laptop" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("715fb82a-706c-47a0-8502-0cd8ca6d2192"), new Guid("1603f9e2-212c-4342-9d2c-30963cb3f5ff") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 16, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Ronstring", 625m, 22, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 15, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Zontrax", 996m, 18, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 13, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Konklab", 704m, 13, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 9, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Rank", 599m, 85, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 7, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Overhold", 976m, 33, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 6, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Transcof", 840m, 12, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 1, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Tempsoft", 601m, 52, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 20, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Keylex", 893m, 29, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 17, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Alpha", 591m, 23, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 19, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Fintone", 820m, 18, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 12, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Sonair", 667m, 29, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 11, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Zamit", 652m, 21, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 10, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Trippledex", 634m, 79, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 8, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Zontrax", 558m, 93, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 5, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Konklux", 982m, 12, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 4, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Otcom", 852m, 6, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 3, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Cardguard", 930m, 41, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 2, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Alphazap", 980m, 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 14, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Transcof", 601m, 30, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImagePath", "Name", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { 18, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", 0, "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Voltsillam", 594m, 11, 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ba1575dc-3173-4ad3-af8e-d4b995d383cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("715fb82a-706c-47a0-8502-0cd8ca6d2192"), new Guid("1603f9e2-212c-4342-9d2c-30963cb3f5ff") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0764f8cd-f9ab-4045-8bef-f2378964a320"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3250cfdc-6f22-4c8f-b5f0-aeff85e417a5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e07bb3d-7839-48bb-9299-dc7b5a0921ab"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("563c701e-3607-4939-9386-99c3cf505f9a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("63b37c25-4902-4f70-bee2-b2b7ad4cb892"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a49b107-6c2b-4d0a-b726-5f8094ef801f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf4af71a-e43f-4939-b3cb-393726484351"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf5645f5-0d8c-4454-b77f-a95d0afa0255"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dd39a0d2-37a3-4ad3-9de0-97731020bb4d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("df077755-5e69-4cef-a8a3-68f47a5d6b92"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("edf75882-6030-46e7-a664-cf1c583a6d35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("715fb82a-706c-47a0-8502-0cd8ca6d2192"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1603f9e2-212c-4342-9d2c-30963cb3f5ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
