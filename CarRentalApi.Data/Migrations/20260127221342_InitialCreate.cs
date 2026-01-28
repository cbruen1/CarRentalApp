using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "CustomerAddress",
            //    columns: table => new
            //    {
            //        CustomerAddressId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CustomerAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerAddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerAddressCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerAddressPostCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CustomerAddress", x => x.CustomerAddressId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehicleDamageType",
            //    columns: table => new
            //    {
            //        VehicleDamageTypeId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleDamageTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehicleDamageType", x => x.VehicleDamageTypeId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehicleLocation",
            //    columns: table => new
            //    {
            //        VehicleLocationId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleLocationAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VehicleLocationAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VehicleLocationCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VehicleLocationCounty = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VehicleLocationCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VehicleLocationPostcode = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehicleLocation", x => x.VehicleLocationId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Customer",
            //    columns: table => new
            //    {
            //        CustomerId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerAddressId = table.Column<int>(type: "int", nullable: false),
            //        CustomerDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customer", x => x.CustomerId);
            //        table.ForeignKey(
            //            name: "FK_Customer_CustomerAddress_CustomerAddressId",
            //            column: x => x.CustomerAddressId,
            //            principalTable: "CustomerAddress",
            //            principalColumn: "CustomerAddressId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehicleType",
            //    columns: table => new
            //    {
            //        VehicleTypeId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VehicleQuantity = table.Column<int>(type: "int", nullable: false),
            //        VehicleLocationId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehicleType", x => x.VehicleTypeId);
            //        table.ForeignKey(
            //            name: "FK_VehicleType_VehicleLocation_VehicleLocationId",
            //            column: x => x.VehicleLocationId,
            //            principalTable: "VehicleLocation",
            //            principalColumn: "VehicleLocationId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehiclePrice",
            //    columns: table => new
            //    {
            //        VehiclePriceId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleTypeId = table.Column<int>(type: "int", nullable: false),
            //        VehiclePriceDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        VehiclePriceDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        VehicleDailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehiclePrice", x => x.VehiclePriceId);
            //        table.ForeignKey(
            //            name: "FK_VehiclePrice_VehicleType_VehicleTypeId",
            //            column: x => x.VehicleTypeId,
            //            principalTable: "VehicleType",
            //            principalColumn: "VehicleTypeId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vehicles",
            //    columns: table => new
            //    {
            //        VehicleId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleTypeId = table.Column<int>(type: "int", nullable: false),
            //        VehicleModel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        VehicleReg = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        VehicleYear = table.Column<int>(type: "int", nullable: false),
            //        VehicleColour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
            //        table.ForeignKey(
            //            name: "FK_Vehicles_VehicleType_VehicleTypeId",
            //            column: x => x.VehicleTypeId,
            //            principalTable: "VehicleType",
            //            principalColumn: "VehicleTypeId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehicleBooking",
            //    columns: table => new
            //    {
            //        VehicleBookingId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleId = table.Column<int>(type: "int", nullable: false),
            //        CustomerId = table.Column<int>(type: "int", nullable: false),
            //        BookingStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        BookingEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehicleBooking", x => x.VehicleBookingId);
            //        table.ForeignKey(
            //            name: "FK_VehicleBooking_Customer_CustomerId",
            //            column: x => x.CustomerId,
            //            principalTable: "Customer",
            //            principalColumn: "CustomerId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_VehicleBooking_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "VehicleId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehicleDamage",
            //    columns: table => new
            //    {
            //        VehicleId = table.Column<int>(type: "int", nullable: false),
            //        VehicleDamageTypeId = table.Column<int>(type: "int", nullable: false),
            //        CustomerId = table.Column<int>(type: "int", nullable: false),
            //        VehicleBookingId = table.Column<int>(type: "int", nullable: false),
            //        VehicleDamageDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehicleDamage", x => new { x.VehicleId, x.VehicleDamageTypeId, x.CustomerId, x.VehicleBookingId });
            //        table.ForeignKey(
            //            name: "FK_VehicleDamage_Customer_CustomerId",
            //            column: x => x.CustomerId,
            //            principalTable: "Customer",
            //            principalColumn: "CustomerId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_VehicleDamage_VehicleDamageType_VehicleDamageTypeId",
            //            column: x => x.VehicleDamageTypeId,
            //            principalTable: "VehicleDamageType",
            //            principalColumn: "VehicleDamageTypeId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_VehicleDamage_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "VehicleId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehicleHistory",
            //    columns: table => new
            //    {
            //        VehicleHistoryId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleId = table.Column<int>(type: "int", nullable: false),
            //        VehicleHistoryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehicleHistory", x => x.VehicleHistoryId);
            //        table.ForeignKey(
            //            name: "FK_VehicleHistory_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "VehicleId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Customer_CustomerAddressId",
            //    table: "Customer",
            //    column: "CustomerAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehicleBooking_CustomerId",
            //    table: "VehicleBooking",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehicleBooking_VehicleId",
            //    table: "VehicleBooking",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehicleDamage_CustomerId",
            //    table: "VehicleDamage",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehicleDamage_VehicleDamageTypeId",
            //    table: "VehicleDamage",
            //    column: "VehicleDamageTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehicleHistory_VehicleId",
            //    table: "VehicleHistory",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehiclePrice_VehicleTypeId",
            //    table: "VehiclePrice",
            //    column: "VehicleTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicles_VehicleTypeId",
            //    table: "Vehicles",
            //    column: "VehicleTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehicleType_VehicleLocationId",
            //    table: "VehicleType",
            //    column: "VehicleLocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleBooking");

            migrationBuilder.DropTable(
                name: "VehicleDamage");

            migrationBuilder.DropTable(
                name: "VehicleHistory");

            migrationBuilder.DropTable(
                name: "VehiclePrice");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "VehicleDamageType");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropTable(
                name: "VehicleLocation");
        }
    }
}
