using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BETest.Migrations
{
    /// <inheritdoc />
    public partial class SetDefaultWaktuInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Waktu_insert",
                table: "TB_SIMULATION",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 5, 5, 10, 13, 768, DateTimeKind.Utc).AddTicks(8309),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Waktu_insert",
                table: "TB_SIMULATION",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 7, 5, 5, 10, 13, 768, DateTimeKind.Utc).AddTicks(8309));
        }
    }
}
