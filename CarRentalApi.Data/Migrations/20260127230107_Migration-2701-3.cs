using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration27013 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_CustomerAddress_CustomerAddressId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBooking_Customer_CustomerId",
                table: "VehicleBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBooking_Vehicles_VehicleId",
                table: "VehicleBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDamage_Customer_CustomerId",
                table: "VehicleDamage");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDamage_VehicleDamageType_VehicleDamageTypeId",
                table: "VehicleDamage");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDamage_Vehicles_VehicleId",
                table: "VehicleDamage");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTypes_VehicleLocation_VehicleLocationId",
                table: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "VehicleHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleTypes_VehicleLocationId",
                table: "VehicleTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleLocation",
                table: "VehicleLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleDamageType",
                table: "VehicleDamageType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleDamage",
                table: "VehicleDamage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleBooking",
                table: "VehicleBooking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "VehicleLocationId",
                table: "VehicleTypes");

            migrationBuilder.RenameTable(
                name: "VehicleLocation",
                newName: "VehicleLocations");

            migrationBuilder.RenameTable(
                name: "VehicleDamageType",
                newName: "VehicleDamageTypes");

            migrationBuilder.RenameTable(
                name: "VehicleDamage",
                newName: "VehicleDamages");

            migrationBuilder.RenameTable(
                name: "VehicleBooking",
                newName: "VehicleBookings");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleDamage_VehicleDamageTypeId",
                table: "VehicleDamages",
                newName: "IX_VehicleDamages_VehicleDamageTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleDamage_CustomerId",
                table: "VehicleDamages",
                newName: "IX_VehicleDamages_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBooking_VehicleId",
                table: "VehicleBookings",
                newName: "IX_VehicleBookings_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBooking_CustomerId",
                table: "VehicleBookings",
                newName: "IX_VehicleBookings_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_CustomerAddressId",
                table: "Customers",
                newName: "IX_Customers_CustomerAddressId");

            migrationBuilder.AddColumn<int>(
                name: "VehicleLocationId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleLocations",
                table: "VehicleLocations",
                column: "VehicleLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleDamageTypes",
                table: "VehicleDamageTypes",
                column: "VehicleDamageTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleDamages",
                table: "VehicleDamages",
                columns: new[] { "VehicleId", "VehicleDamageTypeId", "CustomerId", "VehicleBookingId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleBookings",
                table: "VehicleBookings",
                column: "VehicleBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleLocationId",
                table: "Vehicles",
                column: "VehicleLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerAddress_CustomerAddressId",
                table: "Customers",
                column: "CustomerAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "CustomerAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBookings_Customers_CustomerId",
                table: "VehicleBookings",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBookings_Vehicles_VehicleId",
                table: "VehicleBookings",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDamages_Customers_CustomerId",
                table: "VehicleDamages",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDamages_VehicleDamageTypes_VehicleDamageTypeId",
                table: "VehicleDamages",
                column: "VehicleDamageTypeId",
                principalTable: "VehicleDamageTypes",
                principalColumn: "VehicleDamageTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDamages_Vehicles_VehicleId",
                table: "VehicleDamages",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleLocations_VehicleLocationId",
                table: "Vehicles",
                column: "VehicleLocationId",
                principalTable: "VehicleLocations",
                principalColumn: "VehicleLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerAddress_CustomerAddressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBookings_Customers_CustomerId",
                table: "VehicleBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBookings_Vehicles_VehicleId",
                table: "VehicleBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDamages_Customers_CustomerId",
                table: "VehicleDamages");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDamages_VehicleDamageTypes_VehicleDamageTypeId",
                table: "VehicleDamages");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDamages_Vehicles_VehicleId",
                table: "VehicleDamages");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleLocations_VehicleLocationId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleLocationId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleLocations",
                table: "VehicleLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleDamageTypes",
                table: "VehicleDamageTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleDamages",
                table: "VehicleDamages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleBookings",
                table: "VehicleBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "VehicleLocationId",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "VehicleLocations",
                newName: "VehicleLocation");

            migrationBuilder.RenameTable(
                name: "VehicleDamageTypes",
                newName: "VehicleDamageType");

            migrationBuilder.RenameTable(
                name: "VehicleDamages",
                newName: "VehicleDamage");

            migrationBuilder.RenameTable(
                name: "VehicleBookings",
                newName: "VehicleBooking");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleDamages_VehicleDamageTypeId",
                table: "VehicleDamage",
                newName: "IX_VehicleDamage_VehicleDamageTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleDamages_CustomerId",
                table: "VehicleDamage",
                newName: "IX_VehicleDamage_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBookings_VehicleId",
                table: "VehicleBooking",
                newName: "IX_VehicleBooking_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBookings_CustomerId",
                table: "VehicleBooking",
                newName: "IX_VehicleBooking_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_CustomerAddressId",
                table: "Customer",
                newName: "IX_Customer_CustomerAddressId");

            migrationBuilder.AddColumn<int>(
                name: "VehicleLocationId",
                table: "VehicleTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleLocation",
                table: "VehicleLocation",
                column: "VehicleLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleDamageType",
                table: "VehicleDamageType",
                column: "VehicleDamageTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleDamage",
                table: "VehicleDamage",
                columns: new[] { "VehicleId", "VehicleDamageTypeId", "CustomerId", "VehicleBookingId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleBooking",
                table: "VehicleBooking",
                column: "VehicleBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.CreateTable(
                name: "VehicleHistory",
                columns: table => new
                {
                    VehicleHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleHistoryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleHistory", x => x.VehicleHistoryId);
                    table.ForeignKey(
                        name: "FK_VehicleHistory_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypes_VehicleLocationId",
                table: "VehicleTypes",
                column: "VehicleLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistory_VehicleId",
                table: "VehicleHistory",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_CustomerAddress_CustomerAddressId",
                table: "Customer",
                column: "CustomerAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "CustomerAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBooking_Customer_CustomerId",
                table: "VehicleBooking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBooking_Vehicles_VehicleId",
                table: "VehicleBooking",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDamage_Customer_CustomerId",
                table: "VehicleDamage",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDamage_VehicleDamageType_VehicleDamageTypeId",
                table: "VehicleDamage",
                column: "VehicleDamageTypeId",
                principalTable: "VehicleDamageType",
                principalColumn: "VehicleDamageTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDamage_Vehicles_VehicleId",
                table: "VehicleDamage",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTypes_VehicleLocation_VehicleLocationId",
                table: "VehicleTypes",
                column: "VehicleLocationId",
                principalTable: "VehicleLocation",
                principalColumn: "VehicleLocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
