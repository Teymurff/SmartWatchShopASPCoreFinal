using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatchShopFP.Migrations
{
    public partial class brandnewappadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandNewApps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 300, nullable: true),
                    IconImage = table.Column<string>(maxLength: 300, nullable: true),
                    SubtitleTop = table.Column<string>(maxLength: 150, nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    SubtitleBottom = table.Column<string>(maxLength: 150, nullable: false),
                    Paragraph = table.Column<string>(maxLength: 300, nullable: false),
                    Button = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandNewApps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandNewApps");
        }
    }
}
