using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condition_ConditionType_ConditionTypeId1",
                table: "Condition");

            migrationBuilder.DropIndex(
                name: "IX_Condition_ConditionTypeId",
                table: "Condition");

            migrationBuilder.DropIndex(
                name: "IX_Condition_ConditionTypeId1",
                table: "Condition");

            migrationBuilder.DropColumn(
                name: "ConditionTypeId1",
                table: "Condition");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_ConditionTypeId",
                table: "Condition",
                column: "ConditionTypeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Condition_ConditionTypeId",
                table: "Condition");

            migrationBuilder.AddColumn<int>(
                name: "ConditionTypeId1",
                table: "Condition",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Condition_ConditionTypeId",
                table: "Condition",
                column: "ConditionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_ConditionTypeId1",
                table: "Condition",
                column: "ConditionTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Condition_ConditionType_ConditionTypeId1",
                table: "Condition",
                column: "ConditionTypeId1",
                principalTable: "ConditionType",
                principalColumn: "ID");
        }
    }
}
