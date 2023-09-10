using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class wrewr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCode",
                table: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Iso",
                table: "Country",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Iso3",
                table: "Country",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nicename",
                table: "Country",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Numcode",
                table: "Country",
                type: "int",
                maxLength: 6,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phonecode",
                table: "Country",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iso",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Iso3",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Nicename",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Numcode",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Phonecode",
                table: "Country");

            migrationBuilder.AddColumn<string>(
                name: "AreaCode",
                table: "Country",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
