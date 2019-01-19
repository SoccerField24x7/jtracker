using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JTracker.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    LogId = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    LogLevel = table.Column<short>(nullable: false),
                    SourcePage = table.Column<string>(type: "text", nullable: true),
                    SQL = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Generated = table.Column<DateTime>(nullable: false),
                    Dispositioned = table.Column<short>(nullable: false),
                    DispositionDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.LogId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log");
        }
    }
}
