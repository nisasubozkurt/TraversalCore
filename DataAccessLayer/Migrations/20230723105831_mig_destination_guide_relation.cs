using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_destination_guide_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentState",
                table: "Comments",
                newName: "CommentStatus");

            migrationBuilder.AddColumn<int>(
                name: "GuidID",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuideID",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_GuideID",
                table: "Destinations",
                column: "GuideID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides_GuideID",
                table: "Destinations",
                column: "GuideID",
                principalTable: "Guides",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides_GuideID",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_GuideID",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "GuidID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "GuideID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentStatus",
                table: "Comments",
                newName: "CommentState");
        }
    }
}
