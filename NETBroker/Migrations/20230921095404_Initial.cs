using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NETBroker.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Creator = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Creator = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ControlDateType = table.Column<string>(type: "TEXT", nullable: true),
                    ControlDateModifierType = table.Column<string>(type: "TEXT", nullable: true),
                    ControlDateOffsetType = table.Column<string>(type: "TEXT", nullable: true),
                    ControlDateOffsetValue = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalePrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EnergyUnitType = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    SalesProgramType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Creator = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    UserType = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommisionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SalesProgramId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommissionConfigurationTypeId = table.Column<string>(type: "TEXT", nullable: true),
                    ProgramAdderType = table.Column<string>(type: "TEXT", nullable: true),
                    ProgramAdder = table.Column<double>(type: "REAL", nullable: true),
                    MarginPercent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommisionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommisionTypes_SalePrograms_SalesProgramId",
                        column: x => x.SalesProgramId,
                        principalTable: "SalePrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposits_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    LegalEntityName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false),
                    CloserId = table.Column<int>(type: "INTEGER", nullable: true),
                    FronterId = table.Column<int>(type: "INTEGER", nullable: true),
                    SoldDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BillingChargeType = table.Column<int>(type: "INTEGER", nullable: false),
                    BillingType = table.Column<int>(type: "INTEGER", nullable: false),
                    EnrollmentType = table.Column<int>(type: "INTEGER", nullable: false),
                    PricingType = table.Column<int>(type: "INTEGER", nullable: false),
                    UserProfileId = table.Column<int>(type: "INTEGER", nullable: true),
                    Creator = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Users_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContractId = table.Column<int>(type: "INTEGER", nullable: false),
                    UtilityAccountNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TermMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductType = table.Column<string>(type: "TEXT", nullable: true),
                    EnergyUnitType = table.Column<string>(type: "TEXT", nullable: true),
                    AnnualUsage = table.Column<int>(type: "INTEGER", nullable: true),
                    Rate = table.Column<decimal>(type: "TEXT", nullable: true),
                    Adder = table.Column<decimal>(type: "TEXT", nullable: true),
                    Creator = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractItems_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Creator", "DateCreated", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(2173), true, "Contact 1" },
                    { 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(2178), true, "Contact 2" },
                    { 3, 1, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(2179), true, "Contact 3" },
                    { 4, 1, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(2180), true, "Contact 4" },
                    { 5, 1, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(2181), true, "Contact 5" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Creator", "DateCreated", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(599), true, "Customer 1" },
                    { 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(604), true, "Customer 2" },
                    { 3, 2, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(605), true, "Customer 3" },
                    { 4, 2, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(606), true, "Customer 4" },
                    { 5, 3, new DateTime(2023, 9, 21, 16, 54, 4, 593, DateTimeKind.Local).AddTicks(607), true, "Customer 5" }
                });

            migrationBuilder.InsertData(
                table: "SalePrograms",
                columns: new[] { "Id", "Description", "EnergyUnitType", "SalesProgramType" },
                values: new object[,]
                {
                    { 1, "50% contract upfront then residual", "KWH", "PercentageContractUpfront + PercentageContractResidual" },
                    { 2, "Forecast annual margin divided by four", "THM", "QuarterlyUpfront" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Creator", "DateCreated", "IsActive", "Name" },
                values: new object[] { 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(7153), true, "IGS" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDay", "DateCreated", "FullName", "IsActive", "PasswordHash", "Phone", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "", null, new DateTime(2023, 9, 21, 16, 54, 4, 579, DateTimeKind.Local).AddTicks(1541), "Admin", true, "V79qBaPpcUa+25VP7/kZSAnFXcwiRVEbLf9Ty493CjR252jtonOUmSupDRUiMLUN", "", "admin", 1 },
                    { 2, "", null, new DateTime(2023, 9, 21, 16, 54, 4, 585, DateTimeKind.Local).AddTicks(7902), "User", true, "OBKZ9okBUcXk9mKpDYJrzpXNtWP7ic9UdNOR+gZlRnSsGQgQny89EX9uH/ZnWWQA", "", "user", 0 },
                    { 3, "", null, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(3953), "Partner", true, "Eo19PoEUbmCa2L206YwQ4/5bCKfnXZWRXBlUUnIUNQ2S7AT2TEi3Bv31rWhp86vm", "", "partner", 2 }
                });

            migrationBuilder.InsertData(
                table: "CommisionTypes",
                columns: new[] { "Id", "CommissionConfigurationTypeId", "MarginPercent", "ProgramAdder", "ProgramAdderType", "SalesProgramId" },
                values: new object[,]
                {
                    { 1, "ContractUpfront", "0.5", 0.0070000000000000001, "Override", 1 },
                    { 2, "PercentageContractResidual", "0.5", 0.0070000000000000001, "Override", 1 },
                    { 3, "QuarterlyUpfront", "x", 0.0070000000000000001, "Override", 2 }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "BillingChargeType", "BillingType", "CloserId", "ContactId", "Creator", "CustomerId", "DateCreated", "EnrollmentType", "FronterId", "IsActive", "LegalEntityName", "PricingType", "SoldDate", "SupplierId", "UserProfileId" },
                values: new object[,]
                {
                    { 1, 0, 0, 1, 1, 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8608), 0, 1, true, "John A", 0, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, 0, 0, null, 1, 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8614), 0, null, true, "John B", 0, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Deposits",
                columns: new[] { "Id", "Amount", "PaymentDate", "SupplierId" },
                values: new object[,]
                {
                    { 1, 156.34m, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 19.25m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 8.75m, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "ContractItems",
                columns: new[] { "Id", "Adder", "AnnualUsage", "ContractId", "Creator", "DateCreated", "EndDate", "EnergyUnitType", "IsActive", "ProductType", "Rate", "StartDate", "TermMonth", "UtilityAccountNumber" },
                values: new object[,]
                {
                    { 1, 0.0075m, 58398, 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8916), new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "KWH", true, "Elec", 0.01275m, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "9138014006" },
                    { 2, 0.073m, 12303, 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8923), new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "CCF", true, "Gas", 0.2275m, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "9138014006" },
                    { 3, 6.3m, 835, 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8925), new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "MWH", true, "Elec", 23m, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "9138014006" },
                    { 4, 0.0073m, 160880, 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8927), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "KWH", true, "Elec", 0.02275m, new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "9138014006" },
                    { 5, 0.083m, 89340, 1, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8928), new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "THM", true, "Gas", 0.3275m, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "9138014006" },
                    { 6, 0.003m, 36000, 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8930), new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "KWH", true, "Elec", 0.0225m, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "177478640021" },
                    { 7, 0.073m, 4200, 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8932), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "MCF", true, "Gas", 2.275m, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "177478640021" },
                    { 8, 5.32m, 1500, 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8933), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MWH", true, "Elec", 20.75m, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "177478640021" },
                    { 9, 0.053m, 60000, 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8937), new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "CCF", true, "Gas", 0.1275m, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "177478640021" },
                    { 10, 0.0033m, 15000, 2, 1, new DateTime(2023, 9, 21, 16, 54, 4, 592, DateTimeKind.Local).AddTicks(8939), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "KWH", true, "Elec", 0.04275m, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "177478640021" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommisionTypes_SalesProgramId",
                table: "CommisionTypes",
                column: "SalesProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractItems_ContractId",
                table: "ContractItems",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContactId",
                table: "Contracts",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SupplierId",
                table: "Contracts",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_UserProfileId",
                table: "Contracts",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_SupplierId",
                table: "Deposits",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommisionTypes");

            migrationBuilder.DropTable(
                name: "ContractItems");

            migrationBuilder.DropTable(
                name: "DateConfigs");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "SalePrograms");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
