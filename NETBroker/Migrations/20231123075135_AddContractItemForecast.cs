using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETBroker.Migrations
{
    /// <inheritdoc />
    public partial class AddContractItemForecast : Migration
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
                values: new object[] { "dfa4ee96-f489-4297-b532-f44d8d572633", new DateTime(2023, 11, 23, 14, 51, 35, 246, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6464), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Creator", "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { 1, new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6610), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6637), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6659), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6679), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6699), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6718), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6740), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6760), null, 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "ForecastStateEnum", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(6794), null, 0 });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(8539));

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
                value: new DateTime(2023, 11, 23, 14, 51, 35, 247, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.CreateIndex(
                name: "IX_SalePrograms_ContractItemId",
                table: "SalePrograms",
                column: "ContractItemId");

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
                name: "FK_SalePrograms_ContractItems_ContractItemId",
                table: "SalePrograms",
                column: "ContractItemId",
                principalTable: "ContractItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractItemAttachments_ContractItems_ContractItemId",
                table: "ContractItemAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_SalePrograms_ContractItems_ContractItemId",
                table: "SalePrograms");

            migrationBuilder.DropTable(
                name: "ContractItemForecasts");

            migrationBuilder.DropIndex(
                name: "IX_SalePrograms_ContractItemId",
                table: "SalePrograms");

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
