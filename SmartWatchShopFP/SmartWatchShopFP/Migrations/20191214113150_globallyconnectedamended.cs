using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatchShopFP.Migrations
{
    public partial class globallyconnectedamended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GloballyConnecteds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 300, nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Subtitle = table.Column<string>(maxLength: 150, nullable: false),
                    Paragraph = table.Column<string>(maxLength: 300, nullable: false),
                    Button = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GloballyConnecteds", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GloballyConnecteds");
        }
    }
}
