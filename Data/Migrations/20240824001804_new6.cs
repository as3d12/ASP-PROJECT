using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eagle.Data.Migrations
{
    /// <inheritdoc />
    public partial class new6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfe77696-5bb1-449d-b292-85ec3d3b8c17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "046dd93a-af81-4cca-be43-f8819df7c821", null, "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "TripCompany",
                columns: new[] { "TripCompanyId", "CompanyId", "Responsible", "TripId" },
                values: new object[,]
                {
                    { 1, 1, "Asaad", 1 },
                    { 2, 1, "Mohammad", 2 },
                    { 3, 2, "Karem", 4 }
                });

            migrationBuilder.InsertData(
                table: "tblCompany",
                columns: new[] { "CompanyId", "Email", "Location", "Name", "Phone" },
                values: new object[] { 3, "Petra@gmail.com", "Amman", "Petra", "0791122429" });

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

            migrationBuilder.InsertData(
                table: "TripCompany",
                columns: new[] { "TripCompanyId", "CompanyId", "Responsible", "TripId" },
                values: new object[] { 4, 3, "Younes", 9 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "046dd93a-af81-4cca-be43-f8819df7c821");

            migrationBuilder.DeleteData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TripCompany",
                keyColumn: "TripCompanyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblCompany",
                keyColumn: "CompanyId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfe77696-5bb1-449d-b292-85ec3d3b8c17", null, "Admin", "Admin" });

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
    }
}
