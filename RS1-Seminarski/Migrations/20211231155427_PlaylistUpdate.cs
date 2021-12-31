using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_Seminarski.Migrations
{
    public partial class PlaylistUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_Track_PlaylistTrackId",
                table: "Playlist");

            migrationBuilder.DropIndex(
                name: "IX_Playlist_PlaylistTrackId",
                table: "Playlist");

            migrationBuilder.DropColumn(
                name: "PlaylistTrackId",
                table: "Playlist");

            migrationBuilder.AlterColumn<string>(
                name: "PlaylistName",
                table: "Playlist",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrackId",
                table: "Playlist",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_TrackId",
                table: "Playlist",
                column: "TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_Track_TrackId",
                table: "Playlist",
                column: "TrackId",
                principalTable: "Track",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_Track_TrackId",
                table: "Playlist");

            migrationBuilder.DropIndex(
                name: "IX_Playlist_TrackId",
                table: "Playlist");

            migrationBuilder.DropColumn(
                name: "TrackId",
                table: "Playlist");

            migrationBuilder.AlterColumn<string>(
                name: "PlaylistName",
                table: "Playlist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PlaylistTrackId",
                table: "Playlist",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_PlaylistTrackId",
                table: "Playlist",
                column: "PlaylistTrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_Track_PlaylistTrackId",
                table: "Playlist",
                column: "PlaylistTrackId",
                principalTable: "Track",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
