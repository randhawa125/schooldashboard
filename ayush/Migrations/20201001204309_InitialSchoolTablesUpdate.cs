using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class InitialSchoolTablesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CareerPathOne1",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathOne2",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathOne3",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathOne4",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathOne5",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathThree1",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathThree2",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathThree3",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathThree4",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathThree5",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathTwo1",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathTwo2",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathTwo3",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathTwo4",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerPathTwo5",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AddSchoolInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolID = table.Column<string>(type: "varchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "varchar(max)", nullable: false),
                    Address = table.Column<string>(type: "varchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(max)", nullable: false),
                    Email = table.Column<string>(type: "varchar(max)", nullable: false),
                    Name_POC = table.Column<string>(type: "varchar(max)", nullable: false),
                    PhoneNumber_POC = table.Column<string>(type: "varchar(max)", nullable: false),
                    Email_POC = table.Column<string>(type: "varchar(max)", nullable: false),
                    Address_POC = table.Column<string>(type: "varchar(max)", nullable: false),
                    HighQualification_POC = table.Column<string>(type: "varchar(max)", nullable: false),
                    Designation_POC = table.Column<string>(type: "varchar(max)", nullable: false),
                    UploadCertifications_POC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadCv_POC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Password = table.Column<string>(type: "varchar(15)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(15)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddSchoolInfos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CaseStudy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseTitle = table.Column<string>(nullable: true),
                    CaseDescription = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    UploadedOn = table.Column<DateTime>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    UploadedByStudent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStudy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RewardsRegister",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    RegisteredUserEmail = table.Column<string>(nullable: true),
                    RewardPoints = table.Column<int>(nullable: true),
                    RewardDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardsRegister", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
