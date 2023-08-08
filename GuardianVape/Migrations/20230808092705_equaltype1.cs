using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class equaltype1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condition_EqualTypes_EqualTypeId",
                table: "Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_Condition_EqualTypes_EqualTypeId1",
                table: "Condition");

            migrationBuilder.DropIndex(
                name: "IX_Condition_EqualTypeId1",
                table: "Condition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EqualTypes",
                table: "EqualTypes");

            migrationBuilder.DropColumn(
                name: "EqualTypeId1",
                table: "Condition");

            migrationBuilder.RenameTable(
                name: "EqualTypes",
                newName: "EqualType");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EqualType",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "EqualType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EqualType",
                table: "EqualType",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Condition_EqualType_EqualTypeId",
                table: "Condition",
                column: "EqualTypeId",
                principalTable: "EqualType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condition_EqualType_EqualTypeId",
                table: "Condition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EqualType",
                table: "EqualType");

            migrationBuilder.RenameTable(
                name: "EqualType",
                newName: "EqualTypes");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "EqualTypes",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "EqualTypeId1",
                table: "Condition",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "EqualTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EqualTypes",
                table: "EqualTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_EqualTypeId1",
                table: "Condition",
                column: "EqualTypeId1");

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
    }
}
