using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetTime.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ClientId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"), 0, null, "739dd947-d4ac-4698-905a-57f162d5ec22", "client@gmail.com", false, false, null, "CLIENT@GMAIL.COM", "CLIENT@GMAIL.COM", "AQAAAAIAAYagAAAAEEs/D/qkt8I8H8Tb5pQ72dW3gx8kDzrMeaj4YQ6a3S3n1xDAVC8HiKmUp9+/Zq+FxA==", "0886578436", false, "5b3e881c-bfe4-43f2-a4d8-e2d28af0293a", false, "client@gmail.com", null },
                    { new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"), 0, null, "95301724-cfb9-46d5-834c-92601cf4013c", "veterinar@gmail.com", false, false, null, "VETERINAR@GMAIL.COM", "VETERINAR@GMAIL.COM", "AQAAAAIAAYagAAAAEK9AAGsTJyaPKfV0YWe4SipqpnBkc+GrMvfyjicuJ/+tc4DhOWIDuiPw8aYgomGNpQ==", "0887564962", false, "1e860808-5c39-42fd-ba4a-e71f2286a26c", false, "veterinar@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedOn", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"), new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(3917), null, null, false, "Sofia", null, null });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "CreatedOn", "DeletedAt", "DeletedBy", "District", "IsDeleted", "Number", "Street", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"), new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"), new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(4158), null, null, "Lozenets", false, 16, "Kozyak", null, null });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CreatedOn", "DeletedAt", "DeletedBy", "FirstName", "IsDeleted", "LastName", "NotVisitedCounter", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"), new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(3029), null, null, "Nicole", false, "Aleksieva", 0, null, null, new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba") });

            migrationBuilder.InsertData(
                table: "Veterinarians",
                columns: new[] { "Id", "AddressId", "CreatedOn", "DeletedAt", "DeletedBy", "FirstName", "IsDeleted", "LastName", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"), new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"), new DateTime(2025, 2, 1, 11, 28, 2, 701, DateTimeKind.Local).AddTicks(4329), null, null, "Veronika", false, "Zheleva", null, null, new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"));

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"));
        }
    }
}
