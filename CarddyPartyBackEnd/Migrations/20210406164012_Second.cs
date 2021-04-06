using Microsoft.EntityFrameworkCore.Migrations;

namespace CarddyPartyBackEnd.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desciprtion",
                table: "Prompts",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "PromptId", "Description" },
                values: new object[] { 1, "Who was the best President?" });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "PromptId", "Description" },
                values: new object[] { 2, "Why did the cat cross the road?" });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "PromptId", "Description" },
                values: new object[] { 3, "The unintentional best thing about Epicodus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Prompts",
                newName: "Desciprtion");
        }
    }
}
