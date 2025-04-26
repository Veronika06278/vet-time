using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatedSpecializationsDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Specialization_SpecializationId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_VetSpecialization_Specialization_Id",
                table: "VetSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_VetSpecialization_Veterinarians_VetId",
                table: "VetSpecialization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VetSpecialization",
                table: "VetSpecialization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialization",
                table: "Specialization");

            migrationBuilder.RenameTable(
                name: "VetSpecialization",
                newName: "VetSpecializations");

            migrationBuilder.RenameTable(
                name: "Specialization",
                newName: "Specializations");

            migrationBuilder.RenameIndex(
                name: "IX_VetSpecialization_Id",
                table: "VetSpecializations",
                newName: "IX_VetSpecializations_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VetSpecializations",
                table: "VetSpecializations",
                columns: new[] { "VetId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specializations",
                table: "Specializations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15921ea3-affd-4b49-b26b-9521d0f3386f", "AQAAAAIAAYagAAAAECdB5bwmz0ijBYpBz1rSWgjGYnHY2OS1sXT0r7OM5O6VnOFmRu4qQ8j+VCMZk+JfUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "975b23e3-1782-47a6-91c2-16bde720a67c", "AQAAAAIAAYagAAAAECwRRiPYMSqI9QsGb5Ctw80rzLIpTQI5eGAr4SBP0V6azX9cdlet4oEdgVcIHLYQNA==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 13, 11, 45, 33, 818, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Specializations_SpecializationId",
                table: "Animals",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VetSpecializations_Specializations_Id",
                table: "VetSpecializations",
                column: "Id",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VetSpecializations_Veterinarians_VetId",
                table: "VetSpecializations",
                column: "VetId",
                principalTable: "Veterinarians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Specializations_SpecializationId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_VetSpecializations_Specializations_Id",
                table: "VetSpecializations");

            migrationBuilder.DropForeignKey(
                name: "FK_VetSpecializations_Veterinarians_VetId",
                table: "VetSpecializations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VetSpecializations",
                table: "VetSpecializations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specializations",
                table: "Specializations");

            migrationBuilder.RenameTable(
                name: "VetSpecializations",
                newName: "VetSpecialization");

            migrationBuilder.RenameTable(
                name: "Specializations",
                newName: "Specialization");

            migrationBuilder.RenameIndex(
                name: "IX_VetSpecializations_Id",
                table: "VetSpecialization",
                newName: "IX_VetSpecialization_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VetSpecialization",
                table: "VetSpecialization",
                columns: new[] { "VetId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialization",
                table: "Specialization",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30fc6826-4432-4164-8f8a-4af458a21f47", "AQAAAAIAAYagAAAAEBIa/9NrgsDOUOnOv2uAC2FwacVHmKFhKWW3ZX+fsr4sKpBT1qZob+kF3pw7e3cYZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a86559fb-d086-4b57-8937-0852b0e80971", "AQAAAAIAAYagAAAAELO1fl/xOfV4rIyTVlOEBf4y73WXGIWqBb1HZPB8DUN9gHMyvN5q/cDAdBAZD9RMDA==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Specialization_SpecializationId",
                table: "Animals",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VetSpecialization_Specialization_Id",
                table: "VetSpecialization",
                column: "Id",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VetSpecialization_Veterinarians_VetId",
                table: "VetSpecialization",
                column: "VetId",
                principalTable: "Veterinarians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
