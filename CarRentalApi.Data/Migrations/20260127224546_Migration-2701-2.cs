using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration27012 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePrice_VehicleType_VehicleTypeId",
                table: "VehiclePrice");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleType_VehicleTypeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_VehicleLocation_VehicleLocationId",
                table: "VehicleType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleType",
                table: "VehicleType");

            migrationBuilder.RenameTable(
                name: "VehicleType",
                newName: "VehicleTypes");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleType_VehicleLocationId",
                table: "VehicleTypes",
                newName: "IX_VehicleTypes_VehicleLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePrice_VehicleTypes_VehicleTypeId",
                table: "VehiclePrice",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTypes_VehicleLocation_VehicleLocationId",
                table: "VehicleTypes",
                column: "VehicleLocationId",
                principalTable: "VehicleLocation",
                principalColumn: "VehicleLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePrice_VehicleTypes_VehicleTypeId",
                table: "VehiclePrice");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTypes_VehicleLocation_VehicleLocationId",
                table: "VehicleTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes");

            migrationBuilder.RenameTable(
                name: "VehicleTypes",
                newName: "VehicleType");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTypes_VehicleLocationId",
                table: "VehicleType",
                newName: "IX_VehicleType_VehicleLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleType",
                table: "VehicleType",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePrice_VehicleType_VehicleTypeId",
                table: "VehiclePrice",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleType_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_VehicleLocation_VehicleLocationId",
                table: "VehicleType",
                column: "VehicleLocationId",
                principalTable: "VehicleLocation",
                principalColumn: "VehicleLocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
