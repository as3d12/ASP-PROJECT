using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eagle.Data.Migrations
{
    /// <inheritdoc />
    public partial class new5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19575d56-e9f9-44a6-b099-8d00a7300a86");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfe77696-5bb1-449d-b292-85ec3d3b8c17", null, "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "tblCompany",
                columns: new[] { "CompanyId", "Email", "Location", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Dalas@gmail.com", "Amman", "Dalas", "0775426229" },
                    { 2, "Moakeb@gmail.com", "Amman", "Moakeb", "0775422429" }
                });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 49, 53, 821).Add(TimeSpan.FromTicks(4565)), new TimeOnly(21, 49, 53, 821).Add(TimeSpan.FromTicks(4560)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 49, 53, 821).Add(TimeSpan.FromTicks(4569)), new TimeOnly(0, 49, 53, 821).Add(TimeSpan.FromTicks(4568)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 49, 53, 821).Add(TimeSpan.FromTicks(4573)), new TimeOnly(3, 49, 53, 821).Add(TimeSpan.FromTicks(4572)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 49, 53, 821).Add(TimeSpan.FromTicks(4576)), new TimeOnly(21, 49, 53, 821).Add(TimeSpan.FromTicks(4576)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 49, 53, 821).Add(TimeSpan.FromTicks(4580)), new TimeOnly(0, 49, 53, 821).Add(TimeSpan.FromTicks(4579)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 49, 53, 821).Add(TimeSpan.FromTicks(4584)), new TimeOnly(3, 49, 53, 821).Add(TimeSpan.FromTicks(4583)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 49, 53, 821).Add(TimeSpan.FromTicks(4588)), new TimeOnly(3, 49, 53, 821).Add(TimeSpan.FromTicks(4587)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 49, 53, 821).Add(TimeSpan.FromTicks(4591)), new TimeOnly(0, 49, 53, 821).Add(TimeSpan.FromTicks(4591)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 49, 53, 821).Add(TimeSpan.FromTicks(4595)), new TimeOnly(3, 49, 53, 821).Add(TimeSpan.FromTicks(4594)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfe77696-5bb1-449d-b292-85ec3d3b8c17");

            migrationBuilder.DeleteData(
                table: "tblCompany",
                keyColumn: "CompanyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblCompany",
                keyColumn: "CompanyId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19575d56-e9f9-44a6-b099-8d00a7300a86", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9134)), new TimeOnly(21, 42, 4, 39).Add(TimeSpan.FromTicks(9129)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9138)), new TimeOnly(0, 42, 4, 39).Add(TimeSpan.FromTicks(9137)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9142)), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9141)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9146)), new TimeOnly(21, 42, 4, 39).Add(TimeSpan.FromTicks(9145)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9149)), new TimeOnly(0, 42, 4, 39).Add(TimeSpan.FromTicks(9149)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9153)), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9152)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9157)), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9156)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9161)), new TimeOnly(0, 42, 4, 39).Add(TimeSpan.FromTicks(9160)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9164)), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9164)) });
        }
    }
}
