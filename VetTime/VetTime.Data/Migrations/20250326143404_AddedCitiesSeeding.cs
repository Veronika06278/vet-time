using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCitiesSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedOn", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4902), null, null, false, "Kyustendil", null, null },
                    { new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4718), null, null, false, "Pernik", null, null },
                    { new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4597), null, null, false, "Plovdiv", null, null },
                    { new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4906), null, null, false, "Montana", null, null },
                    { new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4721), null, null, false, "Haskovo", null, null },
                    { new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4602), null, null, false, "Varna", null, null },
                    { new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4909), null, null, false, "Lovech", null, null },
                    { new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4724), null, null, false, "Yambol", null, null },
                    { new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4727), null, null, false, "Pazardzhik", null, null },
                    { new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4605), null, null, false, "Burgas", null, null },
                    { new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4913), null, null, false, "Razgrad", null, null },
                    { new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4771), null, null, false, "Blagoevgrad", null, null },
                    { new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4609), null, null, false, "Ruse", null, null },
                    { new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4916), null, null, false, "Targovishte", null, null },
                    { new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4921), null, null, false, "Silistra", null, null },
                    { new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4775), null, null, false, "Veliko Tarnovo", null, null },
                    { new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4682), null, null, false, "Stara Zagora", null, null },
                    { new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4950), null, null, false, "Smolyan", null, null },
                    { new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4778), null, null, false, "Vratsa", null, null },
                    { new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4687), null, null, false, "Pleven", null, null },
                    { new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4699), null, null, false, "Sliven", null, null },
                    { new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4889), null, null, false, "Gabrovo", null, null },
                    { new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4703), null, null, false, "Dobrich", null, null },
                    { new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4896), null, null, false, "Vidin", null, null },
                    { new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4899), null, null, false, "Kardzhali", null, null },
                    { new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"), new DateTime(2025, 3, 26, 16, 34, 0, 845, DateTimeKind.Local).AddTicks(4714), null, null, false, "Shumen", null, null }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"));

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
        }
    }
}
