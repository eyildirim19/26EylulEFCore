using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _9EfCoreMigration.Migrations
{
    /// <inheritdoc />
    public partial class katurunrel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KatID",
                table: "Urun",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urun_KatID",
                table: "Urun",
                column: "KatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori_KatID",
                table: "Urun",
                column: "KatID",
                principalTable: "Kategori",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kategori_KatID",
                table: "Urun");

            migrationBuilder.DropIndex(
                name: "IX_Urun_KatID",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "KatID",
                table: "Urun");
        }
    }
}
