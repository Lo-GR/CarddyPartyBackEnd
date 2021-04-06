using Microsoft.EntityFrameworkCore.Migrations;

namespace CarddyPartyBackEnd.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Theme",
                table: "Prompts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 1,
                column: "Theme",
                value: "politics");

            migrationBuilder.UpdateData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 2,
                column: "Theme",
                value: "jokes");

            migrationBuilder.UpdateData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 3,
                column: "Theme",
                value: "epicodus");

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "PromptId", "Description", "Theme" },
                values: new object[,]
                {
                    { 4, "Who had the worst scandal?", "politics" },
                    { 5, "Why did my dad leave me?", "jokes" },
                    { 6, "Epicodus is terrible at", "epicodus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "Prompts");
        }
    }
}
