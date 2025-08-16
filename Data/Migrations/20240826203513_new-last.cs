using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eagle.Data.Migrations
{
    /// <inheritdoc />
    public partial class newlast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b08df82f-856d-404c-8eed-4f313411cfa2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c2c7a7a-46b7-4b9c-8def-8c61bd9eb544", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(1, 35, 12, 994).Add(TimeSpan.FromTicks(9986)), new DateOnly(2024, 8, 21), new TimeOnly(18, 35, 12, 994).Add(TimeSpan.FromTicks(9979)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(1, 35, 12, 994).Add(TimeSpan.FromTicks(9991)), new DateOnly(2024, 8, 24), new TimeOnly(21, 35, 12, 994).Add(TimeSpan.FromTicks(9990)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(8, 35, 12, 994).Add(TimeSpan.FromTicks(9994)), new DateOnly(2024, 8, 17), new TimeOnly(0, 35, 12, 994).Add(TimeSpan.FromTicks(9994)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(1, 35, 12, 994).Add(TimeSpan.FromTicks(9998)), new DateOnly(2024, 8, 21), new TimeOnly(18, 35, 12, 994).Add(TimeSpan.FromTicks(9998)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(1, 35, 12, 995).Add(TimeSpan.FromTicks(2)), new DateOnly(2024, 8, 24), new TimeOnly(21, 35, 12, 995).Add(TimeSpan.FromTicks(1)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(8, 35, 12, 995).Add(TimeSpan.FromTicks(6)), new DateOnly(2024, 8, 17), new TimeOnly(0, 35, 12, 995).Add(TimeSpan.FromTicks(5)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(8, 35, 12, 995).Add(TimeSpan.FromTicks(10)), new DateOnly(2024, 8, 17), new TimeOnly(0, 35, 12, 995).Add(TimeSpan.FromTicks(9)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(1, 35, 12, 995).Add(TimeSpan.FromTicks(13)), new DateOnly(2024, 8, 24), new TimeOnly(21, 35, 12, 995).Add(TimeSpan.FromTicks(13)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 26), new TimeOnly(8, 35, 12, 995).Add(TimeSpan.FromTicks(17)), new DateOnly(2024, 8, 17), new TimeOnly(0, 35, 12, 995).Add(TimeSpan.FromTicks(16)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c2c7a7a-46b7-4b9c-8def-8c61bd9eb544");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b08df82f-856d-404c-8eed-4f313411cfa2", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8966)), new DateOnly(2024, 8, 19), new TimeOnly(16, 39, 3, 342).Add(TimeSpan.FromTicks(8959)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8972)), new DateOnly(2024, 8, 22), new TimeOnly(19, 39, 3, 342).Add(TimeSpan.FromTicks(8971)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(8977)), new DateOnly(2024, 8, 15), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(8975)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8982)), new DateOnly(2024, 8, 19), new TimeOnly(16, 39, 3, 342).Add(TimeSpan.FromTicks(8981)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8987)), new DateOnly(2024, 8, 22), new TimeOnly(19, 39, 3, 342).Add(TimeSpan.FromTicks(8986)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(8991)), new DateOnly(2024, 8, 15), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(8990)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(8996)), new DateOnly(2024, 8, 15), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(8995)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(9001)), new DateOnly(2024, 8, 22), new TimeOnly(19, 39, 3, 342).Add(TimeSpan.FromTicks(9000)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(9006)), new DateOnly(2024, 8, 15), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(9005)) });
        }
    }
}
