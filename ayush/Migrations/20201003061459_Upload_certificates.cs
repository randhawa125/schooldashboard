using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class Upload_certificates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "schoolCertificates",
                columns: table => new
                {
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UploadCertifications_POC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadCv_POC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolCertificates", x => x.SchoolID);
                    table.ForeignKey(
                        name: "FK_schoolCertificates_AddSchoolInfos_ID",
                        column: x => x.ID,
                        principalTable: "AddSchoolInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_schoolCertificates_ID",
                table: "schoolCertificates",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
