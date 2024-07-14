using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newColumnsForEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMale",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "An indicator to the gender of a student");

            migrationBuilder.AddColumn<int>(
                name: "RemainingCapacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Shows the remaining empty spots for a room, set to 0 when the room is full");

            migrationBuilder.AlterColumn<bool>(
                name: "IsReadyForFilling",
                table: "Questionnaires",
                type: "bit",
                nullable: false,
                comment: "Describes if a questionaire can be filled out by students",
                oldClrType: typeof(bool),
                oldType: "bit");

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "IsMale",
                value: false);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "IsMale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "IsMale",
                value: false);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "IsMale",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMale",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "RemainingCapacity",
                table: "Rooms");

            migrationBuilder.AlterColumn<bool>(
                name: "IsReadyForFilling",
                table: "Questionnaires",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Describes if a questionaire can be filled out by students");

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
    }
}
