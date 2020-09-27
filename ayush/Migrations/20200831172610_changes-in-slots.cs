using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class changesinslots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Slots");

            migrationBuilder.AddColumn<string>(
                name: "BaseUserId",
                table: "Slots",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BaseUserId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Slots_BaseUserId",
                table: "Slots",
                column: "BaseUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_BaseUserId",
                table: "Sessions",
                column: "BaseUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_AspNetUsers_BaseUserId",
                table: "Sessions",
                column: "BaseUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_AspNetUsers_BaseUserId",
                table: "Slots",
                column: "BaseUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_AspNetUsers_BaseUserId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_AspNetUsers_BaseUserId",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_Slots_BaseUserId",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_BaseUserId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "BaseUserId",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "BaseUserId",
                table: "Sessions");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Slots",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
