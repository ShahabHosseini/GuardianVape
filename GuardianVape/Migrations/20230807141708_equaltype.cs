using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class equaltype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condition_CollectionType_CollectionTypeId",
                table: "Condition");

            migrationBuilder.DropColumn(
                name: "EqualType",
                table: "Condition");

            migrationBuilder.AlterColumn<int>(
                name: "CollectionTypeId",
                table: "Condition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EqualTypeId",
                table: "Condition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EqualTypeId1",
                table: "Condition",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EqualTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GUID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqualTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Condition_EqualTypeId",
                table: "Condition",
                column: "EqualTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_EqualTypeId1",
                table: "Condition",
                column: "EqualTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Condition_CollectionType_CollectionTypeId",
                table: "Condition",
                column: "CollectionTypeId",
                principalTable: "CollectionType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Condition_EqualTypes_EqualTypeId",
                table: "Condition",
                column: "EqualTypeId",
                principalTable: "EqualTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Condition_EqualTypes_EqualTypeId1",
                table: "Condition",
                column: "EqualTypeId1",
                principalTable: "EqualTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condition_CollectionType_CollectionTypeId",
                table: "Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_Condition_EqualTypes_EqualTypeId",
                table: "Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_Condition_EqualTypes_EqualTypeId1",
                table: "Condition");

            migrationBuilder.DropTable(
                name: "EqualTypes");

            migrationBuilder.DropIndex(
                name: "IX_Condition_EqualTypeId",
                table: "Condition");

            migrationBuilder.DropIndex(
                name: "IX_Condition_EqualTypeId1",
                table: "Condition");

            migrationBuilder.DropColumn(
                name: "EqualTypeId",
                table: "Condition");

            migrationBuilder.DropColumn(
                name: "EqualTypeId1",
                table: "Condition");

            migrationBuilder.AlterColumn<int>(
                name: "CollectionTypeId",
                table: "Condition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EqualType",
                table: "Condition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Condition_CollectionType_CollectionTypeId",
                table: "Condition",
                column: "CollectionTypeId",
                principalTable: "CollectionType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
