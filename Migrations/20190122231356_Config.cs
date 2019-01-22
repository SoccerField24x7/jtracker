using Microsoft.EntityFrameworkCore.Migrations;

namespace JTracker.Migrations
{
    public partial class Config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    ConfigId = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    KeyName = table.Column<string>(type: "text", nullable: true),
                    KeyValue = table.Column<string>(type: "text", nullable: true),
                    DataType = table.Column<string>(type: "text", nullable: true),
                    Active = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.ConfigId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Config");
        }
    }
}
