using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class AnimalRelationWithSpecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnimalCategory",
                table: "Animals",
                newName: "SpecializationId");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 59, 16, 808, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5b5f3db-2180-4554-809e-ba3f67a37027", "AQAAAAIAAYagAAAAEAJReE3OJFMfnSc0lz6M0a2Gl5ijZPW2foj8Vtxe+6qXyALYio7Dimn5zVzK6Mz8FQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf857524-c5c7-4d6c-9368-f463a995f866", "AQAAAAIAAYagAAAAEJJ6g1YQpatnIKdcdvtgZDYWBYlbx/vTbIXDSVtntO6XxpL6DC12PXk05VCX4QlFWA==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 59, 16, 808, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 59, 16, 808, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 59, 16, 808, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.CreateIndex(
                name: "IX_Animals_SpecializationId",
                table: "Animals",
                column: "SpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Specialization_SpecializationId",
                table: "Animals",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Specialization_SpecializationId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_SpecializationId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "SpecializationId",
                table: "Animals",
                newName: "AnimalCategory");

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

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 8, 9, 13, 48, 68, DateTimeKind.Local).AddTicks(8172));
        }
    }
}
