using Microsoft.EntityFrameworkCore.Migrations;

namespace Deus_DataAccessLayer.Migrations
{
    public partial class DB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Services",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Customers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_AppointmentId",
                table: "Services",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AppointmentId",
                table: "Customers",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Appointments_AppointmentId",
                table: "Customers",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Appointments_AppointmentId",
                table: "Services",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Appointments_AppointmentId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Appointments_AppointmentId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_AppointmentId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AppointmentId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Customers");
        }
    }
}
