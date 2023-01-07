using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_MicroService_MicroServiceId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_MicroService_MicroServiceId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_MicroService_MicroServiceId",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_MicroService_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Person_MicroServiceId",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Business_MicroServiceId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_Address_MicroServiceId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "PhoneNumber",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "Person",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "Business",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "Address",
                newName: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CreatedBy",
                schema: "Core",
                table: "PhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                schema: "Core",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_CreatedBy",
                schema: "Core",
                table: "Address",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_User_CreatedBy",
                schema: "Core",
                table: "Business",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_User_CreatedBy",
                schema: "Core",
                table: "Person",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_User_CreatedBy",
                schema: "Core",
                table: "PhoneNumber",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_CreatedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_User_CreatedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_CreatedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_User_CreatedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_CreatedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_Address_CreatedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "PhoneNumber",
                newName: "MicroServiceUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "Person",
                newName: "MicroServiceUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "Business",
                newName: "MicroServiceUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "Address",
                newName: "MicroServiceUserId");

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "PhoneNumber",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "Person",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "Business",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "Address",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber",
                column: "MicroServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MicroServiceId",
                schema: "Core",
                table: "Person",
                column: "MicroServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_MicroServiceId",
                schema: "Core",
                table: "Business",
                column: "MicroServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_MicroServiceId",
                schema: "Core",
                table: "Address",
                column: "MicroServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_MicroService_MicroServiceId",
                schema: "Core",
                table: "Address",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_MicroService_MicroServiceId",
                schema: "Core",
                table: "Business",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_MicroService_MicroServiceId",
                schema: "Core",
                table: "Person",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_MicroService_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");
        }
    }
}
