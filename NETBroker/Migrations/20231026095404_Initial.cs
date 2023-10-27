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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    BirthDay = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommissionConfigurationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommissionConfigurationTypes", x => x.Id);
                });

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
                    ControlDateOffsetType = table.Column<int>(type: "INTEGER", nullable: false),
                    ControlDateOffsetValue = table.Column<decimal>(type: "TEXT", nullable: false)
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
                    EnergyUnitType = table.Column<int>(type: "INTEGER", nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommisionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommissionConfigurationTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateConfigId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProgramAdderType = table.Column<int>(type: "INTEGER", nullable: false),
                    ProgramAdder = table.Column<double>(type: "REAL", nullable: true),
                    MarginPercent = table.Column<decimal>(type: "TEXT", nullable: false),
                    SalesProgramId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommisionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommisionTypes_CommissionConfigurationTypes_CommissionConfigurationTypeId",
                        column: x => x.CommissionConfigurationTypeId,
                        principalTable: "CommissionConfigurationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommisionTypes_DateConfigs_DateConfigId",
                        column: x => x.DateConfigId,
                        principalTable: "DateConfigs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommisionTypes_SalePrograms_SalesProgramId",
                        column: x => x.SalesProgramId,
                        principalTable: "SalePrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SalesProgramId = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    FromAnnualUsage = table.Column<int>(type: "INTEGER", nullable: true),
                    ToAnnualUsage = table.Column<int>(type: "INTEGER", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualifications_SalePrograms_SalesProgramId",
                        column: x => x.SalesProgramId,
                        principalTable: "SalePrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LegalEntityName = table.Column<string>(type: "TEXT", nullable: false),
                    SoldDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BillingChargeType = table.Column<int>(type: "INTEGER", nullable: false),
                    BillingType = table.Column<int>(type: "INTEGER", nullable: false),
                    EnrollmentType = table.Column<int>(type: "INTEGER", nullable: false),
                    PricingType = table.Column<int>(type: "INTEGER", nullable: false),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false),
                    CloserId = table.Column<int>(type: "INTEGER", nullable: true),
                    FronterId = table.Column<int>(type: "INTEGER", nullable: true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Creator = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_AspNetUsers_CloserId",
                        column: x => x.CloserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contracts_AspNetUsers_FronterId",
                        column: x => x.FronterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "ContractItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContractId = table.Column<int>(type: "INTEGER", nullable: false),
                    UtilityAccountNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TermMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductType = table.Column<int>(type: "INTEGER", nullable: false),
                    EnergyUnitType = table.Column<int>(type: "INTEGER", nullable: false),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "User", "USER" },
                    { 3, null, "Partner", "PARTNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, null, null, "6cdab079-9aab-4013-892d-e0c46406a634", new DateTime(2023, 10, 26, 16, 54, 4, 644, DateTimeKind.Local).AddTicks(6516), "admin@example.com", true, "Admin", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", null, null, true, null, false, "admin" });

            migrationBuilder.InsertData(
                table: "CommissionConfigurationTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ContractUpfront" },
                    { 2, "PercentageContractResidual" },
                    { 3, "QuarterlyUpfront" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Creator", "DateCreated", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4316), true, "Contact 1" },
                    { 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4320), true, "Contact 2" },
                    { 3, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4321), true, "Contact 3" },
                    { 4, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4321), true, "Contact 4" },
                    { 5, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(4322), true, "Contact 5" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Creator", "DateCreated", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2759), true, "Customer 1" },
                    { 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2764), true, "Customer 2" },
                    { 3, 2, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2765), true, "Customer 3" },
                    { 4, 2, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2765), true, "Customer 4" },
                    { 5, 3, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(2766), true, "Customer 5" }
                });

            migrationBuilder.InsertData(
                table: "DateConfigs",
                columns: new[] { "Id", "ControlDateModifierType", "ControlDateOffsetType", "ControlDateOffsetValue", "ControlDateType" },
                values: new object[,]
                {
                    { 1, "NoModifier", 5, 2m, "SoldDate" },
                    { 2, "NoModifier", 0, 2m, "SoldDate" },
                    { 3, "NoModifier", 0, 2m, "SoldDate" }
                });

            migrationBuilder.InsertData(
                table: "SalePrograms",
                columns: new[] { "Id", "Description", "EnergyUnitType", "SalesProgramType" },
                values: new object[,]
                {
                    { 1, "50% contract upfront then residual", 0, "PercentageContractUpfront + PercentageContractResidual" },
                    { 2, "Forecast annual margin divided by four", 3, "QuarterlyUpfront" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Creator", "DateCreated", "IsActive", "Name" },
                values: new object[] { 1, 1, new DateTime(2023, 10, 26, 16, 54, 4, 644, DateTimeKind.Local).AddTicks(9443), true, "IGS" });

            migrationBuilder.InsertData(
                table: "CommisionTypes",
                columns: new[] { "Id", "CommissionConfigurationTypeId", "DateConfigId", "MarginPercent", "ProgramAdder", "ProgramAdderType", "SalesProgramId" },
                values: new object[,]
                {
                    { 1, 1, 1, 0.5m, 0.0070000000000000001, 1, 1 },
                    { 2, 2, 2, 0.5m, 0.0070000000000000001, 1, 1 },
                    { 3, 3, 3, 0m, 0.0070000000000000001, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "BillingChargeType", "BillingType", "CloserId", "ContactId", "Creator", "CustomerId", "DateCreated", "EnrollmentType", "FronterId", "IsActive", "LegalEntityName", "PricingType", "SoldDate", "SupplierId" },
                values: new object[,]
                {
                    { 1, 0, 0, 1, 1, 1, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(936), 0, 1, true, "John A", 0, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 0, 0, 1, 1, 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(943), 0, 1, true, "John B", 0, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
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
                table: "Qualifications",
                columns: new[] { "Id", "Discriminator", "EffectiveDate", "ExpiryDate", "SalesProgramId" },
                values: new object[,]
                {
                    { 1, "ExpirationQualification", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "ExpirationQualification", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2099, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "Id", "Discriminator", "FromAnnualUsage", "SalesProgramId", "ToAnnualUsage" },
                values: new object[] { 3, "AnnualUssageQualification", 50000, 2, 100000 });

            migrationBuilder.InsertData(
                table: "ContractItems",
                columns: new[] { "Id", "Adder", "AnnualUsage", "ContractId", "Creator", "DateCreated", "EnergyUnitType", "IsActive", "ProductType", "Rate", "StartDate", "TermMonth", "UtilityAccountNumber" },
                values: new object[,]
                {
                    { 1, 0.0075m, 58398, 1, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1268), 0, true, 0, 0.01275m, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "9138014006" },
                    { 2, 0.073m, 12303, 1, 2, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1272), 1, true, 1, 0.2275m, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "9138014006" },
                    { 3, 6.3m, 835, 1, 3, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1275), 2, true, 0, 23m, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "9138014006" },
                    { 4, 0.0073m, 160880, 1, 4, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1276), 0, true, 0, 0.02275m, new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "9138014006" },
                    { 5, 0.083m, 89340, 1, 5, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1277), 3, true, 1, 0.3275m, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "9138014006" },
                    { 6, 0.003m, 36000, 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1279), 0, true, 0, 0.0225m, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "177478640021" },
                    { 7, 0.073m, 4200, 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1280), 4, true, 1, 2.275m, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "177478640021" },
                    { 8, 5.32m, 1500, 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1281), 2, true, 0, 20.75m, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "177478640021" },
                    { 9, 0.053m, 60000, 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1283), 1, true, 1, 0.1275m, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "177478640021" },
                    { 10, 0.0033m, 15000, 2, 1, new DateTime(2023, 10, 26, 16, 54, 4, 645, DateTimeKind.Local).AddTicks(1284), 0, true, 0, 0.04275m, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "177478640021" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommisionTypes_CommissionConfigurationTypeId",
                table: "CommisionTypes",
                column: "CommissionConfigurationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommisionTypes_DateConfigId",
                table: "CommisionTypes",
                column: "DateConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_CommisionTypes_SalesProgramId",
                table: "CommisionTypes",
                column: "SalesProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractItems_ContractId",
                table: "ContractItems",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CloserId",
                table: "Contracts",
                column: "CloserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContactId",
                table: "Contracts",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_FronterId",
                table: "Contracts",
                column: "FronterId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SupplierId",
                table: "Contracts",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_SupplierId",
                table: "Deposits",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_SalesProgramId",
                table: "Qualifications",
                column: "SalesProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CommisionTypes");

            migrationBuilder.DropTable(
                name: "ContractItems");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CommissionConfigurationTypes");

            migrationBuilder.DropTable(
                name: "DateConfigs");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "SalePrograms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
