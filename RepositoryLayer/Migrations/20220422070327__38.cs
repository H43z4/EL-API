using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _38 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleDocumentRequirement",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocumentRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleDocumentRequirement_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleDocumentRequirement_VehicleDocumentType_VehicleDocumentTypeId",
                        column: x => x.VehicleDocumentTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentRequirement_BusinessProcessId",
                schema: "Setup",
                table: "VehicleDocumentRequirement",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentRequirement_VehicleDocumentTypeId",
                schema: "Setup",
                table: "VehicleDocumentRequirement",
                column: "VehicleDocumentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleDocumentRequirement",
                schema: "Setup");
        }
    }
}
