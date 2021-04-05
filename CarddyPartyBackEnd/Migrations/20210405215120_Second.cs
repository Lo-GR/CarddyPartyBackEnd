using Microsoft.EntityFrameworkCore.Migrations;

namespace CarddyPartyBackEnd.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Players_PlayerID",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "PlayerID",
                table: "Cards",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_PlayerID",
                table: "Cards",
                newName: "IX_Cards_PlayerId");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1,
                column: "PlayerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2,
                column: "PlayerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3,
                column: "PlayerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 4,
                column: "PlayerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 5,
                column: "PlayerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 6,
                column: "PlayerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 7,
                column: "PlayerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 8,
                column: "PlayerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 9,
                column: "PlayerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 10,
                column: "PlayerId",
                value: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Players_PlayerId",
                table: "Cards",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Players_PlayerId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Cards",
                newName: "PlayerID");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards",
                newName: "IX_Cards_PlayerID");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerID",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 4,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 5,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 6,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 7,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 8,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 9,
                column: "PlayerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 10,
                column: "PlayerID",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Players_PlayerID",
                table: "Cards",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "PlayerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
