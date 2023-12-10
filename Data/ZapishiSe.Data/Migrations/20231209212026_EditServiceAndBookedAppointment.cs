using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZapishiSe.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditServiceAndBookedAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "BookedAppointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_ServiceId",
                table: "BookedAppointments",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Services_ServiceId",
                table: "BookedAppointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Services_ServiceId",
                table: "BookedAppointments");

            migrationBuilder.DropIndex(
                name: "IX_BookedAppointments_ServiceId",
                table: "BookedAppointments");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "BookedAppointments");
        }
    }
}
