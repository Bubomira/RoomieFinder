using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedRequestEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer for a request")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestType = table.Column<int>(type: "int", nullable: false, comment: "Shows the the of the request- can be for a single room, sepcific/different roomate"),
                    RequestStatus = table.Column<int>(type: "int", nullable: false, comment: "Shows the sttaus of the request- pending, archived, accepted or declined"),
                    Comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Additional comment toward the request"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "the identifyer of the student who made the request")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "A request made by a student connected with rooms and roomates");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e8a2b8d-4ad5-43a7-a09f-3225df472651", "AQAAAAIAAYagAAAAENYxvR+G+0LcjCaUJ3xRF9pzGq3OHPeYdiBxPLVtSJm7uNBtabaK1zTGfxU5/0WBFg==", "93b82816-6c4a-48bd-a574-26f4db7562b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c780260d-788f-4dcb-bd32-825497d4ec9e", "AQAAAAIAAYagAAAAEB96llldfRxX+Nu7dweTrpnlGcGegTYtZ6PbZIUK2Ssmr7eVM3pOXpJrG8kvV4nvzg==", "0c818a1b-02ba-4142-8f0e-f44214beba80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37dce226-58fa-4d4b-a017-519333d467cd", "AQAAAAIAAYagAAAAEN1uri/MFq4b/eehZYgWBdYQ+NPYWgri0z086PL5asp0+3xDAMu851nQK0GmtFdWfA==", "6d130d13-b752-4d50-b135-ce06f98fd0d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d5b6dd8-71ca-42fd-ac4f-b8f86fd203d7", "AQAAAAIAAYagAAAAEG20yYPt0a3W+N9V9VaYLAM428Yc1UNR6Zvtpm99LfOEv5SDWruiXL8vIIBjriH8ug==", "ccfd9303-3323-4b37-8ff2-0b9202c23a82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85f8d13c-0073-4dfc-b577-7e880c660f66", "AQAAAAIAAYagAAAAEO9iKSFWU/2Tp61asZX7awcRiH2nyKjSjrGdhHy3GCPuqJtt2zh6N6UFBWsJB6PEdg==", "3bee8a98-3373-4a73-b021-0d9ad2fc00ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "881ca144-9734-495c-90ee-224f8b2a8c84", "AQAAAAIAAYagAAAAEMCkxeTuHSWzQIA0N6VVrlLB117jDG2A/V33d0aP0YzkYJ7rqquF7qCVIaWsdp0EsA==", "33381e8d-7993-4ea2-b2f3-1d708529015a" });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StudentId",
                table: "Requests",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de2c0aa7-cc78-455a-8e00-4507d4479b45", "AQAAAAIAAYagAAAAEKbznmTe4SwTGeZZimfmjwMnlRwQjliQ+5JbMFF0RAuw9mPwnIIbgAa6awOzys3Gzg==", "ef068d6d-0d5f-4253-bb20-71be2a87c901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80aa59b1-b5b9-4562-bbc2-0ca4008e45ac", "AQAAAAIAAYagAAAAEPhSTWKLLE5nzHH+ja7Ftdl9LLauTFiRy0vp6w8slgzN4mO+LV4Zx5pO2gykWwss8Q==", "88051a73-bc71-43e6-b64f-a842473bdde3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82c38ecb-b676-4b84-aa5e-560e9158c124", "AQAAAAIAAYagAAAAEPFj8uOAmc5YrHcvSmKWEHdbIYeqv9ID0LJTkh2A9NrX1TSQAivl+e8dz9s+j7PTNw==", "b33df0be-a380-4d52-b346-a4c32741f691" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6da47834-bec9-4801-8618-940f22b3d6ea", "AQAAAAIAAYagAAAAEMD5V/sAGcZfuu7uF3OisVZZd9dN1ijDisZDBL2L/B+kssBcmRLDPuhrANdrmoSxgQ==", "9a02825c-fac4-45e2-980e-52ad49750bb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70032b10-5646-49ec-8c36-6f5958b9f19e", "AQAAAAIAAYagAAAAEKAFJ0OlSNvN4AJ5gGOaPDzSYy4k/gZj5JUwyn0ZCNa4VzVq8Wn5cVxamzj5m3Yn1A==", "690f3f48-4507-4fb0-81a7-660c4db90c3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1feef531-d2c1-4397-bbc9-e3cdaa3a76ee", "AQAAAAIAAYagAAAAEHEeI99H6GGVmpdzR5LZMVOG1o2CH6+DKp5K21SCswSG5K+LZH7ETK2yKEbrkOc+OA==", "ad6069ed-b530-44ca-9e0f-e111e8914f7a" });
        }
    }
}
