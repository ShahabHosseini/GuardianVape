using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class guid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_Collection1",
                table: "Collection");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionRoleType_Collection",
                table: "ConditionRoleType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionRoleType_ConditionRole",
                table: "ConditionRoleType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionRoleType_ConditionType",
                table: "ConditionRoleType");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_Collection",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_SearchEnginListing",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollections_Collection",
                table: "ProductCollections");

            migrationBuilder.DropIndex(
                name: "IX_Collection_ParentID",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "Media",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "Collection");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ConditionRole",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Vendor",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Variant",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "User",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Unit",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "TimeLine",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Tag",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ShopLocation",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "SearchEnginListing",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "RelatedTag",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductVariants",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductTags",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductCollections",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Product",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Phone",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "OrderProduct",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Order",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Media",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Inventory",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Customer",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Country",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ConditionType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ConditionType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ConditionRoleType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ConditionRole",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ConditionRole",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "ConditionRole",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Automated",
                table: "Collection",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Collection",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SearchEnginListingId",
                table: "Collection",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "imageId",
                table: "Collection",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "CategoryGroup",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Category",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Body",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Address",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllCondition = table.Column<bool>(type: "bit", nullable: false),
                    AnyCondition = table.Column<bool>(type: "bit", nullable: false),
                    CollectionId = table.Column<int>(type: "int", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Condition_Collection_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collection",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Condition_ConditionRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ConditionRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Condition_ConditionType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ConditionType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GvImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GvImage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CollectionId",
                table: "Product",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Collection_imageId",
                table: "Collection",
                column: "imageId");

            migrationBuilder.CreateIndex(
                name: "IX_Collection_SearchEnginListingId",
                table: "Collection",
                column: "SearchEnginListingId");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_CollectionId",
                table: "Condition",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_RoleId",
                table: "Condition",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_TypeId",
                table: "Condition",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_GvImage_imageId",
                table: "Collection",
                column: "imageId",
                principalTable: "GvImage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_SearchEnginListing_SearchEnginListingId",
                table: "Collection",
                column: "SearchEnginListingId",
                principalTable: "SearchEnginListing",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionRoleType_Collection_CollectionID",
                table: "ConditionRoleType",
                column: "CollectionID",
                principalTable: "Collection",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionRoleType_ConditionType_ConditionRoleID",
                table: "ConditionRoleType",
                column: "ConditionRoleID",
                principalTable: "ConditionType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionRoleType_ConditionType_ConditionTypeID",
                table: "ConditionRoleType",
                column: "ConditionTypeID",
                principalTable: "ConditionType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Collection_CollectionID",
                table: "Media",
                column: "CollectionID",
                principalTable: "Collection",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Collection_CollectionId",
                table: "Product",
                column: "CollectionId",
                principalTable: "Collection",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SearchEnginListing_SearchEnginListingID",
                table: "Product",
                column: "SearchEnginListingID",
                principalTable: "SearchEnginListing",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollections_Collection_CollectionID",
                table: "ProductCollections",
                column: "CollectionID",
                principalTable: "Collection",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_GvImage_imageId",
                table: "Collection");

            migrationBuilder.DropForeignKey(
                name: "FK_Collection_SearchEnginListing_SearchEnginListingId",
                table: "Collection");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionRoleType_Collection_CollectionID",
                table: "ConditionRoleType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionRoleType_ConditionType_ConditionRoleID",
                table: "ConditionRoleType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionRoleType_ConditionType_ConditionTypeID",
                table: "ConditionRoleType");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_Collection_CollectionID",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Collection_CollectionId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_SearchEnginListing_SearchEnginListingID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollections_Collection_CollectionID",
                table: "ProductCollections");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropTable(
                name: "GvImage");

            migrationBuilder.DropIndex(
                name: "IX_Product_CollectionId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Collection_imageId",
                table: "Collection");

            migrationBuilder.DropIndex(
                name: "IX_Collection_SearchEnginListingId",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Variant");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "TimeLine");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ShopLocation");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "SearchEnginListing");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "RelatedTag");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ProductCollections");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ConditionType");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ConditionRoleType");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "ConditionRole");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "ConditionRole");

            migrationBuilder.DropColumn(
                name: "Automated",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "SearchEnginListingId",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "imageId",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "CategoryGroup");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Body");

            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ConditionRole",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ConditionType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ConditionRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte[]>(
                name: "Media",
                table: "Collection",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentID",
                table: "Collection",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collection_ParentID",
                table: "Collection",
                column: "ParentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Collection1",
                table: "Collection",
                column: "ParentID",
                principalTable: "Collection",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionRoleType_Collection",
                table: "ConditionRoleType",
                column: "CollectionID",
                principalTable: "Collection",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionRoleType_ConditionRole",
                table: "ConditionRoleType",
                column: "ConditionRoleID",
                principalTable: "ConditionRole",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionRoleType_ConditionType",
                table: "ConditionRoleType",
                column: "ConditionTypeID",
                principalTable: "ConditionType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Collection",
                table: "Media",
                column: "CollectionID",
                principalTable: "Collection",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SearchEnginListing",
                table: "Product",
                column: "SearchEnginListingID",
                principalTable: "SearchEnginListing",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollections_Collection",
                table: "ProductCollections",
                column: "CollectionID",
                principalTable: "Collection",
                principalColumn: "ID");
        }
    }
}
