using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addHasChangedPasswordTAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasChangedPassword",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "HasChangedPassword", "PasswordHash", "SecurityStamp" },
                values: new object[] { "814eea77-56ad-4b92-a7f0-0775db69e2f8", true, "AQAAAAIAAYagAAAAEIhC/iOi53bk7V79OyyDYIiSkjUfnI8pHI8Ds7S5GeX0a3+lZO7wAhdQtgsUBqx69Q==", "afa4ee30-a98c-4cc7-9c5c-31cf4e3bdc90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "HasChangedPassword", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f30a499-3609-40fe-ad52-e920c1d1fa7b", true, "AQAAAAIAAYagAAAAED8lvhSnRQJaa2yHDINI4vxqSvD/LeXsyhvXl7rGuCkVRPDS85PUpp3ofyCe9KrBNQ==", "77309649-7f09-4f87-a6fb-407de2411167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "HasChangedPassword", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e436310-e71a-4cc2-8b28-43d14b6a327d", true, "AQAAAAIAAYagAAAAEA17DFEQQoMX+auHGwthnz8N9xxqkk7vXd3h/2JY1lD37IBYjf5cZqwA+BMr4r0vRw==", "a29a1bc3-e92e-40a9-b201-37f6ed1df101" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "HasChangedPassword", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18cc7c1c-b016-4158-ad87-0325143de47d", true, "AQAAAAIAAYagAAAAEKV2B5rzsLLUZo7DEapUrvTyk6u/IpIPAwcWZ1hu/BypJTIiomWUvIJZdmD+90OsDw==", "8d479d74-ca6b-4aad-80be-b5b21276a13a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "HasChangedPassword", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e32f90d-5c19-4eca-ac48-05d7ea8a6a6e", true, "AQAAAAIAAYagAAAAEKs3YMCpvV5yczdggkO8O2joA8EiA5TU+Rw0XL+FlpD1pfKBa5XccrsRaI7dXsixmg==", "ba6b4948-b0cd-41c5-91e7-2df5157b8487" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "HasChangedPassword", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a609f68-3cec-4f0c-9880-48e15a888827", true, "AQAAAAIAAYagAAAAEO0iJNaMe3mioEngtiqVp25WWbNWDLeDd7fWJBkD2UFFf1zoxhaLE6vK7QeqqQMrVA==", "d3632ed1-3ebf-4325-b9d7-56e86f71de3a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasChangedPassword",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47716647-625a-4acf-90d9-a6a5a3c572ca", "AQAAAAIAAYagAAAAEBwC8pfAPXmb7YykQ+3VKpbFeqxz54NOful6SzGHXh4tPTA6hQ3CM+ctuRfwghnU6w==", "1abf97a5-b311-4400-ad21-c5ed3f49cb22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb1bffee-98ae-4743-b40b-45cf246fc169", "AQAAAAIAAYagAAAAENSS2HP5a4nxwXgUwQhC4wTt4qg+sDYBm0u5lkuh6Zr6Fts67MrE2FjjGkMfT8gExQ==", "f15e87d9-7d01-4149-97bc-fd932dad4a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b84d045-058c-493e-8de4-660e8b737fd6", "AQAAAAIAAYagAAAAELCo6hBnGxabca/VJkMPIWm/KE70MaciVIHD/XsQ87asYYGFhFLz2v884yXLFu746A==", "532a4818-0e66-4b92-94c0-3e94ae7bfa70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4371a90-9191-4834-b570-e793e8ddd3b4", "AQAAAAIAAYagAAAAEEzgvw+sj+AnzREW/sYOFAawhwOnlbxSN56yn04Sht+/ZbQvBSmaLpGfJQ4VyI3NXg==", "9d3ab1e5-6908-40f1-884d-8f916b403d22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56bd0c69-a9ca-4fb4-9e68-988016a614ee", "AQAAAAIAAYagAAAAECDyT1vrTvyLmBiFoDQxS818/2HdtmlVdSXoIsT43z8U1/1RVd72JkF+FdRMj6YiSg==", "f0e75cef-0e5c-4bf8-86bf-84387e7c1ffa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1294306d-c2b1-4319-88c7-582a0530e728", "AQAAAAIAAYagAAAAECJfY4y9B6RslWCANVyc6D9m1KSH71cayVYYQbFfDplRW9kjwjSAL3f1N30WDoNsTA==", "44882b74-4ffe-4990-9098-22037f157eb4" });
        }
    }
}
