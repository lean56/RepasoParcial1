﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PrestamoRepaso.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto = table.Column<int>(nullable: false),
                    Semanas = table.Column<int>(nullable: false),
                    Cuota = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamosId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestamos");
        }
    }
}
