using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class frist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Body",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    BodyText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<byte[]>(type: "binary(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Body", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryGroup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Collection",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    PageTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Media = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collection", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Collection_Collection1",
                        column: x => x.ParentID,
                        principalTable: "Collection",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ConditionRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionRole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConditionType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    AreaCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SearchEnginListing",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    PageTitle = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    URLHandle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchEnginListing", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tag_Tag",
                        column: x => x.ParentID,
                        principalTable: "Tag",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Variant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ColorID = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<byte[]>(type: "binary(50)", fixedLength: true, maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryGroupID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Category_CategoryGroup",
                        column: x => x.CategoryGroupID,
                        principalTable: "CategoryGroup",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    FristName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    House = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PhoneID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address1", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Address1_Address1",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ConditionRoleType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ConditionRoleID = table.Column<int>(type: "int", nullable: true),
                    ConditionTypeID = table.Column<int>(type: "int", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: true),
                    ProductTypeID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    TagID = table.Column<int>(type: "int", nullable: true),
                    CollectionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionRoleType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConditionRoleType_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConditionRoleType_Collection",
                        column: x => x.CollectionID,
                        principalTable: "Collection",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConditionRoleType_ConditionRole",
                        column: x => x.ConditionRoleID,
                        principalTable: "ConditionRole",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConditionRoleType_ConditionType",
                        column: x => x.ConditionTypeID,
                        principalTable: "ConditionType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConditionRoleType_ProductType",
                        column: x => x.ProductTypeID,
                        principalTable: "ProductType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConditionRoleType_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConditionRoleType_Vendor",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    CompareatPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    CostPerItem = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    TrackQuantity = table.Column<bool>(type: "bit", nullable: false),
                    ShopLocation = table.Column<int>(type: "int", nullable: true),
                    UnitID = table.Column<int>(type: "int", nullable: false),
                    ProductTypeID = table.Column<int>(type: "int", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    SearchEnginListingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_ProductType",
                        column: x => x.ProductTypeID,
                        principalTable: "ProductType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_SearchEnginListing",
                        column: x => x.SearchEnginListingID,
                        principalTable: "SearchEnginListing",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_Unit",
                        column: x => x.UnitID,
                        principalTable: "Unit",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_Vendor",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    FristName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Language = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneID = table.Column<int>(type: "int", nullable: true),
                    AgreedEmail = table.Column<bool>(type: "bit", nullable: true),
                    AgreedSMS = table.Column<bool>(type: "bit", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_Address",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Customer_Customer",
                        column: x => x.PhoneID,
                        principalTable: "Phone",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShopLocationID = table.Column<int>(type: "int", nullable: true),
                    TrackQuantity = table.Column<bool>(type: "bit", nullable: true),
                    ContinueSellingOutOfStock = table.Column<bool>(type: "bit", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inventory_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Value = table.Column<byte[]>(type: "binary(50)", fixedLength: true, maxLength: 50, nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    CollectionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Media_Collection",
                        column: x => x.CollectionID,
                        principalTable: "Collection",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Media_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductCollections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    CollectionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCollections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCollections_Collection",
                        column: x => x.CollectionID,
                        principalTable: "Collection",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCollections_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    TagID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductTags_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductTags_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    VariantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductVariants_Variant",
                        column: x => x.VariantID,
                        principalTable: "Variant",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RelatedTag",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    CostumerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedTag", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RelatedTag_Customer",
                        column: x => x.CostumerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RelatedTag_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TimeLine",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    TimelineTypeID = table.Column<int>(type: "int", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BodyID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLine", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeLine_Body",
                        column: x => x.BodyID,
                        principalTable: "Body",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TimeLine_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TimeLine_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ShopLocation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Committed = table.Column<int>(type: "int", nullable: true),
                    Available = table.Column<int>(type: "int", nullable: true),
                    OnHand = table.Column<int>(type: "int", nullable: true),
                    InventoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopLocation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShopLocation_Product",
                        column: x => x.InventoryID,
                        principalTable: "Inventory",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    PaymentStatusID = table.Column<int>(type: "int", nullable: true),
                    FulfillmentStatusID = table.Column<int>(type: "int", nullable: true),
                    Items = table.Column<int>(type: "int", nullable: true),
                    DeliveryMethodID = table.Column<int>(type: "int", nullable: true),
                    OrderProductID = table.Column<int>(type: "int", nullable: true),
                    ShippingAddress = table.Column<int>(type: "int", nullable: true),
                    BillingAddress = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Order",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderProduct_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryID",
                table: "Address",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryGroupID",
                table: "Category",
                column: "CategoryGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Collection_ParentID",
                table: "Collection",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionRoleType_CategoryID",
                table: "ConditionRoleType",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionRoleType_CollectionID",
                table: "ConditionRoleType",
                column: "CollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionRoleType_ConditionRoleID",
                table: "ConditionRoleType",
                column: "ConditionRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionRoleType_ConditionTypeID",
                table: "ConditionRoleType",
                column: "ConditionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionRoleType_ProductTypeID",
                table: "ConditionRoleType",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionRoleType_TagID",
                table: "ConditionRoleType",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionRoleType_VendorID",
                table: "ConditionRoleType",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressID",
                table: "Customer",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PhoneID",
                table: "Customer",
                column: "PhoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductID",
                table: "Inventory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_CollectionID",
                table: "Media",
                column: "CollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ProductID",
                table: "Media",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderProductID",
                table: "Order",
                column: "OrderProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderID",
                table: "OrderProduct",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductID",
                table: "OrderProduct",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeID",
                table: "Product",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SearchEnginListingID",
                table: "Product",
                column: "SearchEnginListingID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UnitID",
                table: "Product",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorID",
                table: "Product",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollections_CollectionID",
                table: "ProductCollections",
                column: "CollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollections_ProductID",
                table: "ProductCollections",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductID",
                table: "ProductTags",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagID",
                table: "ProductTags",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductID",
                table: "ProductVariants",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_VariantID",
                table: "ProductVariants",
                column: "VariantID");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedTag_CostumerID",
                table: "RelatedTag",
                column: "CostumerID");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedTag_ProductID",
                table: "RelatedTag",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ShopLocation_InventoryID",
                table: "ShopLocation",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_ParentID",
                table: "Tag",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeLine_BodyID",
                table: "TimeLine",
                column: "BodyID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeLine_CustomerID",
                table: "TimeLine",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeLine_UserID",
                table: "TimeLine",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderProduct",
                table: "Order",
                column: "OrderProductID",
                principalTable: "OrderProduct",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address1_Address1",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_CategoryGroup",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductType",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Vendor",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Customer",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Product",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderProduct",
                table: "Order");

            migrationBuilder.DropTable(
                name: "ConditionRoleType");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "ProductCollections");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "RelatedTag");

            migrationBuilder.DropTable(
                name: "ShopLocation");

            migrationBuilder.DropTable(
                name: "TimeLine");

            migrationBuilder.DropTable(
                name: "ConditionRole");

            migrationBuilder.DropTable(
                name: "ConditionType");

            migrationBuilder.DropTable(
                name: "Collection");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Variant");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Body");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "CategoryGroup");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SearchEnginListing");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
