using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class sessiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSlots_Slots_SlotId",
                table: "StudentSlots");

            migrationBuilder.DropIndex(
                name: "IX_StudentSlots_SlotId",
                table: "StudentSlots");

            migrationBuilder.DropColumn(
                name: "SlotId",
                table: "StudentSlots");

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentSlotId = table.Column<int>(nullable: false),
                    SlotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sessions_StudentSlots_StudentSlotId",
                        column: x => x.StudentSlotId,
                        principalTable: "StudentSlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_SlotId",
                table: "Sessions",
                column: "SlotId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_StudentSlotId",
                table: "Sessions",
                column: "StudentSlotId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.AddColumn<int>(
                name: "SlotId",
                table: "StudentSlots",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSlots_SlotId",
                table: "StudentSlots",
                column: "SlotId",
                unique: true,
                filter: "[SlotId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSlots_Slots_SlotId",
                table: "StudentSlots",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
