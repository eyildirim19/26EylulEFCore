using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _9EfCoreMigration.Migrations
{
    /// <inheritdoc />
    public partial class CreateIlTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // NOT : TAVSİYE ETMEMEKLE BİRLİKTE BU DOSYAYA MÜDAHELE EDEBİLİRİZ...
            migrationBuilder.CreateTable(
                name: "Il",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    //Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                    Adi = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Il", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Il");
        }
    }
}
