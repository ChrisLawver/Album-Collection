using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordLabel",
                table: "Albums");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Image", "Name", "RecordLabel" },
                values: new object[] { 1, "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/4B95C840AF54D3C2580D53C19CFA240B0D9FD728A95A3F6814BD354CA746FF5F/scale?width=1200&aspectRatio=1.78&format=jpeg", "Hannah Montana", "Walt Disney" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Image", "Name", "RecordLabel" },
                values: new object[] { 2, "https://www.universalmusic.com/wp-content/uploads/2019/05/credit-ryan-jay.jpg", "Logic", "Visionary" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "Name" },
                values: new object[] { 1, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/6/60/Hannah_Montana_Forever.png/220px-Hannah_Montana_Forever.png", "Hannah Montana Forever" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "Name" },
                values: new object[] { 2, 2, "https://upload.wikimedia.org/wikipedia/en/4/4c/Logic_No_Pressure_album_cover.jpeg", "No Pressure" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "AlbumId", "Duration", "Link", "Title" },
                values: new object[] { 1, 1, 196, "https://www.youtube.com/watch?v=DcvB9cxDvvY", "Gonna Get This" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "AlbumId", "Duration", "Link", "Title" },
                values: new object[] { 2, 2, 153, "https://www.youtube.com/watch?v=LsfnODTWgss", "No Pressure Intro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "RecordLabel",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
