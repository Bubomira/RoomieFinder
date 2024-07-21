using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class qualitySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6fbd328-5698-4a4e-a978-60645d852184", "AQAAAAIAAYagAAAAECkmsIlJada6p4qaIvuqAeVPuqEo70wC7++/xJpsw0H6kFmdRPZy+Pf9TaLvmLtZXA==", "9bbe24de-01b8-48d0-b3e5-2cae8e9b39b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e648b48b-82df-48e7-acb5-4fe0d7f5585e", "AQAAAAIAAYagAAAAEIodw1MPhSsgo9VKAnZhKNrlt00+X4LCLxE1LYD/IUbJZNe3yM6Q1xq0npzhRlI2/Q==", "f075c32e-8b60-4b8c-9407-d64d6f5be393" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82f29695-6527-4167-848b-304606a57186", "AQAAAAIAAYagAAAAECvwzOg9i/RtC1mxC69l++/P+mRE1V7sFUb3rCpBsERHgnVeHbQItzEB0jGyWhXKIQ==", "57b6fcbe-b6f7-4ae3-810b-8397df19d7c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3edfa50-db4e-49b2-af7b-43ebdb91da38", "AQAAAAIAAYagAAAAEDXnp5OisLGFC4/4Q8FykD6KzKKM8IBmq39AlKv5+7k+9QnkhMFeFX+qXwkL+CqeQQ==", "e0484b93-8f85-4955-a24a-aa78ef648131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5515ce5-fa1b-4db2-afde-ab11d6fc6e2b", "AQAAAAIAAYagAAAAEJ6ghXOe9LHb6qYzz5tVOoJxhB0ofzP+ioXM13ZAS07lmWy9YfI+g7QoXnkajhc3Kg==", "cebfdc09-298a-4004-97b6-f964c4260d94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81ea8256-d7a3-4850-964e-df2651d4b64d", "AQAAAAIAAYagAAAAEH/ntxW25jNkGOsda5Vyll91X7EGtJ6eFVhq1V5oRQEqMZ/n1mGJmanwPaSS5DUmCQ==", "6493de99-6e8a-467b-b8fa-919be366e752" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Artistic" },
                    { 2, "Shy" },
                    { 3, "Social" },
                    { 4, "Video Gamer" },
                    { 5, "Liberal" },
                    { 6, "Conservative" },
                    { 7, "Music lover" },
                    { 8, "Bookworm" },
                    { 9, "Adventurer" },
                    { 10, "Studious" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f71549f1-2ac2-4128-8021-320791ac1877", "AQAAAAIAAYagAAAAEM1TEKxwr/04UvQ9D2Sxm+ygPUUSEr5YpUIQ5/E2WLPgX453tUdfYMSySTxPSFhHuQ==", "19a81ed6-b206-43c5-aab9-789df3f24c8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8deed3d4-0972-41d9-bc0f-e6536a72225e", "AQAAAAIAAYagAAAAEAlvUEef91Qanonn1b6obYJ3pzrLhMnFFzS5XJSnEs1LthDmzpVLXNBXCcVMQh00xw==", "330e10fa-6f3c-4253-8e4c-da61259d35a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eac9ba4-f874-45fc-8b60-2733bc61da5a", "AQAAAAIAAYagAAAAEKYszD3IAXmkdO3Z/CeEPca8ds07pGd1sHIhmpdJs7DRBnvJh/AtbEqmT2r1UnPO6w==", "19cc447c-2bfe-4288-a49c-d196e5658187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39155bfd-5311-44c4-9aa0-8ad9477e691a", "AQAAAAIAAYagAAAAEEqrRoiPl+9VXuE/1+nlY5LeekgLPAunk5Wm3AJDngQ+71eu5n/FgUgyL7QYmGyZCw==", "7281eaaf-7250-44ec-a87f-001e55a352ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f4c2c5c-c53d-43c8-8362-f628c223e345", "AQAAAAIAAYagAAAAEEFtzz34snarrRvZOtJITfnW+4TxDJKJxPEac/aTNaNA4iPSt5iT4CcpCOb3siNSoQ==", "16be7471-2eff-4c46-b56e-c9f07054e1e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25b0d190-d493-4154-b10f-7d3f18eddcb6", "AQAAAAIAAYagAAAAEFQ1NT7qMZfLNSlfDzvjb+sV0DDuI5NuWWH/3qas9JnNDwWAoq5+KU1THRc+UU3fEA==", "366001f3-a267-45e5-b89d-fa2c82267556" });
        }
    }
}
