using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryOfVermundi.Migrations
{
    public partial class AppUserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_AppUsers_ContributorAppUserId",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_Entries_ContributorAppUserId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "ContributorAppUserId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "ContributorId",
                table: "Entries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Protected",
                table: "Entries",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Entries_ContributorId",
                table: "Entries",
                column: "ContributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_AppUsers_ContributorId",
                table: "Entries",
                column: "ContributorId",
                principalTable: "AppUsers",
                principalColumn: "AppUserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_AppUsers_ContributorId",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_Entries_ContributorId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "ContributorId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Protected",
                table: "Entries");

            migrationBuilder.AddColumn<int>(
                name: "ContributorAppUserId",
                table: "Entries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_ContributorAppUserId",
                table: "Entries",
                column: "ContributorAppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_AppUsers_ContributorAppUserId",
                table: "Entries",
                column: "ContributorAppUserId",
                principalTable: "AppUsers",
                principalColumn: "AppUserId");
        }
    }
}
