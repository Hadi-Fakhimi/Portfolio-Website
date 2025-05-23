using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resume_V2.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigUpdatePageVisitTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VisitDate",
                table: "PageVisits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisitDate",
                table: "PageVisits");
        }
    }
}
