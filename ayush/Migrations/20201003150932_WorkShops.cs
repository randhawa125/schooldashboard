using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class WorkShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workShops",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "varchar(max)", nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workShops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "workShopsImngs",
                columns: table => new
                {
                    ImgID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workShopsImngs", x => x.ImgID);
                    table.ForeignKey(
                        name: "FK_workShopsImngs_workShops_ID",
                        column: x => x.ID,
                        principalTable: "workShops",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_workShopsImngs_ID",
                table: "workShopsImngs",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
