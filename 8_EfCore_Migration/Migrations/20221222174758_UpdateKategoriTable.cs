using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8EfCoreMigration.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKategoriTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UstKatId",
                table: "Kategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UstKatId",
                table: "Kategoris");
        }
    }
}
