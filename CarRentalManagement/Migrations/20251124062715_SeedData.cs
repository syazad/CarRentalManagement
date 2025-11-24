using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3304), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3319), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3440), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3441), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3442), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3442), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3488), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3489), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3490), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3491), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3492), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3492), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3493), new DateTime(2025, 11, 24, 14, 27, 15, 99, DateTimeKind.Local).AddTicks(3493), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 21, 42, 899, DateTimeKind.Local).AddTicks(4137), new DateTime(2025, 11, 24, 14, 21, 42, 899, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 21, 42, 899, DateTimeKind.Local).AddTicks(4147), new DateTime(2025, 11, 24, 14, 21, 42, 899, DateTimeKind.Local).AddTicks(4147) });
        }
    }
}
