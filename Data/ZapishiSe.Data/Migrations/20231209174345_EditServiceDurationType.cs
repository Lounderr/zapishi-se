using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZapishiSe.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditServiceDurationType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationMinutes",
                table: "Services");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Duration",
                table: "Services",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "DurationMinutes",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
