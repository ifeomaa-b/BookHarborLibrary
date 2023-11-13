using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookHarbor.Data.Migrations
{
    /// <inheritdoc />
    public partial class BookContentAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Books",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Books",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Books",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Books",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Books",
            //    keyColumn: "Id",
            //    keyValue: 5);

            //migrationBuilder.DeleteData(
            //    table: "Books",
            //    keyColumn: "Id",
            //    keyValue: 6);

            //migrationBuilder.DeleteData(
            //    table: "Genres",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Genres",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Genres",
            //    keyColumn: "Id",
            //    keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "BookContent",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookContent",
                table: "Books");

            //migrationBuilder.InsertData(
            //    table: "Genres",
            //    columns: new[] { "Id", "CreatedAt", "DisplayOrder", "Name", "UpdatedAt" },
            //    values: new object[,]
            //    {
            //        { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Action", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
            //        { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Scifi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
            //        { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "History", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Books",
            //    columns: new[] { "Id", "Author", "CreatedAt", "Description", "GenreId", "ISBN", "ImageUrl", "PublishedDate", "Publisher", "Title", "TotalPageCount", "UpdatedAt" },
            //    values: new object[,]
            //    {
            //        { 1, "Billy Spark", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 1, "SWD9999001", "", new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gemma Code Press", "Fortune of Time", 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
            //        { 2, "Nancy Hoover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 2, "CAW777777701", "", new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "Dark Skies", 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
            //        { 3, "Julian Button", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 1, "RITO5555501", "", new DateTime(2013, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelvin Press", "Vanish in the Sunset", 190, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
            //        { 4, "Abby Muscles", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 3, "WS3333333301", "", new DateTime(2014, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabinus Press", "Cotton Candy", 130, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
            //        { 5, "Ron Parker", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 1, "SOTJ1111111101", "", new DateTime(2016, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mazium Press", "Rock in the Ocean", 1728, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
            //        { 6, "Laura Phantom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 2, "FOT000000001", "", new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gemma Press", "Leaves and Wonders", 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
            //    });
        }
    }
}
