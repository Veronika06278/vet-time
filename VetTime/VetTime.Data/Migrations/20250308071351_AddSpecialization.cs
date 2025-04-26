using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VetSpecialization",
                columns: table => new
                {
                    VetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VetSpecialization", x => new { x.VetId, x.Id });
                    table.ForeignKey(
                        name: "FK_VetSpecialization_Specialization_Id",
                        column: x => x.Id,
                        principalTable: "Specialization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VetSpecialization_Veterinarians_VetId",
                        column: x => x.VetId,
                        principalTable: "Veterinarians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 13, 48, 68, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bf84072-05a5-4d35-9d26-d9be894c9397", "AQAAAAIAAYagAAAAEEsTVORInn0+huJnLsL4DYPgV2ZEzZIfFGfxnmlUx6jsv9aibgPPTiQ1StImri4uzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9332304-9e4f-47ce-85c1-6334857521f5", "AQAAAAIAAYagAAAAECVm17hNKQ41v47FcxnDsnST+k1lh8KA4OQwN0s7wfBbKJj547A10zDuZiGFG8YvZg==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 13, 48, 68, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 13, 48, 68, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Exotic Animals" },
                    { 2, "Domestic Animals" },
                    { 3, "Farm Animals" }
                });

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 13, 48, 68, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.CreateIndex(
                name: "IX_VetSpecialization_Id",
                table: "VetSpecialization",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VetSpecialization");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "739dd947-d4ac-4698-905a-57f162d5ec22", "AQAAAAIAAYagAAAAEEs/D/qkt8I8H8Tb5pQ72dW3gx8kDzrMeaj4YQ6a3S3n1xDAVC8HiKmUp9+/Zq+FxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95301724-cfb9-46d5-834c-92601cf4013c", "AQAAAAIAAYagAAAAEK9AAGsTJyaPKfV0YWe4SipqpnBkc+GrMvfyjicuJ/+tc4DhOWIDuiPw8aYgomGNpQ==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(4329));
        }
    }
}
