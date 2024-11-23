using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryOfVermundi.Migrations
{
    public partial class UpdateCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Entries_EntryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_EntryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "EntryId",
                table: "Categories");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_CategoryId",
                table: "Entries",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_Categories_CategoryId",
                table: "Entries",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_Categories_CategoryId",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_Entries_CategoryId",
                table: "Entries");

            migrationBuilder.AddColumn<int>(
                name: "EntryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_EntryId",
                table: "Categories",
                column: "EntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Entries_EntryId",
                table: "Categories",
                column: "EntryId",
                principalTable: "Entries",
                principalColumn: "EntryId");
        }
    }
}
