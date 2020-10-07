using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class @new : Migration
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
            migrationBuilder.DropTable(
                name: "CaseStudy");

            migrationBuilder.DropTable(
                name: "RewardsRegister");

            migrationBuilder.DropColumn(
                name: "CareerPathOne1",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathOne2",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathOne3",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathOne4",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathOne5",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathThree1",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathThree2",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathThree3",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathThree4",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathThree5",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathTwo1",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathTwo2",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathTwo3",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathTwo4",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "CareerPathTwo5",
                table: "UserInformation");
        }
    }
}
