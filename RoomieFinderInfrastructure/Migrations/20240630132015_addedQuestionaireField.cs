using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedQuestionaireField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanQuestionsBeEdited",
                table: "Questionnaires",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21714625-f0d0-4182-bb71-0171b8e3beb2", "AQAAAAIAAYagAAAAELp78VuhMesbnwRPJsLcXF3+i10ox+Mtm4DIfddgp8wV7f+7l17Pdnulz2OwL6AzEg==", "75205b35-37d2-4e00-9b1e-1b6542cd6e13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa26691-c7cb-4a42-a017-177dd85a4751", "AQAAAAIAAYagAAAAEOGljtdns5hcA52fpDRcHMHPR9dsc/Dnr4U/Bb119FlZLMwAVqMEwFHZl9Jcy7FssQ==", "0d2e117a-56e6-46fb-a3d2-46813c84c7d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f40bdb75-887b-4b78-9b29-76dd8073fa1a", "AQAAAAIAAYagAAAAEAY1bHbiKxsTav+B/f/DTZKRRus3ra/a4vVZzmfXRpafB8hsmxDXoO5bPk0lq/Qubw==", "694db8d9-d054-4951-8761-13735623dd26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4962c1b7-53d3-4b8e-9409-53f0442a68f0", "AQAAAAIAAYagAAAAELHrvReptMJFXDWkJOI+4vrkympEAyopQlXUQENk98a2E73Hhej6ipvUFzGq5mMbDA==", "6d3f2f4f-9243-43e0-a590-9bc4adc9afb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b1afd82-4fe2-4694-b524-7b56c750a860", "AQAAAAIAAYagAAAAELD5C/mSQm13xgFS4ImCqbDQiZvGK1ScOCPjReZKEwk6ZfsirY0669L0lJ5CprWilg==", "4a783ddc-7d12-4363-8418-15e31162b7da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5abc924-9c7d-42e5-91e7-8927b177bb30", "AQAAAAIAAYagAAAAEOG6g7RSU00gvDDkHw0b22UiUYD9vGMl2/B030ys3KTyjf2HoDJ84oo1iSk/PddWxA==", "b19e455c-fb99-47b5-8a1e-ce8c4180dab3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanQuestionsBeEdited",
                table: "Questionnaires");

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
    }
}
