using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETBroker.Migrations
{
    /// <inheritdoc />
    public partial class AddContractItemForcast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractItemAttachments_ContractItems_Id",
                table: "ContractItemAttachments");

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Suppliers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ContractItemId",
                table: "SalePrograms",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Customers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Contracts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "ContractItems",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ForecastStateEnum",
                table: "ContractItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaleProgramId",
                table: "ContractItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ContractItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Contacts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "ContractItemForecasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    ForecastDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ForecastMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    ForecastYear = table.Column<int>(type: "INTEGER", nullable: false),
                    ForecastMonthOfYear = table.Column<string>(type: "TEXT", nullable: true),
                    ContractItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleProgramId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractItemForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractItemForecasts_ContractItems_ContractItemId",
                        column: x => x.ContractItemId,
                        principalTable: "ContractItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractItemForecasts_SalePrograms_SaleProgramId",
                        column: x => x.SaleProgramId,
                        principalTable: "SalePrograms",
                        principalColumn: "Id");
                });

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
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2385), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Creator", "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2530), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2559), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2581), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2603), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2624), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2674), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2704), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2725), null, null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "ForecastStateEnum", "SaleProgramId", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 9, 53, 306, DateTimeKind.Local).AddTicks(2800), null, null, 0 });

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
                table: "SalePrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContractItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalePrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContractItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 16, 9, 53, 305, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.CreateIndex(
                name: "IX_ContractItems_SaleProgramId",
                table: "ContractItems",
                column: "SaleProgramId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContractItemAttachments_ContractItemId",
                table: "ContractItemAttachments",
                column: "ContractItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractItemForecasts_ContractItemId",
                table: "ContractItemForecasts",
                column: "ContractItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractItemForecasts_SaleProgramId",
                table: "ContractItemForecasts",
                column: "SaleProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractItemAttachments_ContractItems_ContractItemId",
                table: "ContractItemAttachments",
                column: "ContractItemId",
                principalTable: "ContractItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractItems_SalePrograms_SaleProgramId",
                table: "ContractItems",
                column: "SaleProgramId",
                principalTable: "SalePrograms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractItemAttachments_ContractItems_ContractItemId",
                table: "ContractItemAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractItems_SalePrograms_SaleProgramId",
                table: "ContractItems");

            migrationBuilder.DropTable(
                name: "ContractItemForecasts");

            migrationBuilder.DropIndex(
                name: "IX_ContractItems_SaleProgramId",
                table: "ContractItems");

            migrationBuilder.DropIndex(
                name: "IX_ContractItemAttachments_ContractItemId",
                table: "ContractItemAttachments");

            migrationBuilder.DropColumn(
                name: "ContractItemId",
                table: "SalePrograms");

            migrationBuilder.DropColumn(
                name: "ForecastStateEnum",
                table: "ContractItems");

            migrationBuilder.DropColumn(
                name: "SaleProgramId",
                table: "ContractItems");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ContractItems");

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Suppliers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Contracts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "ContractItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Creator",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "eef721ec-a44e-41cb-babf-4988b0d53f27", new DateTime(2023, 11, 15, 16, 34, 13, 364, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Creator", "DateCreated" },
                values: new object[] { 2, new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.AddForeignKey(
                name: "FK_ContractItemAttachments_ContractItems_Id",
                table: "ContractItemAttachments",
                column: "Id",
                principalTable: "ContractItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
