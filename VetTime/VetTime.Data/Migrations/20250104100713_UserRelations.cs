using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Veterinarians",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VeterinarianId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veterinarians_UserId",
                table: "Veterinarians",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClientId",
                table: "AspNetUsers",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Clients_ClientId",
                table: "AspNetUsers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_UserId",
                table: "Clients",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinarians_AspNetUsers_UserId",
                table: "Veterinarians",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Clients_ClientId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_UserId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinarians_AspNetUsers_UserId",
                table: "Veterinarians");

            migrationBuilder.DropIndex(
                name: "IX_Veterinarians_UserId",
                table: "Veterinarians");

            migrationBuilder.DropIndex(
                name: "IX_Clients_UserId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClientId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Veterinarians");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VeterinarianId",
                table: "AspNetUsers");
        }
    }
}
