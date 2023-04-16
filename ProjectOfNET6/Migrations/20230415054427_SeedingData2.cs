using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOfNET6.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductPictures",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("fb6d4f10-79ed-4aff-a915-4ce29dc9c7e1"), "../../assets/images/louvre-102840_640.jpg" },
                    { 2, new Guid("fb6d4f10-79ed-4aff-a915-4ce29dc9c7e1"), "../../assets/images/japan-2014618_640.jpg" },
                    { 3, new Guid("fb6d4f10-79ed-4aff-a915-4ce29dc9c7e1"), "../../assets/images/ocean-829715_640.jpg" },
                    { 4, new Guid("fb6d4f10-79ed-4aff-a915-4ce29dc9c7e1"), "../../assets/images/osaka-2159435_640.jpg" },
                    { 5, new Guid("a1fd0bee-0afc-4586-96c8-f46b7c99d2a0"), "../../assets/images/japan-2014618_640.jpg" },
                    { 6, new Guid("a1fd0bee-0afc-4586-96c8-f46b7c99d2a0"), "../../assets/images/osaka-2159435_640.jpg" },
                    { 7, new Guid("a1fd0bee-0afc-4586-96c8-f46b7c99d2a0"), "../../assets/images/louvre-102840_640.jpg" },
                    { 8, new Guid("a1fd0bee-0afc-4586-96c8-f46b7c99d2a0"), "../../assets/images/castle-1736779_640.jpg" },
                    { 9, new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"), "../../assets/images/ocean-829715_640.jpg" },
                    { 10, new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"), "../../assets/images/osaka-2159435_640.jpg" },
                    { 11, new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"), "../../assets/images/milky-way-1023340_640.jpg" },
                    { 12, new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"), "../../assets/images/paris-843229_640.jpg" },
                    { 13, new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"), "../../assets/images/osaka-castle-1398116_640.jpg" },
                    { 14, new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"), "../../assets/images/shanghai-2446326_640.jpg" },
                    { 15, new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"), "../../assets/images/paris-843229_640.jpg" },
                    { 16, new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"), "../../assets/images/symbol-600334_640.jpg" },
                    { 17, new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"), "../../assets/images/railroad-tracks-163518_640.jpg" },
                    { 18, new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"), "../../assets/images/osaka-castle-1398116_640.jpg" },
                    { 19, new Guid("2430bf64-fd56-460c-8b75-da0a1d1cd74c"), "../../assets/images/japan-2014618_640.jpg" },
                    { 20, new Guid("2430bf64-fd56-460c-8b75-da0a1d1cd74c"), "../../assets/images/milky-way-1023340_640.jpg" },
                    { 21, new Guid("2430bf64-fd56-460c-8b75-da0a1d1cd74c"), "../../assets/images/castle-1736779_640.jpg" },
                    { 22, new Guid("2430bf64-fd56-460c-8b75-da0a1d1cd74c"), "../../assets/images/paris-843229_640.jpg" },
                    { 23, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"), "../../assets/images/osaka-castle-1398116_640.jpg" },
                    { 24, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"), "../../assets/images/paris-843229_640.jpg" },
                    { 25, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"), "../../assets/images/ocean-829715_640.jpg" },
                    { 26, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"), "../../assets/images/louvre-102840_640.jpg" },
                    { 27, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"), "../../assets/images/louvre-102840_640.jpg" },
                    { 28, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"), "../../assets/images/louvre-102840_640.jpg" },
                    { 29, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"), "../../assets/images/louvre-102840_640.jpg" },
                    { 30, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"), "../../assets/images/louvre-102840_640.jpg" },
                    { 31, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"), "../../assets/images/louvre-102840_640.jpg" },
                    { 32, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47111"), "../../assets/images/castle-1736779_640.jpg" },
                    { 33, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47111"), "../../assets/images/castle-1736779_640.jpg" },
                    { 34, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47111"), "../../assets/images/castle-1736779_640.jpg" },
                    { 35, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47111"), "../../assets/images/castle-1736779_640.jpg" },
                    { 36, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47112"), "../../assets/images/ocean-829715_640.jpg" },
                    { 37, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47112"), "../../assets/images/ocean-829715_640.jpg" },
                    { 38, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47112"), "../../assets/images/ocean-829715_640.jpg" },
                    { 39, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47112"), "../../assets/images/ocean-829715_640.jpg" },
                    { 40, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47113"), "../../assets/images/osaka-castle-1398116_640.jpg" },
                    { 41, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47113"), "../../assets/images/osaka-castle-1398116_640.jpg" },
                    { 42, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47113"), "../../assets/images/osaka-castle-1398116_640.jpg" },
                    { 43, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"), "../../assets/images/osaka-castle-1398116_640.jpg" },
                    { 44, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"), "../../assets/images/japan-2014618_640.jpg" },
                    { 45, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"), "../../assets/images/japan-2014618_640.jpg" },
                    { 46, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"), "../../assets/images/japan-2014618_640.jpg" },
                    { 47, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"), "../../assets/images/japan-2014618_640.jpg" },
                    { 48, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"), "../../assets/images/paris-843229_640.jpg" },
                    { 49, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"), "../../assets/images/paris-843229_640.jpg" },
                    { 50, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"), "../../assets/images/paris-843229_640.jpg" },
                    { 51, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"), "../../assets/images/paris-843229_640.jpg" },
                    { 52, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"), "../../assets/images/paris-843229_640.jpg" },
                    { 53, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47116"), "../../assets/images/milky-way-1023340_640.jpg" },
                    { 54, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47116"), "../../assets/images/milky-way-1023340_640.jpg" },
                    { 55, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47116"), "../../assets/images/milky-way-1023340_640.jpg" },
                    { 56, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47116"), "../../assets/images/milky-way-1023340_640.jpg" },
                    { 57, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47117"), "../../assets/images/louvre-102840_640.jpg" },
                    { 58, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47117"), "../../assets/images/louvre-102840_640.jpg" },
                    { 59, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47117"), "../../assets/images/louvre-102840_640.jpg" },
                    { 60, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47117"), "../../assets/images/louvre-102840_640.jpg" },
                    { 61, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47118"), "../../assets/images/louvre-102840_640.jpg" },
                    { 62, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47118"), "../../assets/images/louvre-102840_640.jpg" },
                    { 63, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47118"), "../../assets/images/louvre-102840_640.jpg" },
                    { 64, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47118"), "../../assets/images/louvre-102840_640.jpg" },
                    { 65, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47119"), "../../assets/images/louvre-102840_640.jpg" },
                    { 66, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47119"), "../../assets/images/louvre-102840_640.jpg" },
                    { 67, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47119"), "../../assets/images/louvre-102840_640.jpg" },
                    { 68, new Guid("39996f34-013c-4fc6-b1b3-0c1036c47119"), "../../assets/images/louvre-102840_640.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductPictures",
                keyColumn: "Id",
                keyValue: 68);
        }
    }
}
