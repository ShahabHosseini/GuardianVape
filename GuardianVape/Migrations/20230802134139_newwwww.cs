using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newwwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_Image_ImageId",
                table: "Collection");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "Collection",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Image_ImageId",
                table: "Collection",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_Image_ImageId",
                table: "Collection");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "Collection",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Image_ImageId",
                table: "Collection",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
