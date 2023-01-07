using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Setup");

            migrationBuilder.EnsureSchema(
                name: "Core");

            migrationBuilder.EnsureSchema(
                name: "Auth");

            migrationBuilder.EnsureSchema(
                name: "Logs");

            migrationBuilder.CreateTable(
                name: "UserStatus",
                schema: "Auth",
                columns: table => new
                {
                    UserStatusId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserStatusNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserStatusDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.UserStatusId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Auth",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UserStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UserId1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_User_UserId1",
                        column: x => x.UserId1,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_User_UserStatus_UserStatusId",
                        column: x => x.UserStatusId,
                        principalSchema: "Auth",
                        principalTable: "UserStatus",
                        principalColumn: "UserStatusId");
                });

            migrationBuilder.CreateTable(
                name: "AccountHead",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountHead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountHead_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AddressType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bank_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessRepStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessRepStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessRepStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ClearingAgent",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClearingAgent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClearingAgent_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CustomCollectorate",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomCollectorate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomCollectorate_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "District",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "GlobalRight",
                schema: "Auth",
                columns: table => new
                {
                    GRightId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRightName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GRightNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GRightDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    IsOnResourceLevel = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalRight", x => x.GRightId);
                    table.ForeignKey(
                        name: "FK_GlobalRight_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                schema: "Logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationCategory",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationCategory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OwnerStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OwnerTaxGroup",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerTaxGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerTaxGroup_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OwnerType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumberType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Port",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Port", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Port_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "RequestLog",
                schema: "Logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Json = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExceptionResponse = table.Column<bool>(type: "bit", nullable: false),
                    LogBySource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ResourceAction",
                schema: "Auth",
                columns: table => new
                {
                    ResourceActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceAction", x => x.ResourceActionId);
                    table.ForeignKey(
                        name: "FK_ResourceAction_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ResourceController",
                schema: "Auth",
                columns: table => new
                {
                    ResourceControllerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceController", x => x.ResourceControllerId);
                    table.ForeignKey(
                        name: "FK_ResourceController_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ResourceType",
                schema: "Auth",
                columns: table => new
                {
                    ResourceTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResourceTypeNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ResourceTypeDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceType", x => x.ResourceTypeId);
                    table.ForeignKey(
                        name: "FK_ResourceType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Auth",
                columns: table => new
                {
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Role_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleBodyConvention",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBodyConvention", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBodyConvention_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleBodyType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBodyType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBodyType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategory",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleCategory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClass",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClass_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassification",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClassification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClassification_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleColor",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleColor_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocumentType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocumentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleDocumentType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleEngineType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleEngineType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleEngineType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleFuelType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFuelType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleFuelType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleMake",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleMake_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleMaker",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMaker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleMaker_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehiclePurchaseType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePurchaseType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleRCStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRCStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleRCStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleScheme",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleScheme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleScheme_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleUsage",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUsage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleUsage_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessSector",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessSector", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessSector_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalSchema: "Setup",
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessSector_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Core",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OldCNIC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Tehsil",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tehsil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tehsil_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tehsil_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                schema: "Core",
                columns: table => new
                {
                    OwnerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_Owner_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Owner_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalSchema: "Setup",
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Owner_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                schema: "Auth",
                columns: table => new
                {
                    ResourceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResourceNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ResourceDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ResourceEndPoint = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    ControllerId = table.Column<long>(type: "bigint", nullable: true),
                    ActionId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceId);
                    table.ForeignKey(
                        name: "FK_Resource_ResourceAction_ActionId",
                        column: x => x.ActionId,
                        principalSchema: "Auth",
                        principalTable: "ResourceAction",
                        principalColumn: "ResourceActionId");
                    table.ForeignKey(
                        name: "FK_Resource_ResourceController_ControllerId",
                        column: x => x.ControllerId,
                        principalSchema: "Auth",
                        principalTable: "ResourceController",
                        principalColumn: "ResourceControllerId");
                    table.ForeignKey(
                        name: "FK_Resource_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "Auth",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId");
                    table.ForeignKey(
                        name: "FK_Resource_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ResourceTypeRight",
                schema: "Auth",
                columns: table => new
                {
                    RTRightId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    RTRightName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RTRightNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RTRightDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    IsGlobalRef = table.Column<bool>(type: "bit", nullable: false),
                    GRightId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceTypeRight", x => x.RTRightId);
                    table.ForeignKey(
                        name: "FK_ResourceTypeRight_GlobalRight_GRightId",
                        column: x => x.GRightId,
                        principalSchema: "Auth",
                        principalTable: "GlobalRight",
                        principalColumn: "GRightId");
                    table.ForeignKey(
                        name: "FK_ResourceTypeRight_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "Auth",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId");
                    table.ForeignKey(
                        name: "FK_ResourceTypeRight_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "Auth",
                columns: table => new
                {
                    UserRoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    IsTimeBased = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_UserRole_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserRoleHistory",
                schema: "Auth",
                columns: table => new
                {
                    UserRoleHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleHistory", x => x.UserRoleHistoryId);
                    table.ForeignKey(
                        name: "FK_UserRoleHistory_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_UserRoleHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_UserRoleHistory_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Business",
                schema: "Core",
                columns: table => new
                {
                    BusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessSectorId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRegNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessId);
                    table.ForeignKey(
                        name: "FK_Business_BusinessSector_BusinessSectorId",
                        column: x => x.BusinessSectorId,
                        principalSchema: "Setup",
                        principalTable: "BusinessSector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_BusinessStatus_BusinessStatusId",
                        column: x => x.BusinessStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalSchema: "Setup",
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                schema: "Core",
                columns: table => new
                {
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyConventionId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleColorId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleEngineTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleFuelTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakerId = table.Column<long>(type: "bigint", nullable: true),
                    VehiclePurchaseTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleRCStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: true),
                    ManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    NoOfCylinder = table.Column<int>(type: "int", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    ChasisNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    WheelBase = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Vehicle_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBodyConvention_VehicleBodyConventionId",
                        column: x => x.VehicleBodyConventionId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyConvention",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleColor_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalSchema: "Setup",
                        principalTable: "VehicleColor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleEngineType_VehicleEngineTypeId",
                        column: x => x.VehicleEngineTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleEngineType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleFuelType_VehicleFuelTypeId",
                        column: x => x.VehicleFuelTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleFuelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMake_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehiclePurchaseType_VehiclePurchaseTypeId",
                        column: x => x.VehiclePurchaseTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehiclePurchaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleRCStatus_VehicleRCStatusId",
                        column: x => x.VehicleRCStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleRCStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleResource",
                schema: "Auth",
                columns: table => new
                {
                    RoleResourceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleResource", x => x.RoleResourceId);
                    table.ForeignKey(
                        name: "FK_RoleResource_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalSchema: "Auth",
                        principalTable: "Resource",
                        principalColumn: "ResourceId");
                    table.ForeignKey(
                        name: "FK_RoleResource_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_RoleResource_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "RoleResourceRightsHistory",
                schema: "Auth",
                columns: table => new
                {
                    RoleRightsHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleResourceRightsHistory", x => x.RoleRightsHistoryId);
                    table.ForeignKey(
                        name: "FK_RoleResourceRightsHistory_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalSchema: "Auth",
                        principalTable: "Resource",
                        principalColumn: "ResourceId");
                    table.ForeignKey(
                        name: "FK_RoleResourceRightsHistory_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_RoleResourceRightsHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ResourceTypeDefaultRight",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RTRightId = table.Column<long>(type: "bigint", nullable: false),
                    DefaultRTRightId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceTypeDefaultRight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceTypeDefaultRight_ResourceTypeRight_DefaultRTRightId",
                        column: x => x.DefaultRTRightId,
                        principalSchema: "Auth",
                        principalTable: "ResourceTypeRight",
                        principalColumn: "RTRightId");
                    table.ForeignKey(
                        name: "FK_ResourceTypeDefaultRight_ResourceTypeRight_RTRightId",
                        column: x => x.RTRightId,
                        principalSchema: "Auth",
                        principalTable: "ResourceTypeRight",
                        principalColumn: "RTRightId");
                    table.ForeignKey(
                        name: "FK_ResourceTypeDefaultRight_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "Core",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    TehsilId = table.Column<long>(type: "bigint", nullable: true),
                    AddressTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalSchema: "Setup",
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_Address_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Address_Tehsil_TehsilId",
                        column: x => x.TehsilId,
                        principalTable: "Tehsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessRep",
                schema: "Core",
                columns: table => new
                {
                    BusinessRepId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRepStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    IsOwner = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessRep", x => x.BusinessRepId);
                    table.ForeignKey(
                        name: "FK_BusinessRep_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_BusinessRep_BusinessRepStatus_BusinessRepStatusId",
                        column: x => x.BusinessRepStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessRepStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessRep_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_BusinessRep_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                schema: "Core",
                columns: table => new
                {
                    DealerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.DealerId);
                    table.ForeignKey(
                        name: "FK_Dealer_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_Dealer_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OwnerGroup",
                schema: "Core",
                columns: table => new
                {
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerGroup", x => x.OwnerGroupId);
                    table.ForeignKey(
                        name: "FK_OwnerGroup_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_OwnerGroup_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_OwnerGroup_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_OwnerGroup_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                schema: "Core",
                columns: table => new
                {
                    PhoneNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumberValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumberTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_PhoneNumberType_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalSchema: "Setup",
                        principalTable: "PhoneNumberType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Keeper",
                schema: "Core",
                columns: table => new
                {
                    KeeperId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    KeeperPersonId = table.Column<long>(type: "bigint", nullable: true),
                    KeeperBusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keeper", x => x.KeeperId);
                    table.ForeignKey(
                        name: "FK_Keeper_Business_KeeperBusinessId",
                        column: x => x.KeeperBusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_Keeper_Person_KeeperPersonId",
                        column: x => x.KeeperPersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Keeper_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Keeper_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleAuctionInfo",
                schema: "Core",
                columns: table => new
                {
                    VehicleAuctionInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAuctionInfo", x => x.VehicleAuctionInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportInfo",
                schema: "Core",
                columns: table => new
                {
                    VehicleImportInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    ImporterName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImporterAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IGMNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IGMDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexNo = table.Column<long>(type: "bigint", nullable: false),
                    PlaceOfIssue = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImportPermitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PermitIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PortId = table.Column<long>(type: "bigint", nullable: false),
                    ClearingAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CustomCollectorateId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    ImportValue = table.Column<long>(type: "bigint", nullable: false),
                    CustomDuty = table.Column<long>(type: "bigint", nullable: false),
                    SalesTax = table.Column<long>(type: "bigint", nullable: false),
                    ImportLicenseFee = table.Column<long>(type: "bigint", nullable: false),
                    Insurrance = table.Column<long>(type: "bigint", nullable: false),
                    LandedCost = table.Column<long>(type: "bigint", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImportInfo", x => x.VehicleImportInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Bank_BankId",
                        column: x => x.BankId,
                        principalSchema: "Setup",
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_ClearingAgent_ClearingAgentId",
                        column: x => x.ClearingAgentId,
                        principalSchema: "Setup",
                        principalTable: "ClearingAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_CustomCollectorate_CustomCollectorateId",
                        column: x => x.CustomCollectorateId,
                        principalSchema: "Setup",
                        principalTable: "CustomCollectorate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Port_PortId",
                        column: x => x.PortId,
                        principalSchema: "Setup",
                        principalTable: "Port",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleRegistrationHistory",
                schema: "Core",
                columns: table => new
                {
                    VehicleRegHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    PreviousRegNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FirstRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRegistrationHistory", x => x.VehicleRegHistoryId);
                    table.ForeignKey(
                        name: "FK_VehicleRegistrationHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleRegistrationHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "RoleResourceRight",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleResourceId = table.Column<long>(type: "bigint", nullable: false),
                    RTRightId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleResourceRight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleResourceRight_ResourceTypeRight_RTRightId",
                        column: x => x.RTRightId,
                        principalSchema: "Auth",
                        principalTable: "ResourceTypeRight",
                        principalColumn: "RTRightId");
                    table.ForeignKey(
                        name: "FK_RoleResourceRight_RoleResource_RoleResourceId",
                        column: x => x.RoleResourceId,
                        principalSchema: "Auth",
                        principalTable: "RoleResource",
                        principalColumn: "RoleResourceId");
                    table.ForeignKey(
                        name: "FK_RoleResourceRight_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehiclePurchaseInfo",
                schema: "Core",
                columns: table => new
                {
                    VehiclePurchaseInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false),
                    DealerId = table.Column<long>(type: "bigint", nullable: false),
                    CertificateNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CertificateDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InvoiceDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePurchaseInfo", x => x.VehiclePurchaseInfoId);
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalSchema: "Core",
                        principalTable: "Dealer",
                        principalColumn: "DealerId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_VehicleScheme_VehicleSchemeId",
                        column: x => x.VehicleSchemeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleScheme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Application",
                schema: "Core",
                columns: table => new
                {
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: false),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Application_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_ApplicationType_ApplicationTypeId",
                        column: x => x.ApplicationTypeId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_OwnerGroup_OwnerGroupId",
                        column: x => x.OwnerGroupId,
                        principalSchema: "Core",
                        principalTable: "OwnerGroup",
                        principalColumn: "OwnerGroupId");
                    table.ForeignKey(
                        name: "FK_Application_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Application_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "TempApplication",
                schema: "Core",
                columns: table => new
                {
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: true),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempApplication", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_TempApplication_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempApplication_ApplicationType_ApplicationTypeId",
                        column: x => x.ApplicationTypeId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempApplication_OwnerGroup_OwnerGroupId",
                        column: x => x.OwnerGroupId,
                        principalSchema: "Core",
                        principalTable: "OwnerGroup",
                        principalColumn: "OwnerGroupId");
                    table.ForeignKey(
                        name: "FK_TempApplication_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempApplication_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "HPAHistory",
                schema: "Core",
                columns: table => new
                {
                    HPAHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LetterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HPATerminatedByUserId = table.Column<long>(type: "bigint", nullable: true),
                    HPATerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPAHistory", x => x.HPAHistoryId);
                    table.ForeignKey(
                        name: "FK_HPAHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_Business_SponserBusinessId",
                        column: x => x.SponserBusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_User_HPATerminatedByUserId",
                        column: x => x.HPATerminatedByUserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "Remarks",
                schema: "Core",
                columns: table => new
                {
                    RemarksId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: false),
                    RemarksStatement = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.RemarksId);
                    table.ForeignKey(
                        name: "FK_Remarks_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Remarks_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Remarks_OwnerGroup_OwnerGroupId",
                        column: x => x.OwnerGroupId,
                        principalSchema: "Core",
                        principalTable: "OwnerGroup",
                        principalColumn: "OwnerGroupId");
                    table.ForeignKey(
                        name: "FK_Remarks_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_Remarks_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Remarks_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "TempOwner",
                schema: "Core",
                columns: table => new
                {
                    OwnerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    ExistingOwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OldCNIC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempOwner", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_TempOwner_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempOwner_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempOwner_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalSchema: "Setup",
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempOwner_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempOwner_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicle",
                schema: "Core",
                columns: table => new
                {
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyConventionId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleColorId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleEngineTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleFuelTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakerId = table.Column<long>(type: "bigint", nullable: true),
                    VehiclePurchaseTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleRCStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: true),
                    ManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    NoOfCylinder = table.Column<int>(type: "int", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    ChasisNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    WheelBase = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_TempVehicle_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicle_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleBodyConvention_VehicleBodyConventionId",
                        column: x => x.VehicleBodyConventionId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyConvention",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleColor_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalSchema: "Setup",
                        principalTable: "VehicleColor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleEngineType_VehicleEngineTypeId",
                        column: x => x.VehicleEngineTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleEngineType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleFuelType_VehicleFuelTypeId",
                        column: x => x.VehicleFuelTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleFuelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleMake_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehiclePurchaseType_VehiclePurchaseTypeId",
                        column: x => x.VehiclePurchaseTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehiclePurchaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleRCStatus_VehicleRCStatusId",
                        column: x => x.VehicleRCStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleRCStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TempAddress",
                schema: "Core",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    AddressTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_TempAddress_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalSchema: "Setup",
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempAddress_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempAddress_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempAddress_TempOwner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "TempOwner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_TempAddress_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempPhoneNumber",
                schema: "Core",
                columns: table => new
                {
                    PhoneNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumberValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumberTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempPhoneNumber", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_PhoneNumberType_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalSchema: "Setup",
                        principalTable: "PhoneNumberType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_TempOwner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "TempOwner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempRemarks",
                schema: "Core",
                columns: table => new
                {
                    RemarksId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    RemarksStatement = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempRemarks", x => x.RemarksId);
                    table.ForeignKey(
                        name: "FK_TempRemarks_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_TempOwner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "TempOwner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicleAuctionInfo",
                schema: "Core",
                columns: table => new
                {
                    VehicleAuctionInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicleAuctionInfo", x => x.VehicleAuctionInfoId);
                    table.ForeignKey(
                        name: "FK_TempVehicleAuctionInfo_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicleAuctionInfo_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehicleAuctionInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicleDocument",
                schema: "Core",
                columns: table => new
                {
                    VehicleDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicleDocument", x => x.VehicleDocumentId);
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_VehicleDocumentType_VehicleDocumentTypeId",
                        column: x => x.VehicleDocumentTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicleImportInfo",
                schema: "Core",
                columns: table => new
                {
                    VehicleImportInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    ImporterName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImporterAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IGMNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IGMDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexNo = table.Column<long>(type: "bigint", nullable: false),
                    PlaceOfIssue = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImportPermitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PermitIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PortId = table.Column<long>(type: "bigint", nullable: false),
                    ClearingAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CustomCollectorateId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    ImportValue = table.Column<long>(type: "bigint", nullable: false),
                    CustomDuty = table.Column<long>(type: "bigint", nullable: false),
                    SalesTax = table.Column<long>(type: "bigint", nullable: false),
                    ImportLicenseFee = table.Column<long>(type: "bigint", nullable: false),
                    Insurrance = table.Column<long>(type: "bigint", nullable: false),
                    AnyOtherCost = table.Column<long>(type: "bigint", nullable: false),
                    LandedCost = table.Column<long>(type: "bigint", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicleImportInfo", x => x.VehicleImportInfoId);
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_Bank_BankId",
                        column: x => x.BankId,
                        principalSchema: "Setup",
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_ClearingAgent_ClearingAgentId",
                        column: x => x.ClearingAgentId,
                        principalSchema: "Setup",
                        principalTable: "ClearingAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_CustomCollectorate_CustomCollectorateId",
                        column: x => x.CustomCollectorateId,
                        principalSchema: "Setup",
                        principalTable: "CustomCollectorate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_Port_PortId",
                        column: x => x.PortId,
                        principalSchema: "Setup",
                        principalTable: "Port",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehiclePurchaseInfo",
                schema: "Core",
                columns: table => new
                {
                    VehiclePurchaseInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false),
                    DealerId = table.Column<long>(type: "bigint", nullable: false),
                    CertificateNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CertificateDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InvoiceDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehiclePurchaseInfo", x => x.VehiclePurchaseInfoId);
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalSchema: "Core",
                        principalTable: "Dealer",
                        principalColumn: "DealerId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_VehicleScheme_VehicleSchemeId",
                        column: x => x.VehicleSchemeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleScheme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountHead_CreatedBy",
                schema: "Setup",
                table: "AccountHead",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                schema: "Core",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_BusinessId",
                schema: "Core",
                table: "Address",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                schema: "Core",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DistrictId",
                schema: "Core",
                table: "Address",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                schema: "Core",
                table: "Address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_TehsilId",
                schema: "Core",
                table: "Address",
                column: "TehsilId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_CreatedBy",
                schema: "Setup",
                table: "AddressType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationStatusId",
                schema: "Core",
                table: "Application",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationTypeId",
                schema: "Core",
                table: "Application",
                column: "ApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_CreatedBy",
                schema: "Core",
                table: "Application",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_OwnerGroupId",
                schema: "Core",
                table: "Application",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_VehicleId",
                schema: "Core",
                table: "Application",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_CreatedBy",
                schema: "Setup",
                table: "ApplicationStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationType_CreatedBy",
                schema: "Setup",
                table: "ApplicationType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CreatedBy",
                schema: "Setup",
                table: "Bank",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessSectorId",
                schema: "Core",
                table: "Business",
                column: "BusinessSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessStatusId",
                schema: "Core",
                table: "Business",
                column: "BusinessStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessTypeId",
                schema: "Core",
                table: "Business",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_BusinessId",
                schema: "Core",
                table: "BusinessRep",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_BusinessRepStatusId",
                schema: "Core",
                table: "BusinessRep",
                column: "BusinessRepStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_CreatedBy",
                schema: "Core",
                table: "BusinessRep",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_PersonId",
                schema: "Core",
                table: "BusinessRep",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRepStatus_CreatedBy",
                schema: "Setup",
                table: "BusinessRepStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_BusinessTypeId",
                schema: "Setup",
                table: "BusinessSector",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_CreatedBy",
                schema: "Setup",
                table: "BusinessSector",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessStatus_CreatedBy",
                schema: "Setup",
                table: "BusinessStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessType_CreatedBy",
                schema: "Setup",
                table: "BusinessType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClearingAgent_CreatedBy",
                schema: "Setup",
                table: "ClearingAgent",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CreatedBy",
                schema: "Setup",
                table: "Country",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomCollectorate_CreatedBy",
                schema: "Setup",
                table: "CustomCollectorate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_BusinessId",
                schema: "Core",
                table: "Dealer",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_CreatedBy",
                schema: "Core",
                table: "Dealer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_District_CreatedBy",
                schema: "Setup",
                table: "District",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalRight_CreatedBy",
                schema: "Auth",
                table: "GlobalRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_ApplicationId",
                schema: "Core",
                table: "HPAHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_CreatedBy",
                schema: "Core",
                table: "HPAHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_HPATerminatedByUserId",
                schema: "Core",
                table: "HPAHistory",
                column: "HPATerminatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_OwnerId",
                schema: "Core",
                table: "HPAHistory",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_SponserBusinessId",
                schema: "Core",
                table: "HPAHistory",
                column: "SponserBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_VehicleId",
                schema: "Core",
                table: "HPAHistory",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_CreatedBy",
                schema: "Core",
                table: "Keeper",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_KeeperBusinessId",
                schema: "Core",
                table: "Keeper",
                column: "KeeperBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_KeeperPersonId",
                schema: "Core",
                table: "Keeper",
                column: "KeeperPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_VehicleId",
                schema: "Core",
                table: "Keeper",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_CreatedBy",
                schema: "Logs",
                table: "Logs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationCategory_CreatedBy",
                schema: "Setup",
                table: "OrganizationCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_CreatedBy",
                schema: "Core",
                table: "Owner",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTaxGroupId",
                schema: "Core",
                table: "Owner",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTypeId",
                schema: "Core",
                table: "Owner",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_BusinessId",
                schema: "Core",
                table: "OwnerGroup",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_CreatedBy",
                schema: "Core",
                table: "OwnerGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_OwnerId",
                schema: "Core",
                table: "OwnerGroup",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_PersonId",
                schema: "Core",
                table: "OwnerGroup",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStatus_CreatedBy",
                schema: "Setup",
                table: "OwnerStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroup_CreatedBy",
                schema: "Setup",
                table: "OwnerTaxGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerType_CreatedBy",
                schema: "Setup",
                table: "OwnerType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CountryId",
                schema: "Core",
                table: "Person",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_BusinessId",
                schema: "Core",
                table: "PhoneNumber",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CountryId",
                schema: "Core",
                table: "PhoneNumber",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CreatedBy",
                schema: "Core",
                table: "PhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId",
                schema: "Core",
                table: "PhoneNumber",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId",
                schema: "Core",
                table: "PhoneNumber",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberType_CreatedBy",
                schema: "Setup",
                table: "PhoneNumberType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Port_CreatedBy",
                schema: "Setup",
                table: "Port",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ApplicationId",
                schema: "Core",
                table: "Remarks",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_CreatedBy",
                schema: "Core",
                table: "Remarks",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_OwnerGroupId",
                schema: "Core",
                table: "Remarks",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_OwnerId",
                schema: "Core",
                table: "Remarks",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RoleId",
                schema: "Core",
                table: "Remarks",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_VehicleId",
                schema: "Core",
                table: "Remarks",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLog_CreatedBy",
                schema: "Logs",
                table: "RequestLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ActionId",
                schema: "Auth",
                table: "Resource",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ControllerId",
                schema: "Auth",
                table: "Resource",
                column: "ControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_CreatedBy",
                schema: "Auth",
                table: "Resource",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourceTypeId",
                schema: "Auth",
                table: "Resource",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_CreatedBy",
                schema: "Auth",
                table: "ResourceAction",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceController_CreatedBy",
                schema: "Auth",
                table: "ResourceController",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceType_CreatedBy",
                schema: "Auth",
                table: "ResourceType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_CreatedBy",
                schema: "Auth",
                table: "ResourceTypeDefaultRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_DefaultRTRightId",
                schema: "Auth",
                table: "ResourceTypeDefaultRight",
                column: "DefaultRTRightId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_RTRightId",
                schema: "Auth",
                table: "ResourceTypeDefaultRight",
                column: "RTRightId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_CreatedBy",
                schema: "Auth",
                table: "ResourceTypeRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_GRightId",
                schema: "Auth",
                table: "ResourceTypeRight",
                column: "GRightId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_ResourceTypeId",
                schema: "Auth",
                table: "ResourceTypeRight",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedBy",
                schema: "Auth",
                table: "Role",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_CreatedBy",
                schema: "Auth",
                table: "RoleResource",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_ResourceId",
                schema: "Auth",
                table: "RoleResource",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_RoleId_ResourceId",
                schema: "Auth",
                table: "RoleResource",
                columns: new[] { "RoleId", "ResourceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_CreatedBy",
                schema: "Auth",
                table: "RoleResourceRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_RoleResourceId_RTRightId",
                schema: "Auth",
                table: "RoleResourceRight",
                columns: new[] { "RoleResourceId", "RTRightId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_RTRightId",
                schema: "Auth",
                table: "RoleResourceRight",
                column: "RTRightId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_CreatedBy",
                schema: "Auth",
                table: "RoleResourceRightsHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_ResourceId",
                schema: "Auth",
                table: "RoleResourceRightsHistory",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_RoleId",
                schema: "Auth",
                table: "RoleResourceRightsHistory",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_CreatedBy",
                table: "Tehsil",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_DistrictId",
                table: "Tehsil",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_AddressTypeId",
                schema: "Core",
                table: "TempAddress",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_ApplicationId",
                schema: "Core",
                table: "TempAddress",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_CreatedBy",
                schema: "Core",
                table: "TempAddress",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_DistrictId",
                schema: "Core",
                table: "TempAddress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_OwnerId",
                schema: "Core",
                table: "TempAddress",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_ApplicationStatusId",
                schema: "Core",
                table: "TempApplication",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_ApplicationTypeId",
                schema: "Core",
                table: "TempApplication",
                column: "ApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_CreatedBy",
                schema: "Core",
                table: "TempApplication",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_OwnerGroupId",
                schema: "Core",
                table: "TempApplication",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_VehicleId",
                schema: "Core",
                table: "TempApplication",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_ApplicationId",
                schema: "Core",
                table: "TempOwner",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_CountryId",
                schema: "Core",
                table: "TempOwner",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_CreatedBy",
                schema: "Core",
                table: "TempOwner",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_OwnerTaxGroupId",
                schema: "Core",
                table: "TempOwner",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_OwnerTypeId",
                schema: "Core",
                table: "TempOwner",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_ApplicationId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_CountryId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_CreatedBy",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_OwnerId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_PhoneNumberTypeId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_ApplicationId",
                schema: "Core",
                table: "TempRemarks",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_CreatedBy",
                schema: "Core",
                table: "TempRemarks",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_OwnerId",
                schema: "Core",
                table: "TempRemarks",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_RoleId",
                schema: "Core",
                table: "TempRemarks",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_VehicleId",
                schema: "Core",
                table: "TempRemarks",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_ApplicationId",
                schema: "Core",
                table: "TempVehicle",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_CreatedBy",
                schema: "Core",
                table: "TempVehicle",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_DistrictId",
                schema: "Core",
                table: "TempVehicle",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleBodyConventionId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleBodyConventionId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleBodyTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleCategoryId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleClassId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleClassificationId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleColorId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleEngineTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleEngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleFuelTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleMakeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleMakerId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehiclePurchaseTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleRCStatusId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleRCStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleStatusId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleUsageId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleAuctionInfo_ApplicationId",
                schema: "Core",
                table: "TempVehicleAuctionInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleAuctionInfo_CreatedBy",
                schema: "Core",
                table: "TempVehicleAuctionInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleAuctionInfo_VehicleId",
                schema: "Core",
                table: "TempVehicleAuctionInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_ApplicationId",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_CreatedBy",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_VehicleDocumentTypeId",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "VehicleDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_VehicleId",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_ApplicationId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_BankId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_ClearingAgentId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "ClearingAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_CountryId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_CreatedBy",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_CustomCollectorateId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "CustomCollectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_PortId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_VehicleId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_ApplicationId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_CreatedBy",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_DealerId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_VehicleId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_VehicleSchemeId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "VehicleSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId1",
                schema: "Auth",
                table: "User",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserStatusId",
                schema: "Auth",
                table: "User",
                column: "UserStatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedBy",
                schema: "Auth",
                table: "UserRole",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "Auth",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId_RoleId",
                schema: "Auth",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_CreatedBy",
                schema: "Auth",
                table: "UserRoleHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_RoleId",
                schema: "Auth",
                table: "UserRoleHistory",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_UserId",
                schema: "Auth",
                table: "UserRoleHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_CreatedBy",
                schema: "Core",
                table: "Vehicle",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_DistrictId",
                schema: "Core",
                table: "Vehicle",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_OwnerId",
                schema: "Core",
                table: "Vehicle",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyConventionId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleBodyConventionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyTypeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleCategoryId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassificationId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleColorId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleEngineTypeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleEngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleFuelTypeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakerId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehiclePurchaseTypeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleRCStatusId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleRCStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleStatusId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleUsageId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_CreatedBy",
                schema: "Core",
                table: "VehicleAuctionInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_VehicleId",
                schema: "Core",
                table: "VehicleAuctionInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyConvention_CreatedBy",
                schema: "Setup",
                table: "VehicleBodyConvention",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyType_CreatedBy",
                schema: "Setup",
                table: "VehicleBodyType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCategory_CreatedBy",
                schema: "Setup",
                table: "VehicleCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_CreatedBy",
                schema: "Setup",
                table: "VehicleClass",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassification_CreatedBy",
                schema: "Setup",
                table: "VehicleClassification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColor_CreatedBy",
                schema: "Setup",
                table: "VehicleColor",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentType_CreatedBy",
                schema: "Setup",
                table: "VehicleDocumentType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleEngineType_CreatedBy",
                schema: "Setup",
                table: "VehicleEngineType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFuelType_CreatedBy",
                schema: "Setup",
                table: "VehicleFuelType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_BankId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ClearingAgentId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "ClearingAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CountryId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CreatedBy",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CustomCollectorateId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "CustomCollectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_PortId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_VehicleId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_CreatedBy",
                schema: "Setup",
                table: "VehicleMake",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaker_CreatedBy",
                schema: "Setup",
                table: "VehicleMaker",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_CreatedBy",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_DealerId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_VehicleId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_VehicleSchemeId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "VehicleSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseType_CreatedBy",
                schema: "Setup",
                table: "VehiclePurchaseType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRCStatus_CreatedBy",
                schema: "Setup",
                table: "VehicleRCStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_CreatedBy",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_VehicleId",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleScheme_CreatedBy",
                schema: "Setup",
                table: "VehicleScheme",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleStatus_CreatedBy",
                schema: "Setup",
                table: "VehicleStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUsage_CreatedBy",
                schema: "Setup",
                table: "VehicleUsage",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountHead",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "BusinessRep",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "HPAHistory",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Keeper",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Logs",
                schema: "Logs");

            migrationBuilder.DropTable(
                name: "OrganizationCategory",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "OwnerStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "PhoneNumber",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Remarks",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "RequestLog",
                schema: "Logs");

            migrationBuilder.DropTable(
                name: "ResourceTypeDefaultRight",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "RoleResourceRight",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "RoleResourceRightsHistory",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "TempAddress",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempPhoneNumber",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempRemarks",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehicleAuctionInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehicleDocument",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehicleImportInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehiclePurchaseInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "UserRoleHistory",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "VehicleAuctionInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleImportInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehiclePurchaseInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleRegistrationHistory",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Tehsil");

            migrationBuilder.DropTable(
                name: "BusinessRepStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Application",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ResourceTypeRight",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "RoleResource",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "AddressType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "PhoneNumberType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "TempOwner",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleDocumentType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "TempVehicle",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Bank",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "ClearingAgent",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "CustomCollectorate",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Port",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Dealer",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleScheme",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "GlobalRight",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Resource",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "TempApplication",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ResourceAction",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "ResourceController",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "ResourceType",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "ApplicationStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "ApplicationType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "OwnerGroup",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Vehicle",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Business",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "District",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Owner",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleBodyConvention",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleBodyType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleCategory",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleClass",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleClassification",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleColor",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleEngineType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleFuelType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleMake",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleMaker",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehiclePurchaseType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleRCStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleUsage",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "BusinessSector",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "BusinessStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "OwnerTaxGroup",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "OwnerType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "BusinessType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "UserStatus",
                schema: "Auth");
        }
    }
}
