using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeUniversityAndUniAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dormitories_Universities_UniversityId",
                table: "Dormitories");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Universities_UniversityId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "UniversityAdmins");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Students_UniversityId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Questionnaires_UniversityId",
                table: "Questionnaires");

            migrationBuilder.DropIndex(
                name: "IX_Dormitories_UniversityId",
                table: "Dormitories");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Dormitories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Questionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Foreign key referencing table university");

            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Dormitories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer of each university")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of the university")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                },
                comment: "The university is where students go to study");

            migrationBuilder.CreateTable(
                name: "UniversityAdmins",
                columns: table => new
                {
                    UniversityAdminId = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer for each university admin")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UniversityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityAdmins", x => x.UniversityAdminId);
                    table.ForeignKey(
                        name: "FK_UniversityAdmins_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniversityAdmins_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "The users who is responsible for the tests and matching roomates");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UniversityId",
                table: "Students",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_UniversityId",
                table: "Questionnaires",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Dormitories_UniversityId",
                table: "Dormitories",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityAdmins_ApplicationUserId",
                table: "UniversityAdmins",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UniversityAdmins_UniversityId",
                table: "UniversityAdmins",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dormitories_Universities_UniversityId",
                table: "Dormitories",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Universities_UniversityId",
                table: "Questionnaires",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
