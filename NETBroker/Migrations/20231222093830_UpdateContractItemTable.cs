using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETBroker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContractItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AnnualUsage",
                table: "ContractItems",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "5f8040f3-abd9-4946-abc5-699f972ec5a2", new DateTime(2023, 12, 22, 16, 38, 30, 540, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "c7cabff9-3d0f-4f2a-90cf-0d8857cd0d4f", new DateTime(2023, 12, 22, 16, 38, 30, 540, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 542, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 542, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 542, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 542, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 542, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 58398m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 12303m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 835m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 160880m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 89340m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 36000m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 4200m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 1500m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 60000m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 15000m, new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 540, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 540, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 541, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 540, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 16, 38, 30, 540, DateTimeKind.Local).AddTicks(5841));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AnnualUsage",
                table: "ContractItems",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "39aff555-4362-42fa-9cf3-c2c49da9f2a8", new DateTime(2023, 12, 22, 13, 56, 36, 173, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "3ef2154d-469d-4a78-a5d6-308297945358", new DateTime(2023, 12, 22, 13, 56, 36, 173, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 58398, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 12303, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 835, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 160880, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 89340, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 36000, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 4200, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 1500, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 60000, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AnnualUsage", "DateCreated" },
                values: new object[] { 15000, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 174, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 174, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 173, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 22, 13, 56, 36, 173, DateTimeKind.Local).AddTicks(9975));
        }
    }
}
