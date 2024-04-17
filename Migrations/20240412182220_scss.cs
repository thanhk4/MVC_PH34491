using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_PH34491.Migrations
{
    /// <inheritdoc />
    public partial class scss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DongVats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThucAn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongVats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    IdDV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DongVatId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cas_DongVats_DongVatId",
                        column: x => x.DongVatId,
                        principalTable: "DongVats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cas_DongVatId",
                table: "cas",
                column: "DongVatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cas");

            migrationBuilder.DropTable(
                name: "DongVats");
        }
    }
}
