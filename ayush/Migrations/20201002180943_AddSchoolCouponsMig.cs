using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class AddSchoolCouponsMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolCoupons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolID = table.Column<string>(type: "varchar(max)", nullable: true),
                    NumberOfCoupons = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "Date", nullable: false),
                    CouponNumber = table.Column<string>(type: "varchar(max)", nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolCoupons", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
