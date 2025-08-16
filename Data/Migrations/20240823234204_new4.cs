using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eagle.Data.Migrations
{
    /// <inheritdoc />
    public partial class new4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac8d286c-80ff-4054-9a29-12f5f832cfb1");

            migrationBuilder.CreateTable(
                name: "tblCompany",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompany", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "TripCompany",
                columns: table => new
                {
                    TripCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripCompany", x => x.TripCompanyId);
                    table.ForeignKey(
                        name: "FK_TripCompany_tblCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompany",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripCompany_tblTrip_TripId",
                        column: x => x.TripId,
                        principalTable: "tblTrip",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19575d56-e9f9-44a6-b099-8d00a7300a86", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9134)), new DateOnly(2024, 8, 19), new TimeOnly(21, 42, 4, 39).Add(TimeSpan.FromTicks(9129)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9138)), new DateOnly(2024, 8, 22), new TimeOnly(0, 42, 4, 39).Add(TimeSpan.FromTicks(9137)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9142)), new DateOnly(2024, 8, 15), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9141)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9146)), new DateOnly(2024, 8, 19), new TimeOnly(21, 42, 4, 39).Add(TimeSpan.FromTicks(9145)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9149)), new DateOnly(2024, 8, 22), new TimeOnly(0, 42, 4, 39).Add(TimeSpan.FromTicks(9149)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9153)), new DateOnly(2024, 8, 15), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9152)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9157)), new DateOnly(2024, 8, 15), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9156)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(4, 42, 4, 39).Add(TimeSpan.FromTicks(9161)), new DateOnly(2024, 8, 22), new TimeOnly(0, 42, 4, 39).Add(TimeSpan.FromTicks(9160)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 24), new TimeOnly(11, 42, 4, 39).Add(TimeSpan.FromTicks(9164)), new DateOnly(2024, 8, 15), new TimeOnly(3, 42, 4, 39).Add(TimeSpan.FromTicks(9164)) });

            migrationBuilder.CreateIndex(
                name: "IX_TripCompany_CompanyId",
                table: "TripCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TripCompany_TripId",
                table: "TripCompany",
                column: "TripId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripCompany");

            migrationBuilder.DropTable(
                name: "tblCompany");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19575d56-e9f9-44a6-b099-8d00a7300a86");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac8d286c-80ff-4054-9a29-12f5f832cfb1", null, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 1,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(409)), new DateOnly(2024, 8, 18), new TimeOnly(18, 24, 6, 550).Add(TimeSpan.FromTicks(401)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(415)), new DateOnly(2024, 8, 21), new TimeOnly(21, 24, 6, 550).Add(TimeSpan.FromTicks(414)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 3,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(421)), new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(420)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(426)), new DateOnly(2024, 8, 18), new TimeOnly(18, 24, 6, 550).Add(TimeSpan.FromTicks(425)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(431)), new DateOnly(2024, 8, 21), new TimeOnly(21, 24, 6, 550).Add(TimeSpan.FromTicks(430)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(437)), new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(435)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(442)), new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(441)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 8,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(1, 24, 6, 550).Add(TimeSpan.FromTicks(448)), new DateOnly(2024, 8, 21), new TimeOnly(21, 24, 6, 550).Add(TimeSpan.FromTicks(446)) });

            migrationBuilder.UpdateData(
                table: "tblTrip",
                keyColumn: "TripId",
                keyValue: 9,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { new DateOnly(2024, 8, 23), new TimeOnly(8, 24, 6, 550).Add(TimeSpan.FromTicks(453)), new DateOnly(2024, 8, 14), new TimeOnly(0, 24, 6, 550).Add(TimeSpan.FromTicks(452)) });
        }
    }
}
