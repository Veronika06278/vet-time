using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a03796bd-2f4d-420f-807d-e3439e2ffe7d", "AQAAAAIAAYagAAAAEBRXdHrKHbe0qUt7yGXP8Yj3Gzagk10v4fNGbBsVr30YEPgG4nSwITZF2v0sG4UHTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b475aa0-a082-4145-94e1-936f9632dc92", "AQAAAAIAAYagAAAAEMsQvhvMTH7k9VLaL1y/kw8IYOUofmk3x1DQVOiWuBUCVCpPlfhVurbP6Ihz0Z3g9g==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 123, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(3001));
        }
    }
}
