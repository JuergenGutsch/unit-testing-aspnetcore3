using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebToTest.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 1, "2909 Furman Street ", "Cap-Santé", new DateTime(1994, 9, 7, 19, 55, 0, 0, DateTimeKind.Unspecified), "Antonio.Walker@microsoft.com", "Kayla", "Stewart", "Arkansas", "sold" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 24, "8039 Dakota Place ", "Moorpark", new DateTime(2017, 4, 12, 1, 33, 2, 0, DateTimeKind.Unspecified), "Paige.Thomas@microsoft.com", "Devin", "Verstraete", "American Samoa", "fap" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 23, "4684 Trucklemans Lane ", "Elmira", new DateTime(1954, 11, 2, 22, 45, 13, 0, DateTimeKind.Unspecified), "Kelsey.Jenkins@rogers.ca", "Gabriela", "Olsen", "Illinois", "williamsburg" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 22, "1602 Aitken Place ", "Marina", new DateTime(1900, 5, 30, 13, 57, 43, 0, DateTimeKind.Unspecified), "Luis.Murphy@hotmail.com", "Nathan", "Hernandez", "Washington", "carles" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 21, "2577 Bancroft Place ", "Canadian", new DateTime(1912, 9, 28, 0, 43, 20, 0, DateTimeKind.Unspecified), "Jeremy.Carter@live.com", "Carlos", "Richardson", "Mississippi", "sriracha" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 20, "8695 Grove Place ", "Chibougamau", new DateTime(1943, 7, 21, 10, 40, 20, 0, DateTimeKind.Unspecified), "Elizabeth.Anderson@gmx.com", "Angel", "Wood", "Connecticut", "Umami" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 19, "4222 Myrtle Avenue ", "Waterville", new DateTime(1907, 11, 10, 9, 46, 47, 0, DateTimeKind.Unspecified), "Lauren.Gonzalez@rogers.ca", "Alexa", "Long", "Missouri", "park" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 18, "9963 Logan Street ", "Ottawa", new DateTime(1968, 3, 4, 21, 3, 56, 0, DateTimeKind.Unspecified), "Elizabeth.Ward@microsoft.com", "Hannah", "Getzlaff", "South Dakota", "williamsburg" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 17, "2549 Paerdegat 12th Street ", "Shelbyville", new DateTime(1972, 8, 1, 19, 50, 13, 0, DateTimeKind.Unspecified), "Makayla.Hill@shaw.ca", "Sophia", "Thompson", "Colorado", "PBR" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 16, "4395 Kane Street ", "Pittsburg", new DateTime(1962, 6, 18, 9, 28, 14, 0, DateTimeKind.Unspecified), "Shelby.Ramirez@telus.net", "Hailey", "Daeninck", "Wyoming", "denim" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 15, "911 Division Avenue ", "Blossom", new DateTime(1985, 8, 14, 1, 18, 3, 0, DateTimeKind.Unspecified), "Abigail.Scott@shaw.ca", "Mason", "Lewis", "Tennessee", "company" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 14, "4976 Water Street ", "Petaluma", new DateTime(1918, 12, 31, 11, 14, 50, 0, DateTimeKind.Unspecified), "Kaitlyn.Morgan@hotmail.com", "Chloe", "Ratzlaff", "Minnesota", "future" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 13, "8913 Glenwood Road ", "Westway", new DateTime(1972, 11, 10, 3, 45, 36, 0, DateTimeKind.Unspecified), "Gavin.Wright@shaw.ca", "Rachel", "Brandzin", "Delaware", "Brooklyn" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 12, "8045 Ocean Court ", "Grand Terrace", new DateTime(1968, 9, 13, 16, 38, 6, 0, DateTimeKind.Unspecified), "Leslie.Perry@microsoft.com", "Taylor", "Olsen", "Indiana", "VHS" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 11, "4132 Walker Court ", "Prince Rupert", new DateTime(1958, 3, 7, 5, 44, 26, 0, DateTimeKind.Unspecified), "Leslie.Bennett@gmx.com", "Jeremy", "Martin", "Pennsylvania", "beer" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 10, "1942 Midwood Street ", "Blue Lake", new DateTime(1961, 11, 14, 19, 45, 16, 0, DateTimeKind.Unspecified), "Chloe.Turner@gmail.com", "Devin", "Main", "Louisiana", "sriracha" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 9, "7910 Burnett Street ", "Covina", new DateTime(1949, 9, 20, 0, 32, 36, 0, DateTimeKind.Unspecified), "Jose.Ramirez@att.com", "Aaliyah", "Green", "Montana", "thing" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 8, "3155 Danforth Street ", "L'Assomption", new DateTime(2010, 3, 24, 16, 4, 32, 0, DateTimeKind.Unspecified), "Paul.Morgan@att.com", "Savannah", "Mitchell", "Mississippi", "authentic" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 7, "8052 Stillwell Avenue ", "Lakeport", new DateTime(1905, 2, 14, 17, 35, 41, 0, DateTimeKind.Unspecified), "Evelyn.Wilson@shaw.ca", "Marissa", "Brooks", "Alaska", "artisan" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 6, "4969 Sterling Place ", "EurekaCounty seat", new DateTime(1964, 8, 9, 3, 4, 54, 0, DateTimeKind.Unspecified), "Elizabeth.Main@gmx.com", "Thomas", "Watson", "Virginia", "work" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 5, "7125 Paerdegat 15th Street ", "Manor", new DateTime(2017, 7, 11, 13, 58, 51, 0, DateTimeKind.Unspecified), "Isabel.Barnes@microsoft.com", "Rachel", "Foster", "Oregon", "ethical" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 4, "6565 Olean Street ", "Sunnyvale", new DateTime(1919, 3, 27, 20, 58, 43, 0, DateTimeKind.Unspecified), "Michelle.Long@hotmail.com", "Olivia", "Mitchell", "Guam", "vice" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 3, "4199 34th Street ", "Kitchener", new DateTime(1976, 5, 14, 19, 39, 43, 0, DateTimeKind.Unspecified), "Gabrielle.Verstraete@rogers.ca", "Julia", "Tellies", "Nevada", "echo" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 2, "8833 Pennsylvania Avenue ", "Turlock", new DateTime(1942, 9, 27, 8, 21, 29, 0, DateTimeKind.Unspecified), "Mason.Long@gmail.com", "Tanner", "Getzlaff", "North Dakota", "synth" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 25, "8334 Seacoast Terrace ", "Olney", new DateTime(1978, 6, 1, 18, 35, 29, 0, DateTimeKind.Unspecified), "Ashley.Bell@live.com", "Steven", "Perry", "Vermont", "child" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "LastName", "State", "Telephone" },
                values: new object[] { 26, "6138 Oxford Walk ", "Bartonville", new DateTime(1988, 2, 4, 11, 29, 43, 0, DateTimeKind.Unspecified), "Alexandria.Brandzin@hotmail.com", "Angel", "Hughes", "District of Columbia", "american" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
