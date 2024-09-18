using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notify.Migrations
{
    /// <inheritdoc />
    public partial class addlistenlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListenListId",
                table: "AppAlbums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppListenList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppListenList", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppAlbums_ListenListId",
                table: "AppAlbums",
                column: "ListenListId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAlbums_AppListenList_ListenListId",
                table: "AppAlbums",
                column: "ListenListId",
                principalTable: "AppListenList",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAlbums_AppListenList_ListenListId",
                table: "AppAlbums");

            migrationBuilder.DropTable(
                name: "AppListenList");

            migrationBuilder.DropIndex(
                name: "IX_AppAlbums_ListenListId",
                table: "AppAlbums");

            migrationBuilder.DropColumn(
                name: "ListenListId",
                table: "AppAlbums");
        }
    }
}
