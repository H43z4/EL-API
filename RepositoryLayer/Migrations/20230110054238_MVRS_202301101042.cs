using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class MVRS_202301101042 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturer",
                schema: "Setup",
                columns: table => new
                {
                    ManufacturerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ManufacturerProvince = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ManufacturerAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ManufacturerContactNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ManufacturerEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Setup",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ManufacturerId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalSchema: "Setup",
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId");
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalSchema: "Setup",
                        principalTable: "ProductType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                schema: "Setup",
                columns: table => new
                {
                    ProductSizeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSizeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductTypeId = table.Column<long>(type: "bigint", nullable: true),
                    QuantityInML = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductQtyforOneUnit = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.ProductSizeId);
                    table.ForeignKey(
                        name: "FK_ProductSize_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalSchema: "Setup",
                        principalTable: "ProductType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDetail",
                schema: "Setup",
                columns: table => new
                {
                    ProductDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    ManufacturerId = table.Column<long>(type: "bigint", nullable: true),
                    ProductTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ProductSizeId = table.Column<long>(type: "bigint", nullable: true),
                    ProductQuantity = table.Column<long>(type: "bigint", nullable: true),
                    ProductRetailPrice = table.Column<long>(type: "bigint", nullable: true),
                    ProductStrength = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ProductPriceEffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductVendFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.ProductDetailId);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalSchema: "Setup",
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId");
                    table.ForeignKey(
                        name: "FK_ProductDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Setup",
                        principalTable: "Product",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_ProductDetail_ProductSize_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalSchema: "Setup",
                        principalTable: "ProductSize",
                        principalColumn: "ProductSizeId");
                    table.ForeignKey(
                        name: "FK_ProductDetail_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalSchema: "Setup",
                        principalTable: "ProductType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManufacturerId",
                schema: "Setup",
                table: "Product",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                schema: "Setup",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ManufacturerId",
                schema: "Setup",
                table: "ProductDetail",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                schema: "Setup",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductSizeId",
                schema: "Setup",
                table: "ProductDetail",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductTypeId",
                schema: "Setup",
                table: "ProductDetail",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductTypeId",
                schema: "Setup",
                table: "ProductSize",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetail",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "ProductSize",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Manufacturer",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "ProductType",
                schema: "Setup");
        }
    }
}
