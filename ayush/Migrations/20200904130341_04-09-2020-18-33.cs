using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class _040920201833 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Achievements",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BestVacation",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DifferentlyAbled",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElderorYounger",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpectationsFromUpclass",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyIncome",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyType",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteSubject",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grades",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowManyFriends",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowYourFriendsDescribeYou",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowYourParentsDecribeYou",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionOfResponsibility",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Siblings",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "UserInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyThisCareer",
                table: "UserInformation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achievements",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "BestVacation",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "DifferentlyAbled",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "ElderorYounger",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "ExpectationsFromUpclass",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "FamilyIncome",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "FamilyType",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "FavoriteSubject",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "Grades",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "HowManyFriends",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "HowYourFriendsDescribeYou",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "HowYourParentsDecribeYou",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "PositionOfResponsibility",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "Siblings",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "WhyThisCareer",
                table: "UserInformation");
        }
    }
}
