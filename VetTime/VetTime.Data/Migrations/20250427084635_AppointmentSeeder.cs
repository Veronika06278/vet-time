using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class AppointmentSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Animals_AnimalId",
                table: "Appointments");

            migrationBuilder.AlterColumn<Guid>(
                name: "AnimalId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 27, 11, 46, 34, 124, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AnimalId", "AppointmentTime", "AppointmentType", "ClientId", "CreatedOn", "DeletedAt", "DeletedBy", "HasVisited", "IsDeleted", "UpdatedAt", "UpdatedBy", "VetId" },
                values: new object[] { new Guid("30ccc388-9956-4f37-bdea-c9c5e466c78c"), null, new DateTime(2025, 4, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"), new DateTime(2025, 4, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, false, null, null, new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b") });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Animals_AnimalId",
                table: "Appointments",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Animals_AnimalId",
                table: "Appointments");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("30ccc388-9956-4f37-bdea-c9c5e466c78c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AnimalId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 598, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a99567bc-d399-4800-a98d-65e6021f29a5", "AQAAAAIAAYagAAAAEMoRtsOWXIrXA95jhzifvMKVdPQ2Zr0GTGU+Kak1SmMYOCPfHyh41HeOArQ3qgB0vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9faf8105-e313-4619-80fb-ba305cc2a849", "AQAAAAIAAYagAAAAENCieXuzoErXrjscZTthRvMEEsV4ZVScgzuciiRiy+EXq8dIcnVMz5SkdAK808Iklg==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 597, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 19, 11, 39, 58, 598, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Animals_AnimalId",
                table: "Appointments",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
