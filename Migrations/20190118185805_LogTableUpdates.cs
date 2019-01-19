using Microsoft.EntityFrameworkCore.Migrations;

namespace JTracker.Migrations
{
    public partial class LogTableUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "LogLevel",
                table: "Log",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<byte>(
                name: "Dispositioned",
                table: "Log",
                nullable: false,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "LogLevel",
                table: "Log",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Dispositioned",
                table: "Log",
                nullable: false,
                oldClrType: typeof(byte));
        }
    }
}
