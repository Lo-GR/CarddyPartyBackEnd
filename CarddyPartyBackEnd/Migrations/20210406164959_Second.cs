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
                values: new object[,]
                {
                    { 1, "This is example 1" },
                    { 2, "This is example 2" },
                    { 3, "This is example 3" },
                    { 4, "This is example 4" },
                    { 5, "This is example 5" }
                });
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

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "PromptId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Prompts",
                newName: "Desciprtion");
        }
    }
}
