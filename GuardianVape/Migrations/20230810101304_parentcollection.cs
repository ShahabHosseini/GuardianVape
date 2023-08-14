using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class parentcollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Collection",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collection_ParentId",
                table: "Collection",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Collection_ParentId",
                table: "Collection",
                column: "ParentId",
                principalTable: "Collection",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_Collection_ParentId",
                table: "Collection");

            migrationBuilder.DropIndex(
                name: "IX_Collection_ParentId",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Collection");
        }
    }
}
