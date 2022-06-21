using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace beaconapi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    macAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    major = table.Column<int>(type: "int", nullable: false),
                    minor = table.Column<int>(type: "int", nullable: false),
                    lastDataSent = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceSignalLogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GatewayId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    major = table.Column<int>(type: "int", nullable: false),
                    minor = table.Column<int>(type: "int", nullable: false),
                    rssi = table.Column<int>(type: "int", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceSignalLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "DeviceSignalLogs");
        }
    }
}
