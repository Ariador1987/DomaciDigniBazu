using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aviation.WebAPI.Migrations
{
    public partial class InitialMigrationSeedDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "Split", "SPU" });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "Zagreb", "ZGPleso" });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 3, "Zadar", "ZAD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");
        }
    }
}
