using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RacoShop.BackendApi.Migrations
{
    public partial class fixdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Avatar = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ShipName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ShipAddress = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ShipPhone = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExternalTransactionId = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Provider = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.ProductId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("75971948-e4ab-438d-90dc-e0a12a2ef963"), "87420f5a-8ad9-4a3c-9191-5c8760103a34", "Quản trị viên", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("382f501a-ac76-4e8c-8be2-1db6fb46399b"), "c8302390-494a-4122-82a5-9c3d165034e8", "Khách hàng", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f0907e90-b340-40e6-a332-245082e9743d"), 0, null, null, "fb70f796-e90a-4dd0-a53c-eed19bebb8a0", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng08@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG08@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAECIEC/5dbQ6/wBZ4zs1lYjVlPAPlx2ZnaVv6jrQJ0Fs3vk0U8hpJG6dbUcn76h94DQ==", null, false, "a1ad29fc-e8ca-4676-a40a-2974f2cccaf6", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2174ac63-2de4-451a-83d6-9aaa58264b27"), 0, null, null, "357c6162-6793-428b-8491-9c68db708c25", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng081@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG081@GMAIL.COM", "ADMIN1", "AQAAAAEAACcQAAAAEM8nSyJTFAuLxc61bg8G8NxdjRBy22T6e8SIBXxvoakbBpnFpyCA34D+oZtFW7B2uQ==", null, false, "e6523b2a-7874-4b57-b27c-04e0ace268da", false, "admin1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("fefbe34c-9566-4e23-b82d-9f7529c535ae"), 0, null, null, "50283e90-1544-4205-9652-8ef52d3d182a", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng082@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG082@GMAIL.COM", "ADMIN2", "AQAAAAEAACcQAAAAEMNcTlYaH3Io6WocB3SvVZ2Gf5c/bO/rs6tY3PCYSiSRQxOtSCoYmT7o6Lgn+nhRWQ==", null, false, "16390e26-3b40-4cc2-a12f-a96d3f17f638", false, "admin2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9fc695c0-ea8d-454b-9967-9c4ef3cf5149"), 0, null, null, "f50e1520-de1b-4df4-98bc-507761ad414d", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng083@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG083@GMAIL.COM", "ADMIN3", "AQAAAAEAACcQAAAAEN6vHoRttreSkWLHILRUfTwgzyUq0aL6IzmpHEqw93U7xpVvJdFfohAJpDr9OBXz+A==", null, false, "7ca9c76e-d2e6-406d-b6c4-66db9cceb5e9", false, "admin3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2fecbc34-36ec-427c-83cf-94b733a4cb96"), 0, null, null, "8963d76e-66d8-4e05-9b27-30546a678544", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng084@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG084@GMAIL.COM", "ADMIN4", "AQAAAAEAACcQAAAAEERWlyeqoQiEZZpTh6yb2qUbrwXbHNKcf1OxumBHPWAA8mRLGYPtwCBHZhGxBb7O7g==", null, false, "1effb41d-f8a1-4a4c-8cfc-4bf458e2eb58", false, "admin4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("10bff2d1-30d6-46d1-9fc4-df30e49742ff"), 0, null, null, "e47e5ff8-27e1-459c-9942-214fe23ffa1a", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng085@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG085@GMAIL.COM", "ADMIN5", "AQAAAAEAACcQAAAAEC/+LIbShYQ1GDXHA+hHNeMefmxHCSESMEWzalOA2HVlY2CwIKedAyWR88QkXZsXdg==", null, false, "6482e53d-6e77-4a64-9583-9add4152cbe1", false, "admin5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6ef55ac3-30e4-4b4a-b7db-36e2781a02c3"), 0, null, null, "340fed0f-9470-41c1-85e8-b25d1fcc0a3a", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng086@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG086@GMAIL.COM", "ADMIN6", "AQAAAAEAACcQAAAAEKbGSWZm2sshQjKkIWIZPlcyk5m5VVlXFUGV9F00ppVWpV+gEu5h4ozrV35lXzMX+g==", null, false, "dc4ef5b5-4cad-4d7e-8553-397cb48c81c4", false, "admin6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("583e68ef-95f0-4fa0-ba2f-cc6ca3075f85"), 0, null, null, "a3d5a44b-5529-4ae8-a551-7eefe0ae634b", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng087@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG087@GMAIL.COM", "ADMIN7", "AQAAAAEAACcQAAAAEMI5QTDVRFvKSUpbZjf1OXDWsAYmZlumaTb7Sf4DJKCCBBCvd0DoxmB7z11O5/GE6Q==", null, false, "90f31348-2a4a-479b-8454-93e143d0aefa", false, "admin7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b083d252-1442-4508-8843-3c3145f99e9e"), 0, null, null, "5b7930ff-55a3-4f9e-80d0-d35231283da6", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng088@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG088@GMAIL.COM", "ADMIN8", "AQAAAAEAACcQAAAAEGZavtw3Ylfk/qs1dhXwaA0DBctdsv9WAL5+vRVI+vC5+aJDrIeiZ2LyHydNQ/2X2w==", null, false, "79e68e6c-e2a3-46a1-a466-3948800b627f", false, "admin8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("211ac06b-ccf9-4ea4-a0ab-06a781f47dc3"), 0, null, null, "80be04ca-76e2-449d-97e8-8ebcfd46eed6", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng089@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG089@GMAIL.COM", "ADMIN9", "AQAAAAEAACcQAAAAED0rZKTEuH6Lv77oAbNtvMu/+9BDN0S4vm815Kyu/G1SPBoTUq9ezgXCVr/FX3Cytg==", null, false, "b4e414ff-bd1a-445b-9564-b033cfc55d8b", false, "admin9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("54e91dcf-03d9-4fa5-8eed-29f45b2ef38a"), 0, null, null, "db870711-aca6-4831-853f-fa5a23774c99", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng080@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG080@GMAIL.COM", "ADMIN0", "AQAAAAEAACcQAAAAEIYOQGFOqvCgnWOYpTGf32Gz0wJ1Tr4UNN9WQKAnyQn/O2HNEqS+zmDLvh4trk5x0Q==", null, false, "9bf49a0d-7553-4545-9998-52f5dd07f8eb", false, "admin0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9bd54a23-16e2-4fdd-91f3-22df800d8a37"), 0, null, null, "25bffd8c-22c9-4a6c-bd93-41b7fa6ea80f", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "owlsng0801@gmail.com", true, "Nguyễn", 0, "Phương", false, null, "OWLSNG0801@GMAIL.COM", "ADMIN01", "AQAAAAEAACcQAAAAEM7cW69JmWUTbrAhctPRqZDPWVidf5AS2C3vqfLJTBS8i0Mvba9SNHLfULl4UmtlyA==", null, false, "61451126-1488-435b-9ef9-551a2581d6e5", false, "admin01" });

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
                values: new object[] { new Guid("75971948-e4ab-438d-90dc-e0a12a2ef963"), new Guid("f0907e90-b340-40e6-a332-245082e9743d") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 16, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Ronstring", 625m, 22 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 15, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Zontrax", 996m, 18 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 13, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Konklab", 704m, 13 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 9, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Rank", 599m, 85 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 7, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Overhold", 976m, 33 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 6, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Transcof", 840m, 12 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 1, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Tempsoft", 601m, 52 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 20, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Keylex", 893m, 29 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 17, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Alpha", 591m, 23 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 19, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Fintone", 820m, 18 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 12, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Sonair", 667m, 29 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 11, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Zamit", 652m, 21 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 10, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Trippledex", 634m, 79 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 8, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Zontrax", 558m, 93 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 5, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Konklux", 982m, 12 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 4, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Otcom", 852m, 6 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 3, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Cardguard", 930m, 41 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 2, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Alphazap", 980m, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 14, 1, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Transcof", 601m, 30 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[] { 18, 2, "Sản phẩm của bạn có cốt truyện đặc biệt đặc biệt đối với bạn không? Rất có thể nó sẽ đặc biệt đặc biệt và được khán giả yêu mến. Sử dụng câu chuyện đó trong mô tả sản phẩm của bạn để thêm nhiều tính cách cho mặt hàng của bạn, thu hút khán giả và thu phục trái tim và khối óc.", "b4985220-01b3-4701-a978-a8ba2b55b271.jpg", "Voltsillam", 594m, 11 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
