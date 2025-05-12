using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAdminSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96eea271-6799-4aef-9fa0-f5f74d218560", "AQAAAAIAAYagAAAAEPl7nL6GPQneQA0YDoByLlXs0b5bUvNL+njxpbmpawNhH7Kg2GGaKSV8fnkI96aACg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7b80359-b1e6-45bd-a36d-6e0c540b5a55", "AQAAAAIAAYagAAAAEFzpZxJUFr84CAa768XrHGeYFjoLg2CFMOn78VqWmAjySdNU2oYfDdZbOECOHXhz3w==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ClientId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[] { new Guid("e7cab530-e2f0-418d-9577-dd1b6710c05e"), 0, null, "3ab46a61-5cd2-496e-9542-6a0f15aa2f1b", "admin@admin.com", false, false, null, "VETERINAR@GMAIL.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGb+DBiRgRNEY16mEeiUTw/mZvvle/ykxc5Ewsv2J/sc/7BaY5pKdmjo0llXozDONA==", "0887698491", false, "92120f9e-6bfb-4801-b8d9-d424621f19c7", false, "admin@admin.com", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 5, 4, 11, 34, 50, 704, DateTimeKind.Local).AddTicks(3564));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7cab530-e2f0-418d-9577-dd1b6710c05e"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7183abc-d10f-4908-a4aa-a31cc2649359", "AQAAAAIAAYagAAAAEPJ/szg4Rb7qUE7UtP1ynkSmCFXnPTMU5CZ1FlKLSREQF1CH6Juvv6RcromfG4YrQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4865175d-7352-46b8-87a0-ef96badf5257", "AQAAAAIAAYagAAAAECg4RXof/y3a0xrdffJFDlbSGn0EucQdQzRx4yTL8R7Ip7Xubnyv0Twu4lgojXqbTw==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 29, 13, 57, 55, 740, DateTimeKind.Local).AddTicks(2903));
        }
    }
}
