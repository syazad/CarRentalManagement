using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8408), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8428), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8561), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8563), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8623), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8624), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8626), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8627), new DateTime(2025, 11, 24, 15, 29, 4, 15, DateTimeKind.Local).AddTicks(8627) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1243), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1259), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1385), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1386), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1436), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1439), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1440), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1441), new DateTime(2025, 11, 24, 15, 26, 12, 386, DateTimeKind.Local).AddTicks(1442) });
        }
    }
}
