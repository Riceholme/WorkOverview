using Microsoft.EntityFrameworkCore.Migrations;

namespace RestAPI.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeReports",
                columns: new[] { "TimeReportId", "EmployeeId", "HoursWorked", "ProjectId", "WeekNumber" },
                values: new object[,]
                {
                    { 1, 1, 20, 1, 1 },
                    { 2, 2, 20, 1, 1 },
                    { 3, 3, 35, 2, 1 },
                    { 4, 4, 35, 3, 1 },
                    { 5, 1, 20, 2, 2 },
                    { 6, 2, 20, 2, 2 },
                    { 7, 3, 20, 3, 2 },
                    { 8, 4, 20, 3, 2 },
                    { 9, 1, 25, 2, 3 },
                    { 10, 2, 25, 3, 3 },
                    { 11, 3, 30, 2, 3 },
                    { 12, 4, 30, 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TimeReports",
                keyColumn: "TimeReportId",
                keyValue: 12);
        }
    }
}
