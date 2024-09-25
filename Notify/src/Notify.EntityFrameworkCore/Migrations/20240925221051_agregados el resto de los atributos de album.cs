using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notify.Migrations
{
    /// <inheritdoc />
    public partial class agregadoselrestodelosatributosdealbum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "AppAlbums",
                type: "int", // por que es un int esto?
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "AppAlbums",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "length",
                table: "AppAlbums",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<long>(
                name: "playCount",
                table: "AppAlbums",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "releaseDate",
                table: "AppAlbums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "released",
                table: "AppAlbums",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "AppAlbums");

            migrationBuilder.DropColumn(
                name: "country",
                table: "AppAlbums");

            migrationBuilder.DropColumn(
                name: "length",
                table: "AppAlbums");

            migrationBuilder.DropColumn(
                name: "playCount",
                table: "AppAlbums");

            migrationBuilder.DropColumn(
                name: "releaseDate",
                table: "AppAlbums");

            migrationBuilder.DropColumn(
                name: "released",
                table: "AppAlbums");
        }
    }
}
