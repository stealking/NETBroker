using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETBroker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContractItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ContractMargin",
                table: "ContractItems",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

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
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ContractMargin", "DateCreated" },
                values: new object[] { 0m, new DateTime(2023, 12, 22, 13, 56, 36, 175, DateTimeKind.Local).AddTicks(2150) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractMargin",
                table: "ContractItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "05ee14de-8148-419a-9293-7a3c0006f391", new DateTime(2023, 12, 20, 11, 19, 37, 433, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "0073072b-fa9d-4b69-ab5a-809389f9a5ef", new DateTime(2023, 12, 20, 11, 19, 37, 433, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 434, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 434, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 435, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 433, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 20, 11, 19, 37, 433, DateTimeKind.Local).AddTicks(9749));
        }
    }
}
