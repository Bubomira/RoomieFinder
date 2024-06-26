using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e", null, "GreatAdmin", "GREATADMIN" },
                    { "7ed277c0-8163-466a-ad9b-942646c198c7", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "169f682a-e6d0-4aca-8b74-d51dbcaa58ef", 0, "52235a6d-acd5-45f2-aa61-091d6d61dcc6", "medical_university_admin@gmail.com", false, "Medical University", "Admin", false, null, null, null, "AQAAAAIAAYagAAAAEKr09ilyxYzZAyKNG5NHCyhZ8ZlxvS7bptWA8EMht6fbCyZT3rtlHSSv1DhHBfDHTg==", null, false, "4ccad40c-fe89-49e9-8dc0-e8f295597f89", false, "Medical University Admin" },
                    { "47ca66e3-a4b0-43ca-916a-edf44842f9f7", 0, "40830fdd-43b7-4e0f-973b-40a9423ba9eb", "marina_nikolova.56@gmail.com", false, "Marina", "Nikolova", false, null, null, null, "AQAAAAIAAYagAAAAEHmQWD+oyUDwHlE940KxvsR0VujiIcHCoqDJ2kY/Q67pShCIFmwOWdQBHZzVBQakWA==", null, false, "ca52a764-13c0-408a-bb0c-99a05b0c1e23", false, "Marina_" },
                    { "51d96dfa-943a-44a3-a39b-136844852055", 0, "437f7d33-bab2-4410-a5ca-acc94a9be7dc", "alisa_markova@gmail.com", false, "Alisa", "Markova", false, null, null, null, "AQAAAAIAAYagAAAAED2lmk7r6Xz04O4IP9ik7XG67jn4G+LLL+2Nc8YleWEVo7iSkIzd0YwycGgKuHogsQ==", null, false, "56f7d9af-6864-4aba-8d03-0826bfbb4800", false, "Alise_Marie" },
                    { "77cc9efa-570e-464c-a3c3-805a1cf94b30", 0, "861fb5fc-b62f-46b6-9128-140d005fbcbe", "sofia_university_admin@gmail.com", false, "Sofia University", "Admin", false, null, null, null, "AQAAAAIAAYagAAAAEIRdrLqjS69BG0a5jZpub/d8QSrWsV0134JH2eQJHBVIQZS7EiIr9csCbgR4KbGRog==", null, false, "64286564-880c-4c97-9517-afe6bc8b608c", false, "Sofia University Admin" },
                    { "88273e30-0ad0-4095-b288-51f0d4f2eba0", 0, "93e4959f-a596-4b5d-a5f6-b9d895f6b1c2", "niki_g@gmail.com", false, "Nikolay", "Georgiev", false, null, null, null, "AQAAAAIAAYagAAAAEB9VAM5K4fbw2VM9XeIgCKPsSBmJYH0CjDIHbGgeI5S7dBl80OgkiVgFZ4nKnPJi7Q==", null, false, "6e6ac50b-0257-4752-8d45-fe4ca0a4b4e5", false, "Nikk" },
                    { "cc3beb38-92d0-44b9-9470-d24ffe951850", 0, "a13b933b-3975-4904-b635-7e6ed8451e84", "pepi_p@gmail.com", false, "Petar", "Petrov", false, null, null, null, "AQAAAAIAAYagAAAAEMMPm/UQ4lW/G9XqO2Q23AwN4b8g8/7lnhhUFr5pr/kUAFuiTAiMKaPcf4b8cNusnA==", null, false, "722d944f-c455-4658-ac59-cb3e199629dc", false, "_Pepi" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e", "169f682a-e6d0-4aca-8b74-d51dbcaa58ef" },
                    { "7ed277c0-8163-466a-ad9b-942646c198c7", "47ca66e3-a4b0-43ca-916a-edf44842f9f7" },
                    { "7ed277c0-8163-466a-ad9b-942646c198c7", "51d96dfa-943a-44a3-a39b-136844852055" },
                    { "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e", "77cc9efa-570e-464c-a3c3-805a1cf94b30" },
                    { "7ed277c0-8163-466a-ad9b-942646c198c7", "88273e30-0ad0-4095-b288-51f0d4f2eba0" },
                    { "7ed277c0-8163-466a-ad9b-942646c198c7", "cc3beb38-92d0-44b9-9470-d24ffe951850" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ApplicationUserId", "HasGraduated", "RoomId", "YearAtUniversity" },
                values: new object[,]
                {
                    { 1, "51d96dfa-943a-44a3-a39b-136844852055", false, null, 1 },
                    { 2, "88273e30-0ad0-4095-b288-51f0d4f2eba0", false, null, 1 },
                    { 3, "47ca66e3-a4b0-43ca-916a-edf44842f9f7", false, null, 2 },
                    { 4, "cc3beb38-92d0-44b9-9470-d24ffe951850", false, null, 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e", "169f682a-e6d0-4aca-8b74-d51dbcaa58ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ed277c0-8163-466a-ad9b-942646c198c7", "47ca66e3-a4b0-43ca-916a-edf44842f9f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ed277c0-8163-466a-ad9b-942646c198c7", "51d96dfa-943a-44a3-a39b-136844852055" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e", "77cc9efa-570e-464c-a3c3-805a1cf94b30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ed277c0-8163-466a-ad9b-942646c198c7", "88273e30-0ad0-4095-b288-51f0d4f2eba0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ed277c0-8163-466a-ad9b-942646c198c7", "cc3beb38-92d0-44b9-9470-d24ffe951850" });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ed277c0-8163-466a-ad9b-942646c198c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
