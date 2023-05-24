using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class move_id_base : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "GUID",
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

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FristName",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FristName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Vendor",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Variant",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "User",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Unit",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "TimeLine",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Tag",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ShopLocation",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "SearchEnginListing",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "RelatedTag",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductVariants",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductTags",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ProductCollections",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Product",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Phone",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "OrderProduct",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Order",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Media",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Inventory",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Customer",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Country",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ConditionType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ConditionRoleType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "ConditionRole",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Collection",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "CategoryGroup",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Category",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Body",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUID",
                table: "Address",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);
        }
    }
}
