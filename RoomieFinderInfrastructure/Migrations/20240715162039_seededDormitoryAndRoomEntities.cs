using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seededDormitoryAndRoomEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Dormitories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "First dormitory" },
                    { 2, "Second dormitory" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DormitoryId", "RemainingCapacity", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { 1, 1, 2, 101, 2 },
                    { 2, 1, 2, 102, 2 },
                    { 3, 1, 4, 204, 3 },
                    { 4, 1, 4, 205, 3 },
                    { 5, 1, 4, 307, 3 },
                    { 6, 2, 1, 101, 1 },
                    { 7, 2, 1, 102, 1 },
                    { 8, 2, 2, 208, 2 },
                    { 9, 2, 4, 209, 3 },
                    { 10, 2, 1, 301, 1 },
                    { 11, 2, 1, 302, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dormitories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dormitories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1686a9ff-f3a8-4133-b284-1852dba3f11a", "AQAAAAIAAYagAAAAECbasymwVYWsQ4Yz2D+pA10Vk1q98xv3bNf1cBqls0Q/YlotFbZMQVb9dPrFkPRdyg==", "4fe7ce16-93b7-4c6d-82bd-aabf637c2cd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c7d9a50-097c-4931-95c2-48d499c2b5ba", "AQAAAAIAAYagAAAAEMRm1kXVh1YWzAhg4f2NEQV3yIyCxyV90ccupphWBmdRjQIjmTp03nSa62242sKa1Q==", "78afc755-4fff-435e-b95f-a7ca7c1fa20b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6af93970-94b6-4836-bf78-c3293f655097", "AQAAAAIAAYagAAAAEGAsT5w+Ci7jkjFQoH7qrt6JyiipvL7sN8uyOQjETW1tv+u7chnZLpGjjW4G9eQU3g==", "f1914775-0cd8-4be5-8e4d-4be8bfa7097a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3976e326-325e-4351-9fe1-f691fa0c4f9a", "AQAAAAIAAYagAAAAEIDVb0UcOvHaZ9zvxd9jv67XDDhMm1lbPh7LPLEIgZnSppeSQzGczalgXWU9k8DOQQ==", "e1d9d492-06db-4384-b471-cd004f3d19ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfb6b1c4-77e6-4739-8984-3f169b5df412", "AQAAAAIAAYagAAAAEB/2grbkfLqct5pqQaE84fSmcey6TMjBqKbFg+ttvK1Ifec9hSXApKkneMbbLE73XQ==", "67299d51-8943-448e-b61f-db05089607d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "402c1cfc-be45-4e86-a4fa-ddc8913f097d", "AQAAAAIAAYagAAAAEADeg8QSNtS5r36N2hVhlouVBrdrib8ZmsofoxOv0I/GBaebBotuQ7yat5krTWYEag==", "f3b4e255-f121-4b1b-a01d-b6bae46e94b4" });
        }
    }
}
