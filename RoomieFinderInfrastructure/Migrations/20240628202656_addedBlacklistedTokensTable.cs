using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedBlacklistedTokensTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlacklistedTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlacklistedTokens", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c564895-6dd6-429a-bf64-5326de9b9791", "AQAAAAIAAYagAAAAEDEJMB9b6dP2tINI78q0BQ9E1V9ATVSavuDEeIYTgROt3ZXd1scR1wzU4pCPuhJSbA==", "16711141-21f0-4bc7-bfd8-af55ca14f0e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7f563b0-829c-48dd-b398-7c758145f9d7", "AQAAAAIAAYagAAAAEJssi2tIGpgaDp4UiHnWAV9WR7YfwIPC7uR6gCcXj9r1NpXyA1AiSJe5BiLCl4coTQ==", "82428273-05e9-4710-834c-68cbb0818f08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395caaf1-6013-43d7-9b56-57b58814d603", "AQAAAAIAAYagAAAAEGkpHVkXUjjXePdHhFGTN8S5vLlxm1GYP06/V56l3B9jLh1AKWhFJsrrKaI5tIOvdQ==", "2c1e713f-9612-4b6f-a973-ca588b335ba8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50f80976-c8c1-48cb-b69c-340dcd7ece61", "AQAAAAIAAYagAAAAENbnaeVzwni5wDuL49hWTi7EIyOGWlKUz0qoFa0t655cWq3bo70gqcbgo2GUjOgNyQ==", "952be543-4542-4b26-be27-726cabb74460" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1b106b8-b608-42ef-9728-2876ef2e2d6f", "AQAAAAIAAYagAAAAEKO2e2NO+5hiefNraQrNgDt02dqCSECn5x9VgnIoe08G6fdyEyWtx5Y5vmKZNWY5+w==", "16a9e27c-144e-4513-b270-a2369d12c772" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "521bac87-26b1-408d-b7ac-af846032cae6", "AQAAAAIAAYagAAAAEAT31R9j0/9nBL2NPVHwThnRp+1kS01oGtUabtdkZ/yzDVkPGqgSt9nAvKSHPx2eLA==", "0b4e7c58-c4da-40d2-9952-0c648e1befa6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlacklistedTokens");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "814eea77-56ad-4b92-a7f0-0775db69e2f8", "AQAAAAIAAYagAAAAEIhC/iOi53bk7V79OyyDYIiSkjUfnI8pHI8Ds7S5GeX0a3+lZO7wAhdQtgsUBqx69Q==", "afa4ee30-a98c-4cc7-9c5c-31cf4e3bdc90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f30a499-3609-40fe-ad52-e920c1d1fa7b", "AQAAAAIAAYagAAAAED8lvhSnRQJaa2yHDINI4vxqSvD/LeXsyhvXl7rGuCkVRPDS85PUpp3ofyCe9KrBNQ==", "77309649-7f09-4f87-a6fb-407de2411167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e436310-e71a-4cc2-8b28-43d14b6a327d", "AQAAAAIAAYagAAAAEA17DFEQQoMX+auHGwthnz8N9xxqkk7vXd3h/2JY1lD37IBYjf5cZqwA+BMr4r0vRw==", "a29a1bc3-e92e-40a9-b201-37f6ed1df101" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18cc7c1c-b016-4158-ad87-0325143de47d", "AQAAAAIAAYagAAAAEKV2B5rzsLLUZo7DEapUrvTyk6u/IpIPAwcWZ1hu/BypJTIiomWUvIJZdmD+90OsDw==", "8d479d74-ca6b-4aad-80be-b5b21276a13a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e32f90d-5c19-4eca-ac48-05d7ea8a6a6e", "AQAAAAIAAYagAAAAEKs3YMCpvV5yczdggkO8O2joA8EiA5TU+Rw0XL+FlpD1pfKBa5XccrsRaI7dXsixmg==", "ba6b4948-b0cd-41c5-91e7-2df5157b8487" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a609f68-3cec-4f0c-9880-48e15a888827", "AQAAAAIAAYagAAAAEO0iJNaMe3mioEngtiqVp25WWbNWDLeDd7fWJBkD2UFFf1zoxhaLE6vK7QeqqQMrVA==", "d3632ed1-3ebf-4325-b9d7-56e86f71de3a" });
        }
    }
}
