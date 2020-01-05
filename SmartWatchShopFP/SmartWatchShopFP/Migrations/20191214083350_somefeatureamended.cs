using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatchShopFP.Migrations
{
    public partial class somefeatureamended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "SomeFeatures",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "SomeFeatures");
        }
    }
}
