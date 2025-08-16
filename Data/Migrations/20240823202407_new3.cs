using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eagle.Data.Migrations
{
    /// <inheritdoc />
    public partial class new3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecc229d0-add2-43a7-9e91-83d18a460ac0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac8d286c-80ff-4054-9a29-12f5f832cfb1", null, "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "tblSection",
                columns: new[] { "SectionId", "Name" },
                values: new object[,]
                {
                    { 1, "Air Flights" },
                    { 2, "Land Trips" },
                    { 3, "Cruises" }
                });

            migrationBuilder.InsertData(
                table: "tblTrip",
                columns: new[] { "TripId", "Description", "EndDate", "EndTime", "Name", "Price", "SectionId", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { 1, "Palastine", new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(409)), "Jordan", 150.0, 1, new DateOnly(2024, 8, 18), new TimeOnly(18, 24, 6, 550).Add(TimeSpan.FromTicks(401)) },
                    { 2, "Turky", new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(415)), "Jordan", 450.0, 1, new DateOnly(2024, 8, 21), new TimeOnly(21, 24, 6, 550).Add(TimeSpan.FromTicks(414)) },
                    { 3, "Canada", new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(421)), "Jordan", 650.0, 1, new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(420)) },
                    { 4, "Iraq", new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(426)), "Jordan", 150.0, 2, new DateOnly(2024, 8, 18), new TimeOnly(18, 24, 6, 550).Add(TimeSpan.FromTicks(425)) },
                    { 5, "Palastine", new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(431)), "Jordan", 450.0, 2, new DateOnly(2024, 8, 21), new TimeOnly(21, 24, 6, 550).Add(TimeSpan.FromTicks(430)) },
                    { 6, "Syria", new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(437)), "Jordan", 650.0, 2, new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(435)) },
                    { 7, "Spain", new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(442)), "Jordan", 650.0, 3, new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(441)) },
                    { 8, "USA", new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(448)), "Jordan", 450.0, 3, new DateOnly(2024, 8, 21), new TimeOnly(21, 24, 6, 550).Add(TimeSpan.FromTicks(446)) },
                    { 9, "UAE", new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(453)), "Jordan", 650.0, 3, new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(452)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac8d286c-80ff-4054-9a29-12f5f832cfb1");

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblSection",
                keyColumn: "SectionId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecc229d0-add2-43a7-9e91-83d18a460ac0", null, "Admin", "Admin" });
        }
    }
}
