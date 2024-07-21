using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoomieFinderInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbRefactoring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsAnswers");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.AddColumn<int>(
                name: "AnswerSheetId",
                table: "Students",
                type: "int",
                nullable: true,
                comment: "The unique identifyer leading to the student's answers");

            migrationBuilder.CreateTable(
                name: "AnswerSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer of each answersheet")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEditable = table.Column<bool>(type: "bit", nullable: false, comment: "Describes if an answer sheet can be filled out by students"),
                    IsMessy = table.Column<bool>(type: "bit", nullable: false, comment: "Boolean value which shows if the student prefers a messy/tidy roomate"),
                    IsIntrovert = table.Column<bool>(type: "bit", nullable: false, comment: "Boolean value which shows the preferred room atmosphere"),
                    GoesToSleepEarly = table.Column<bool>(type: "bit", nullable: false, comment: "Boolean value which depicts if the student goes to sleep early"),
                    LikesQuietness = table.Column<bool>(type: "bit", nullable: false, comment: "Boolean value which depicts if the student prefers a quiet atmpshere"),
                    WakesUpEarly = table.Column<bool>(type: "bit", nullable: false, comment: "Boolean value which depicts if the student prefers to wake up early"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "the identifyer of the student whose answers are this")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerSheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerSheets_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "The test which holds the roomate questions students need to fill out");

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer for a quality")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of quality")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsQualities",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "The student id who has picked the interest, part of composite key"),
                    QualityId = table.Column<int>(type: "int", nullable: false, comment: "The interest id picked by the student, part of composite key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsQualities", x => new { x.QualityId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentsQualities_Interests_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsQualities_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "All of the student interests used to make better roomate matches");

            migrationBuilder.InsertData(
                table: "AnswerSheets",
                columns: new[] { "Id", "GoesToSleepEarly", "IsEditable", "IsIntrovert", "IsMessy", "LikesQuietness", "StudentId", "WakesUpEarly" },
                values: new object[,]
                {
                    { 1, true, true, false, true, true, 1, false },
                    { 2, true, true, false, false, false, 2, true },
                    { 3, false, true, true, true, false, 3, false },
                    { 4, false, true, false, true, false, 4, true }
                });

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "AnswerSheetId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "AnswerSheetId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "AnswerSheetId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "AnswerSheetId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_AnswerSheets_StudentId",
                table: "AnswerSheets",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentsQualities_StudentId",
                table: "StudentsQualities",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerSheets");

            migrationBuilder.DropTable(
                name: "StudentsQualities");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropColumn(
                name: "AnswerSheetId",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer of each questionnaire")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Description of the questionnaire, gives aditional info"),
                    IsReadyForFilling = table.Column<bool>(type: "bit", nullable: false, comment: "Describes if a questionaire can be filled out by students"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "The title of a questionaire")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.Id);
                },
                comment: "The test which holds the roomate questions students need to fill out");

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer of a question")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "The title of the question"),
                    IsSingleAnswer = table.Column<bool>(type: "bit", nullable: false, comment: "The type of a question, can be radio or checkbox")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Questionnaires_QuestionnaireId",
                        column: x => x.QuestionnaireId,
                        principalTable: "Questionnaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Question from the test");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The unique identifyer for an answer")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The content of the answer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsAnswers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false, comment: "The answer id picked by the student, part of composite key"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "The student id who has picked the answer, part of composite key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsAnswers", x => new { x.AnswerId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentsAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsAnswers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "All of the student answers to the questionnaire");

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
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionnaireId",
                table: "Questions",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsAnswers_StudentId",
                table: "StudentsAnswers",
                column: "StudentId");
        }
    }
}
