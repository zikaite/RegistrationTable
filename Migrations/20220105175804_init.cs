using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationForm.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerId = table.Column<int>(type: "int", nullable: true),
                    CreateQuestionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_CreateQuestions_CreateQuestionId",
                        column: x => x.CreateQuestionId,
                        principalTable: "CreateQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CreateQuestions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, null });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswerId", "CreateQuestionId", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, "Reikia atlikti rangos darbus" },
                    { 2, null, 1, "Rangos darbus atliks" },
                    { 3, null, 1, "Verslo klientas" },
                    { 4, null, 1, "Skaičiavimo metodas" },
                    { 5, null, 1, "Svarbus klientas" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Taip", 1 },
                    { 2, "Ne", 1 },
                    { 3, "Metinis rangovas", 2 },
                    { 4, "Mėnesinis rangovas", 2 },
                    { 5, "Taip", 3 },
                    { 6, "Ne", 3 },
                    { 7, "Automatinis", 4 },
                    { 8, "Rankinis", 4 },
                    { 9, "Taip", 5 },
                    { 10, "Ne", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CreateQuestionId",
                table: "Questions",
                column: "CreateQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "CreateQuestions");
        }
    }
}
