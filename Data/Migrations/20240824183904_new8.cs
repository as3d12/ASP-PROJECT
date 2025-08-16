using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eagle.Data.Migrations
{
    /// <inheritdoc />
    public partial class new8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8586ef12-3f99-49ee-80fe-6481fe4343fd");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tblSection",
                type: "nvarchar(20)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b08df82f-856d-404c-8eed-4f313411cfa2", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8966)), new TimeOnly(16, 39, 3, 342).Add(TimeSpan.FromTicks(8959)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8972)), new TimeOnly(19, 39, 3, 342).Add(TimeSpan.FromTicks(8971)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(8977)), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(8975)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8982)), new TimeOnly(16, 39, 3, 342).Add(TimeSpan.FromTicks(8981)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(8987)), new TimeOnly(19, 39, 3, 342).Add(TimeSpan.FromTicks(8986)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(8991)), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(8990)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(8996)), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(8995)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 39, 3, 342).Add(TimeSpan.FromTicks(9001)), new TimeOnly(19, 39, 3, 342).Add(TimeSpan.FromTicks(9000)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 39, 3, 342).Add(TimeSpan.FromTicks(9006)), new TimeOnly(22, 39, 3, 342).Add(TimeSpan.FromTicks(9005)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b08df82f-856d-404c-8eed-4f313411cfa2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tblSection",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8586ef12-3f99-49ee-80fe-6481fe4343fd", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 30, 6, 691).Add(TimeSpan.FromTicks(51)), new TimeOnly(16, 30, 6, 691).Add(TimeSpan.FromTicks(46)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 30, 6, 691).Add(TimeSpan.FromTicks(55)), new TimeOnly(19, 30, 6, 691).Add(TimeSpan.FromTicks(55)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 30, 6, 691).Add(TimeSpan.FromTicks(59)), new TimeOnly(22, 30, 6, 691).Add(TimeSpan.FromTicks(58)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 30, 6, 691).Add(TimeSpan.FromTicks(63)), new TimeOnly(16, 30, 6, 691).Add(TimeSpan.FromTicks(62)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 30, 6, 691).Add(TimeSpan.FromTicks(67)), new TimeOnly(19, 30, 6, 691).Add(TimeSpan.FromTicks(66)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 30, 6, 691).Add(TimeSpan.FromTicks(70)), new TimeOnly(22, 30, 6, 691).Add(TimeSpan.FromTicks(69)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 30, 6, 691).Add(TimeSpan.FromTicks(74)), new TimeOnly(22, 30, 6, 691).Add(TimeSpan.FromTicks(73)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(23, 30, 6, 691).Add(TimeSpan.FromTicks(78)), new TimeOnly(19, 30, 6, 691).Add(TimeSpan.FromTicks(77)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(6, 30, 6, 691).Add(TimeSpan.FromTicks(82)), new TimeOnly(22, 30, 6, 691).Add(TimeSpan.FromTicks(81)) });
        }
    }
}
