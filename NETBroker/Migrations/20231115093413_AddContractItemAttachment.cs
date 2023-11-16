using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETBroker.Migrations
{
    /// <inheritdoc />
    public partial class AddContractItemAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "Contracts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ContractItemAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilePath = table.Column<string>(type: "TEXT", nullable: true),
                    FileName = table.Column<string>(type: "TEXT", nullable: false),
                    FileType = table.Column<string>(type: "TEXT", nullable: false),
                    ContractItemId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractItemAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractItemAttachments_ContractItems_Id",
                        column: x => x.Id,
                        principalTable: "ContractItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5093), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5243), 2 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5273), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5294), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5315), 2 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5334), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5354), 2 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5377), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5397), 2 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(5417), 1 });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Stage" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(2400), 0 });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Stage", "SupplierId" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 34, 13, 365, DateTimeKind.Local).AddTicks(2410), 0, 2 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractItemAttachments");

            migrationBuilder.DropColumn(
                name: "Stage",
                table: "Contracts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "6cdab079-9aab-4013-892d-e0c46406a634", new DateTime(2023, 10, 26, 16, 54, 4, 644, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1268), 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1272), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1275), 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1276), 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1277), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1279), 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1280), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1281), 0 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1283), 1 });

            migrationBuilder.UpdateData(
                table: "ContractItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "ProductType" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1284), 0 });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "SupplierId" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(943), 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 16, 54, 4, 644, DateTimeKind.Local).AddTicks(9443));
        }
    }
}
