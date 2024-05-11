using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Infra.Data.Migrations
{
    public partial class AddCustomerFeedbackTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_thingIDos",
                table: "thingIDos");

            migrationBuilder.RenameTable(
                name: "thingIDos",
                newName: "ThingIDos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThingIDos",
                table: "ThingIDos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ThingIDos",
                table: "ThingIDos");

            migrationBuilder.RenameTable(
                name: "ThingIDos",
                newName: "thingIDos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_thingIDos",
                table: "thingIDos",
                column: "Id");
        }
    }
}
