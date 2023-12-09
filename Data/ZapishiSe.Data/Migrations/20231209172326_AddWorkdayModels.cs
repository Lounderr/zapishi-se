using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZapishiSe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkdayModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BusinessId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holiday_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Workday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    WorkdayStart = table.Column<TimeOnly>(type: "time", nullable: false),
                    WorkdayEnd = table.Column<TimeOnly>(type: "time", nullable: false),
                    BusinessId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workday", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workday_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Break",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakStart = table.Column<TimeOnly>(type: "time", nullable: false),
                    BreakEnd = table.Column<TimeOnly>(type: "time", nullable: false),
                    WorkdayId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Break", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Break_Workday_WorkdayId",
                        column: x => x.WorkdayId,
                        principalTable: "Workday",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Break_WorkdayId",
                table: "Break",
                column: "WorkdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_BusinessId",
                table: "Holiday",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Workday_BusinessId",
                table: "Workday",
                column: "BusinessId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Break");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "Workday");
        }
    }
}
