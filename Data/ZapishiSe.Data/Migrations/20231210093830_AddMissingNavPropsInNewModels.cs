using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZapishiSe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingNavPropsInNewModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Break_Workday_WorkdayId",
                table: "Break");

            migrationBuilder.DropForeignKey(
                name: "FK_Holiday_Businesses_BusinessId",
                table: "Holiday");

            migrationBuilder.DropForeignKey(
                name: "FK_Workday_Businesses_BusinessId",
                table: "Workday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workday",
                table: "Workday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Break",
                table: "Break");

            migrationBuilder.RenameTable(
                name: "Workday",
                newName: "Workdays");

            migrationBuilder.RenameTable(
                name: "Holiday",
                newName: "Holidays");

            migrationBuilder.RenameTable(
                name: "Break",
                newName: "Breaks");

            migrationBuilder.RenameIndex(
                name: "IX_Workday_BusinessId",
                table: "Workdays",
                newName: "IX_Workdays_BusinessId");

            migrationBuilder.RenameIndex(
                name: "IX_Holiday_BusinessId",
                table: "Holidays",
                newName: "IX_Holidays_BusinessId");

            migrationBuilder.RenameIndex(
                name: "IX_Break_WorkdayId",
                table: "Breaks",
                newName: "IX_Breaks_WorkdayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workdays",
                table: "Workdays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breaks",
                table: "Breaks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Breaks_Workdays_WorkdayId",
                table: "Breaks",
                column: "WorkdayId",
                principalTable: "Workdays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Businesses_BusinessId",
                table: "Holidays",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workdays_Businesses_BusinessId",
                table: "Workdays",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breaks_Workdays_WorkdayId",
                table: "Breaks");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Businesses_BusinessId",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Workdays_Businesses_BusinessId",
                table: "Workdays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workdays",
                table: "Workdays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breaks",
                table: "Breaks");

            migrationBuilder.RenameTable(
                name: "Workdays",
                newName: "Workday");

            migrationBuilder.RenameTable(
                name: "Holidays",
                newName: "Holiday");

            migrationBuilder.RenameTable(
                name: "Breaks",
                newName: "Break");

            migrationBuilder.RenameIndex(
                name: "IX_Workdays_BusinessId",
                table: "Workday",
                newName: "IX_Workday_BusinessId");

            migrationBuilder.RenameIndex(
                name: "IX_Holidays_BusinessId",
                table: "Holiday",
                newName: "IX_Holiday_BusinessId");

            migrationBuilder.RenameIndex(
                name: "IX_Breaks_WorkdayId",
                table: "Break",
                newName: "IX_Break_WorkdayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workday",
                table: "Workday",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Break",
                table: "Break",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Break_Workday_WorkdayId",
                table: "Break",
                column: "WorkdayId",
                principalTable: "Workday",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Holiday_Businesses_BusinessId",
                table: "Holiday",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workday_Businesses_BusinessId",
                table: "Workday",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id");
        }
    }
}
