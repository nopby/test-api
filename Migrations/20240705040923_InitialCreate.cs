using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BETest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_SIMULATION",
                columns: table => new
                {
                    Id_simulasi = table.Column<Guid>(type: "uuid", nullable: false),
                    Kode_barang = table.Column<string>(type: "text", nullable: false),
                    Uraian_barang = table.Column<string>(type: "text", nullable: false),
                    Bm = table.Column<int>(type: "integer", nullable: false),
                    Nilai_komoditas = table.Column<float>(type: "real", nullable: false),
                    Nilai_bm = table.Column<float>(type: "real", nullable: false),
                    Waktu_insert = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_SIMULATION", x => x.Id_simulasi);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_SIMULATION");
        }
    }
}
