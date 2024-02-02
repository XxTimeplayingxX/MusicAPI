using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicAPI.Migrations
{
    /// <inheritdoc />
    public partial class Song_DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "Duration", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "3:00", "English", "Data Seed1" },
                    { 2, "2:30", "English", "Data Seed2" },
                    { 3, "3:50", "Spanish", "Data Seed3" },
                    { 4, "7:00", "Spanish", "Data Seed4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
