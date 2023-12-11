using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETBroker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateConfigTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ControlDateType",
                table: "DateConfigs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ControlDateOffsetValue",
                table: "DateConfigs",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ControlDateModifierType",
                table: "DateConfigs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "48a4414b-29fa-421a-aed2-c5b718b1db34", new DateTime(2023, 12, 8, 17, 0, 34, 471, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 472, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 471, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 471, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 473, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "DateConfigs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ControlDateModifierType", "ControlDateOffsetType", "ControlDateOffsetValue", "ControlDateType" },
                values: new object[] { 0, 4, 2, 0 });

            migrationBuilder.UpdateData(
                table: "DateConfigs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ControlDateModifierType", "ControlDateOffsetValue", "ControlDateType" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "DateConfigs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ControlDateModifierType", "ControlDateOffsetValue", "ControlDateType" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 8, 17, 0, 34, 471, DateTimeKind.Local).AddTicks(8581));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ControlDateType",
                table: "DateConfigs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<decimal>(
                name: "ControlDateOffsetValue",
                table: "DateConfigs",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ControlDateModifierType",
                table: "DateConfigs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "c55e6557-83b7-4ae7-ac51-bc807957490a", new DateTime(2023, 12, 1, 16, 9, 53, 304, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 305, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 305, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "DateConfigs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ControlDateModifierType", "ControlDateOffsetType", "ControlDateOffsetValue", "ControlDateType" },
                values: new object[] { "NoModifier", 5, 2m, "SoldDate" });

            migrationBuilder.UpdateData(
                table: "DateConfigs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ControlDateModifierType", "ControlDateOffsetValue", "ControlDateType" },
                values: new object[] { "NoModifier", 2m, "SoldDate" });

            migrationBuilder.UpdateData(
                table: "DateConfigs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ControlDateModifierType", "ControlDateOffsetValue", "ControlDateType" },
                values: new object[] { "NoModifier", 2m, "SoldDate" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 305, DateTimeKind.Local).AddTicks(179));
        }
    }
}
