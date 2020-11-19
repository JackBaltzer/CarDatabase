using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDatabase.Migrations
{
    public partial class carownerchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CarOwners_OwnerId",
                table: "CarOwners",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarOwners_Cars_CarId",
                table: "CarOwners",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarOwners_Owners_OwnerId",
                table: "CarOwners",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOwners_Cars_CarId",
                table: "CarOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_CarOwners_Owners_OwnerId",
                table: "CarOwners");

            migrationBuilder.DropIndex(
                name: "IX_CarOwners_OwnerId",
                table: "CarOwners");
        }
    }
}
