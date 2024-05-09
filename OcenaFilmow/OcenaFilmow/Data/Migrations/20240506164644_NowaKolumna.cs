using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OcenaFilmow.Migrations
{
    /// <inheritdoc />
    public partial class NowaKolumna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalRatings",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalRatings",
                table: "Movie");
        }
    }
}
