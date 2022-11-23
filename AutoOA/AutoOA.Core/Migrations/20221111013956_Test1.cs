using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoOA.Core.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyTypes",
                columns: table => new
                {
                    BodyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTypes", x => x.BodyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DriveTypes",
                columns: table => new
                {
                    DriveTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriveTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveTypes", x => x.DriveTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    FuelTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.FuelTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GearBoxes",
                columns: table => new
                {
                    GearBoxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearBoxName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBoxes", x => x.GearBoxId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrands",
                columns: table => new
                {
                    VehicleBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleBrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrands", x => x.VehicleBrandId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "VehicleModels",
                columns: table => new
                {
                    VehicleModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.VehicleModelId);
                    table.ForeignKey(
                        name: "FK_VehicleModels_VehicleBrands_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrands",
                        principalColumn: "VehicleBrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    BodyTypeId = table.Column<int>(type: "int", nullable: false),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false),
                    ProductionYear = table.Column<short>(type: "smallint", nullable: false),
                    GearBoxId = table.Column<int>(type: "int", nullable: false),
                    DriveTypeId = table.Column<int>(type: "int", nullable: false),
                    StateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "int", nullable: false),
                    Price_USD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price_UAH = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price_EUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    isNew = table.Column<bool>(type: "bit", nullable: false),
                    MileageIconPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    VehicleIconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicles_BodyTypes_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "BodyTypes",
                        principalColumn: "BodyTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_DriveTypes_DriveTypeId",
                        column: x => x.DriveTypeId,
                        principalTable: "DriveTypes",
                        principalColumn: "DriveTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "FuelTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_GearBoxes_GearBoxId",
                        column: x => x.GearBoxId,
                        principalTable: "GearBoxes",
                        principalColumn: "GearBoxId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesData",
                columns: table => new
                {
                    SalesDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesData", x => x.SalesDataId);
                    table.ForeignKey(
                        name: "FK_SalesData_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44a88983-2598-49cd-b95f-8e746169355f", "8f9f0bde-84d4-4a0e-b695-7a810127a469", "User", "USER" },
                    { "5b5eb146-f804-462b-b01f-402b29b11126", "53c72ccd-a285-475f-9b42-02afaada233b", "Moderator", "MODERATOR" },
                    { "5ba4c78b-46e8-4469-bbda-12b7921a5542", "d5a65055-ac59-46e0-b367-d774ab086e8e", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "185b9852-e964-4c08-8a88-1369b3db3abc", 0, "2816b326-a97e-493a-b3ad-ff79faef7564", "moder@autooa.com", true, null, null, false, null, "MODER@AUTOOA.COM", "MODER@AUTOOA.COM", "AQAAAAEAACcQAAAAELqjt+N2toNlhl7vo46F3pCLFscx2IZONqlnlmAml0WwF5GXYODw/430PIDhjtov7w==", null, false, "4c9f0ce2-d72b-4ce0-a9b5-85cb1c97bc16", false, "moder@autooa.com" },
                    { "1d07ac3e-4496-4892-92ea-c3012fce0ae9", 0, "22dfe745-ba48-436f-9e2b-18c541e39391", "admin@autooa.com", true, null, null, false, null, "ADMIN@AUTOOA.COM", "ADMIN@AUTOOA.COM", "AQAAAAEAACcQAAAAEDy1GZO7dJX4q8nr0futIMXWxUlVZbBq4N2Kurfp8GqbXTagKXrVd+JpHsLps7pAoQ==", null, false, "18f72b16-d29a-4f39-9020-3b8f7e6be86e", false, "admin@autooa.com" },
                    { "39a8ae83-9e39-4d35-b694-67b4b324cc7e", 0, "a5f8cf37-3f65-4607-9405-6b71afffe516", "user@autooa.com", true, null, null, false, null, "USER@AUTOOA.COM", "USER@AUTOOA.COM", "AQAAAAEAACcQAAAAEMU5DtGMG3KHsie8XXkb2auWb61OBhBnmFqbE1wQ93xv4aprY0/xpQzSnevxFQwJpg==", null, false, "2157aa87-ed3c-4acc-a6f7-ca3a7642cb1a", false, "user@autooa.com" }
                });

            migrationBuilder.InsertData(
                table: "BodyTypes",
                columns: new[] { "BodyTypeId", "BodyTypeName", "IconPath" },
                values: new object[,]
                {
                    { 1, "Седан", "\\Images\\BodyTypeIcon.png" },
                    { 2, "Універсал", "\\Images\\BodyTypeIcon.png" },
                    { 3, "Хетчбек", "\\Images\\BodyTypeIcon.png" },
                    { 4, "Купе", "\\Images\\BodyTypeIcon.png" },
                    { 5, "Кабріолет", "\\Images\\BodyTypeIcon.png" },
                    { 6, "Позашляховик / Кросовер", "\\Images\\BodyTypeIcon.png" },
                    { 7, "Мінівен", "\\Images\\BodyTypeIcon.png" },
                    { 8, "Ліфтбек", "\\Images\\BodyTypeIcon.png" },
                    { 9, "Мікровен", "\\Images\\BodyTypeIcon.png" },
                    { 10, "Пікап", "\\Images\\BodyTypeIcon.png" },
                    { 11, "Родстер", "\\Images\\BodyTypeIcon.png" },
                    { 12, "Лімузин", "\\Images\\BodyTypeIcon.png" },
                    { 13, "Фастбек", "\\Images\\BodyTypeIcon.png" }
                });

            migrationBuilder.InsertData(
                table: "DriveTypes",
                columns: new[] { "DriveTypeId", "DriveTypeName" },
                values: new object[,]
                {
                    { 1, "Повний" },
                    { 2, "Передній" },
                    { 3, "Задній" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "FuelTypeId", "FuelName", "IconPath" },
                values: new object[,]
                {
                    { 1, "Дизель", "\\Images\\fuelTypeIcon.png" },
                    { 2, "Бензин", "\\Images\\fuelTypeIcon.png" },
                    { 3, "Газ", "\\Images\\fuelTypeIcon.png" },
                    { 4, "Газ / Бензин", "\\Images\\fuelTypeIcon.png" },
                    { 5, "Гібрид", "\\Images\\fuelTypeIcon.png" },
                    { 6, "Електро", "\\Images\\fuelTypeIcon.png" },
                    { 7, "Інше", "\\Images\\fuelTypeIcon.png" },
                    { 8, "Газ метан", "\\Images\\fuelTypeIcon.png" },
                    { 9, "Газ пропан-бутан", "\\Images\\fuelTypeIcon.png" }
                });

            migrationBuilder.InsertData(
                table: "GearBoxes",
                columns: new[] { "GearBoxId", "GearBoxName", "IconPath" },
                values: new object[,]
                {
                    { 1, "Ручна / Механіка", "\\Images\\gearBoxIcon.png" },
                    { 2, "Автомат", "\\Images\\gearBoxIcon.png" },
                    { 3, "Типтронік", "\\Images\\gearBoxIcon.png" },
                    { 4, "Робот", "\\Images\\gearBoxIcon.png" },
                    { 5, "Варіатор", "\\Images\\gearBoxIcon.png" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "RegionName" },
                values: new object[] { 1, "Ukraine" });

            migrationBuilder.InsertData(
                table: "VehicleBrands",
                columns: new[] { "VehicleBrandId", "VehicleBrandName" },
                values: new object[,]
                {
                    { 1, "Mercedes" },
                    { 2, "Bmw" },
                    { 3, "Acura" },
                    { 4, "Alfa Romeo" },
                    { 5, "Alphina" }
                });

            migrationBuilder.InsertData(
                table: "VehicleBrands",
                columns: new[] { "VehicleBrandId", "VehicleBrandName" },
                values: new object[] { 6, "Audi" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "44a88983-2598-49cd-b95f-8e746169355f", "185b9852-e964-4c08-8a88-1369b3db3abc" },
                    { "5b5eb146-f804-462b-b01f-402b29b11126", "185b9852-e964-4c08-8a88-1369b3db3abc" },
                    { "44a88983-2598-49cd-b95f-8e746169355f", "1d07ac3e-4496-4892-92ea-c3012fce0ae9" },
                    { "5b5eb146-f804-462b-b01f-402b29b11126", "1d07ac3e-4496-4892-92ea-c3012fce0ae9" },
                    { "5ba4c78b-46e8-4469-bbda-12b7921a5542", "1d07ac3e-4496-4892-92ea-c3012fce0ae9" },
                    { "44a88983-2598-49cd-b95f-8e746169355f", "39a8ae83-9e39-4d35-b694-67b4b324cc7e" }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "VehicleModelId", "VehicleBrandId", "VehicleModelName" },
                values: new object[,]
                {
                    { 1, 1, "E 220" },
                    { 2, 2, "320" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "BodyTypeId", "Color", "Description", "DriveTypeId", "FuelTypeId", "GearBoxId", "Mileage", "MileageIconPath", "NumberOfDoors", "NumberOfSeats", "Price_EUR", "Price_UAH", "Price_USD", "ProductionYear", "RegionId", "StateNumber", "UserId", "VehicleIconPath", "VehicleModelId", "isNew" },
                values: new object[] { 1, 1, "Black", "Авто в дуже хорошому стані. Повністтю обслужене. Капіталовкладень не потребує.", 1, 1, 1, 90000, "\\Images\\MileageIcon.png", 5, 4, 18968.65m, 698187.11m, 19000m, (short)2006, 1, "Не задано", "39a8ae83-9e39-4d35-b694-67b4b324cc7e", "\\Images\\w220cidan.png", 1, true });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "BodyTypeId", "Color", "Description", "DriveTypeId", "FuelTypeId", "GearBoxId", "Mileage", "MileageIconPath", "NumberOfDoors", "NumberOfSeats", "Price_EUR", "Price_UAH", "Price_USD", "ProductionYear", "RegionId", "StateNumber", "UserId", "VehicleIconPath", "VehicleModelId", "isNew" },
                values: new object[] { 2, 2, "Gray", "Продаю свій автомобіль у хорошому стані. Зроблено всі планові роботи, все працює добре. Є невеликі подряпини, пов'язані з експлуатацією.", 3, 2, 2, 320000, "\\Images\\MileageIcon.png", 5, 4, 14976.07m, 551200.35m, 15000m, (short)2000, 1, "Не задано", "39a8ae83-9e39-4d35-b694-67b4b324cc7e", "\\Images\\320Universal.png", 2, false });

            migrationBuilder.InsertData(
                table: "SalesData",
                columns: new[] { "SalesDataId", "CreatedOn", "UpdatedOn", "VehicleId" },
                values: new object[] { 1, new DateTime(2022, 11, 11, 3, 39, 56, 476, DateTimeKind.Local).AddTicks(7849), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "SalesData",
                columns: new[] { "SalesDataId", "CreatedOn", "UpdatedOn", "VehicleId" },
                values: new object[] { 2, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SalesData_VehicleId",
                table: "SalesData",
                column: "VehicleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_VehicleBrandId",
                table: "VehicleModels",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyTypeId",
                table: "Vehicles",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriveTypeId",
                table: "Vehicles",
                column: "DriveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelTypeId",
                table: "Vehicles",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_GearBoxId",
                table: "Vehicles",
                column: "GearBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_RegionId",
                table: "Vehicles",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UserId",
                table: "Vehicles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleModelId",
                table: "Vehicles",
                column: "VehicleModelId");
        }

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
                name: "SalesData");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BodyTypes");

            migrationBuilder.DropTable(
                name: "DriveTypes");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "GearBoxes");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "VehicleBrands");
        }
    }
}
