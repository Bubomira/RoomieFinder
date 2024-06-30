using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editedColumnQuestionaire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CanQuestionsBeEdited",
                table: "Questionnaires",
                newName: "IsReadyForFilling");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9e7a9be-1aac-4c58-afc7-79187af84c29", "AQAAAAIAAYagAAAAEDkRWsD17Y4L9mKqU/qLPFm/lQvrKje5GjxMvTXuW6JnlVzy37qfoaOK/ae619bWHA==", "c3dec7a9-17f6-463e-8c2b-bc0d0eee8bed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55100502-de6b-4a2f-bfc4-fca810e72873", "AQAAAAIAAYagAAAAEDLo5YcTtewmSaIZnoKbpOq0U6JOj7DFYdva6NDOMt03CqvWbjIKx32jLeMp9uNs6w==", "3e816939-2764-4728-bf27-0d434b6692f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51d96dfa-943a-44a3-a39b-136844852055",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e24fd627-d723-4b8f-aa1b-e025d652de15", "AQAAAAIAAYagAAAAEACKwl8//GNTVHiAe+0pWmJTZyGkvWqC2TK4tUu6CGd+qhDTqdh5vfgkMvOPCeNUAg==", "3835a51a-3054-4f55-8fe8-616f48f88b52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cc9efa-570e-464c-a3c3-805a1cf94b30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8522733e-cc5e-4f42-80d7-e8e681d097a6", "AQAAAAIAAYagAAAAEMRxHcWUw3RoPL3Fl8elodx+4viB7BEqpTWml8LYIKAbS2TQk9gvWffrGHwmdDcq+w==", "729e60fd-4c14-4ccd-a701-8dbb8e328922" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88273e30-0ad0-4095-b288-51f0d4f2eba0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61b40d1c-7dcc-4c6c-8311-7032d7787757", "AQAAAAIAAYagAAAAEPTE5r3wdcVK3lydNEDoyMN9WfPxu1PFRMfrBK7SJhLw+0Yl3ukkkoN7oFHzejMuyw==", "2c579ff4-ab15-446d-9683-9a22d214bec3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3beb38-92d0-44b9-9470-d24ffe951850",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d6976b3-b7b5-4de1-bf30-ba1af00433f4", "AQAAAAIAAYagAAAAEAwebPlnm+cl9Bt8krFdNp8OEhpExOTBsE9FJEt5NxLWRN1oyQCCYjWHO/zD3C8Faw==", "f0b1db55-9777-4752-9430-0cf3dd509312" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsReadyForFilling",
                table: "Questionnaires",
                newName: "CanQuestionsBeEdited");

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
    }
}
