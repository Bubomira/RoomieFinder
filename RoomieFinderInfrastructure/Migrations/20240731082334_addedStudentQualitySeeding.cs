using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedStudentQualitySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20a395e5-a0d9-46d1-967b-394cabe6d792", "AQAAAAIAAYagAAAAELRhps39sh52sUdOzNFRobou4JsJ4uiD+qsxoRJG/PXpowspA4VjufTDk+aHAoiMEQ==", "59a27808-acaf-4c08-927c-bb6eebc72757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15c111b0-23d4-4e0c-a9a7-157e989eeb04", "AQAAAAIAAYagAAAAEKrvaYdiqyqdItIv3TG1TYi5MSE3M4MNhMAxWDRjU7Y81Jf3HqdGT9pnYdMQ0eplFA==", "2638f008-e1b1-4070-a00e-0a4e6170d8a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85827822-21e5-4690-b185-d1c795279bcd", "AQAAAAIAAYagAAAAEIKmPiaTffLRmWslGeDEop98XSrUOz8w4pVAHBiUbR1vpw2jqSYMc6oDe7vZ6hLvPA==", "5dc5f114-7ed8-4def-97f6-8625895b9391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b0a206-d48b-43d4-969b-49d293e786e8", "AQAAAAIAAYagAAAAEAE1/sgQg39zfxQ1vpXxmwUu5A3BZVEPKgRsPl+4AaCknj0+Z+rhgZYtfRAPoKWe3w==", "901af0ed-6912-4700-8636-505ee27d8fce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd5d99da-7129-4233-a6aa-58cfd9261524", "AQAAAAIAAYagAAAAELM4cW7h2op2abHP2rq3bzUHmB34elXcGWlSuT7RB1vy/bpe3N3ySMMQvfMz1nuVDg==", "c1668b4e-40a7-40db-bdd9-92e3193ae66d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b272f6b5-f2a7-41f3-9bd0-494be89761d9", "AQAAAAIAAYagAAAAEMnHgg5eo8ml8zqoSORgLtyg8RsmM6rseq2t+IfEzlAtlpnipQzh4RV0Hru6xuv3tw==", "5097b4b4-ebb3-4bcf-af5e-b3ee74003ade" });

            migrationBuilder.InsertData(
                table: "StudentsQualities",
                columns: new[] { "QualityId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 8, 1 },
                    { 8, 4 },
                    { 9, 2 },
                    { 10, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "StudentsQualities",
                keyColumns: new[] { "QualityId", "StudentId" },
                keyValues: new object[] { 10, 4 });

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
        }
    }
}
