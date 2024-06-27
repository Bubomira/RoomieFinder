using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedNormalizedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47716647-625a-4acf-90d9-a6a5a3c572ca", "MEDICAL_UNIVERSITY_ADMIN@GMAIL.COM", "MEDICAL UNIVERSITY ADMIN", "AQAAAAIAAYagAAAAEBwC8pfAPXmb7YykQ+3VKpbFeqxz54NOful6SzGHXh4tPTA6hQ3CM+ctuRfwghnU6w==", "1abf97a5-b311-4400-ad21-c5ed3f49cb22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb1bffee-98ae-4743-b40b-45cf246fc169", "MARINA_NIKOLOVA@GMAIL.COM", "MARINA_", "AQAAAAIAAYagAAAAENSS2HP5a4nxwXgUwQhC4wTt4qg+sDYBm0u5lkuh6Zr6Fts67MrE2FjjGkMfT8gExQ==", "f15e87d9-7d01-4149-97bc-fd932dad4a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b84d045-058c-493e-8de4-660e8b737fd6", "ALISA_MARKOVA@GMAIL.COM", "ALISE_MARIE", "AQAAAAIAAYagAAAAELCo6hBnGxabca/VJkMPIWm/KE70MaciVIHD/XsQ87asYYGFhFLz2v884yXLFu746A==", "532a4818-0e66-4b92-94c0-3e94ae7bfa70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4371a90-9191-4834-b570-e793e8ddd3b4", "SOFIA_UNIVERSITY_ADMIN@GMAIL.COM", "SOFIA UNIVERSITY ADMIN", "AQAAAAIAAYagAAAAEEzgvw+sj+AnzREW/sYOFAawhwOnlbxSN56yn04Sht+/ZbQvBSmaLpGfJQ4VyI3NXg==", "9d3ab1e5-6908-40f1-884d-8f916b403d22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56bd0c69-a9ca-4fb4-9e68-988016a614ee", "NIKI_G@GMAIL.COM", "NIKK", "AQAAAAIAAYagAAAAECDyT1vrTvyLmBiFoDQxS818/2HdtmlVdSXoIsT43z8U1/1RVd72JkF+FdRMj6YiSg==", "f0e75cef-0e5c-4bf8-86bf-84387e7c1ffa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1294306d-c2b1-4319-88c7-582a0530e728", "PEPI_P@GMAIL.COM", "_PEPI", "AQAAAAIAAYagAAAAECJfY4y9B6RslWCANVyc6D9m1KSH71cayVYYQbFfDplRW9kjwjSAL3f1N30WDoNsTA==", "44882b74-4ffe-4990-9098-22037f157eb4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52235a6d-acd5-45f2-aa61-091d6d61dcc6", null, null, "AQAAAAIAAYagAAAAEKr09ilyxYzZAyKNG5NHCyhZ8ZlxvS7bptWA8EMht6fbCyZT3rtlHSSv1DhHBfDHTg==", "4ccad40c-fe89-49e9-8dc0-e8f295597f89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40830fdd-43b7-4e0f-973b-40a9423ba9eb", null, null, "AQAAAAIAAYagAAAAEHmQWD+oyUDwHlE940KxvsR0VujiIcHCoqDJ2kY/Q67pShCIFmwOWdQBHZzVBQakWA==", "ca52a764-13c0-408a-bb0c-99a05b0c1e23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "437f7d33-bab2-4410-a5ca-acc94a9be7dc", null, null, "AQAAAAIAAYagAAAAED2lmk7r6Xz04O4IP9ik7XG67jn4G+LLL+2Nc8YleWEVo7iSkIzd0YwycGgKuHogsQ==", "56f7d9af-6864-4aba-8d03-0826bfbb4800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "861fb5fc-b62f-46b6-9128-140d005fbcbe", null, null, "AQAAAAIAAYagAAAAEIRdrLqjS69BG0a5jZpub/d8QSrWsV0134JH2eQJHBVIQZS7EiIr9csCbgR4KbGRog==", "64286564-880c-4c97-9517-afe6bc8b608c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93e4959f-a596-4b5d-a5f6-b9d895f6b1c2", null, null, "AQAAAAIAAYagAAAAEB9VAM5K4fbw2VM9XeIgCKPsSBmJYH0CjDIHbGgeI5S7dBl80OgkiVgFZ4nKnPJi7Q==", "6e6ac50b-0257-4752-8d45-fe4ca0a4b4e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a13b933b-3975-4904-b635-7e6ed8451e84", null, null, "AQAAAAIAAYagAAAAEMMPm/UQ4lW/G9XqO2Q23AwN4b8g8/7lnhhUFr5pr/kUAFuiTAiMKaPcf4b8cNusnA==", "722d944f-c455-4658-ac59-cb3e199629dc" });
        }
    }
}
