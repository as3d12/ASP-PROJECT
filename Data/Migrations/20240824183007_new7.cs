using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eagle.Data.Migrations
{
    /// <inheritdoc />
    public partial class new7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "046dd93a-af81-4cca-be43-f8819df7c821");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TripCompany",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8586ef12-3f99-49ee-80fe-6481fe4343fd", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 1,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 2,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 3,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 4,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 1,
                column: "Name",
                value: "Air Flight");

            migrationBuilder.UpdateData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 2,
                column: "Name",
                value: "Land Trip");

            migrationBuilder.UpdateData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 3,
                column: "Name",
                value: "Cruise");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8586ef12-3f99-49ee-80fe-6481fe4343fd");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TripCompany");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "046dd93a-af81-4cca-be43-f8819df7c821", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 1,
                column: "Name",
                value: "Air Flights");

            migrationBuilder.UpdateData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 2,
                column: "Name",
                value: "Land Trips");

            migrationBuilder.UpdateData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 3,
                column: "Name",
                value: "Cruises");

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(5, 18, 3, 544).Add(TimeSpan.FromTicks(3120)), new TimeOnly(22, 18, 3, 544).Add(TimeSpan.FromTicks(3115)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(5, 18, 3, 544).Add(TimeSpan.FromTicks(3124)), new TimeOnly(1, 18, 3, 544).Add(TimeSpan.FromTicks(3123)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(12, 18, 3, 544).Add(TimeSpan.FromTicks(3128)), new TimeOnly(4, 18, 3, 544).Add(TimeSpan.FromTicks(3127)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(5, 18, 3, 544).Add(TimeSpan.FromTicks(3131)), new TimeOnly(22, 18, 3, 544).Add(TimeSpan.FromTicks(3131)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(5, 18, 3, 544).Add(TimeSpan.FromTicks(3135)), new TimeOnly(1, 18, 3, 544).Add(TimeSpan.FromTicks(3134)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(12, 18, 3, 544).Add(TimeSpan.FromTicks(3139)), new TimeOnly(4, 18, 3, 544).Add(TimeSpan.FromTicks(3138)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(12, 18, 3, 544).Add(TimeSpan.FromTicks(3143)), new TimeOnly(4, 18, 3, 544).Add(TimeSpan.FromTicks(3142)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(5, 18, 3, 544).Add(TimeSpan.FromTicks(3147)), new TimeOnly(1, 18, 3, 544).Add(TimeSpan.FromTicks(3146)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(12, 18, 3, 544).Add(TimeSpan.FromTicks(3150)), new TimeOnly(4, 18, 3, 544).Add(TimeSpan.FromTicks(3150)) });
        }
    }
}
