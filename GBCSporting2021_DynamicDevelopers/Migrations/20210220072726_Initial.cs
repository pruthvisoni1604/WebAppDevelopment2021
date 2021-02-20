using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021_DynamicDevelopers.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    Productname = table.Column<string>(nullable: false),
                    Productprice = table.Column<double>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Technicianname = table.Column<string>(nullable: false),
                    Technicianemail = table.Column<string>(nullable: false),
                    Technicianphone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TechnicianId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Postalcode = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    TechnicianId = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Dateopened = table.Column<DateTime>(nullable: false),
                    Dateclosed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentId);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Technicians_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technicians",
                        principalColumn: "TechnicianId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "Canada" },
                    { 2, "India" },
                    { 3, "America" },
                    { 4, "Maxico" },
                    { 5, "Pakistan" },
                    { 6, "Russia" },
                    { 7, "China" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Productname", "Productprice", "ReleaseDate" },
                values: new object[,]
                {
                    { 6, "TRYT789", "Draft Manager 2.0", 7.69, new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local) },
                    { 5, "ST30", "schedule tracker 3.0", 4.89, new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local) },
                    { 4, "PS9", "Project Scheduler", 8.0, new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local) },
                    { 3, "CR50", "Class Reminder 5.0", 2.99, new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local) },
                    { 2, "AT564", "Accont Tracker", 7.99, new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local) },
                    { 1, "TRM789", "Tournament Master", 8.99, new DateTime(2021, 2, 20, 2, 27, 25, 766, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Technicianemail", "Technicianname", "Technicianphone" },
                values: new object[,]
                {
                    { 1, "MickleRobert@domain.com", "Mickle Robert", "897-897-8979" },
                    { 2, "PalakVyas@domain.com", "Palak Vyas", "123-123-1231" },
                    { 3, "MickleRobert@domain.com", "", "897-897-8979" },
                    { 4, "MickleRobert@domain.com", "Mickle Robert", "897-897-8979" },
                    { 5, "DeepakarMukhraji@domain.com", "Deepakar Mukhraji", "147-147-1474" },
                    { 6, "MalharDave@domain.com", "Malhar Dave", "456-456-4564" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[,]
                {
                    { 1, "45, King Road Street", "Toronto", 1, "Sahay.Patel123@domain.com", "Sahay", "Patel", "123-456-7890", "M1T5Y8", "Ontario" },
                    { 3, "20, bobcat terr", "Toronto", 1, "Namya.Patel123@domain.com", "Namya", "Patel", "458-985-9658", "M1B5C9", "Ontario" },
                    { 5, "78, Queen Rode", "Brampton", 1, "Sahay.Patel123@domain.com", "Vishwa", "Mavani", "123-456-7777", "M1U7O5", "Ontario" },
                    { 7, "65, strong trr", "Toronto", 1, "Vatsal3@domain.com", "Vatsal", "Bhavani", "123-999-7890", "M1T5P5", "Ontario" },
                    { 2, "20, bobcat terr", "Ahmedabad", 2, "Rutik.Patel123@domain.com", "Rutik", "Patel", "145-895-7945", "M1B5C9", "Gujrat" },
                    { 6, "85, york residency", "Mumbai", 2, "Harsh.Raval999@domain.com", "Harsh", "Raval", "898-456-8890", "F5Y7U6", "Maharastra" },
                    { 4, "9, Buckhurt street", "Utica", 3, "Pruthvi.Soni897@domain.com", "Pruthvi", "Soni", "458-987-9696", "M8H8Y9", "Newyork" }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "Dateclosed", "Dateopened", "Description", "ProductId", "TechnicianId", "title" },
                values: new object[,]
                {
                    { 2, 3, "", new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), "Program fail with error code 510, unable to open database", 2, 2, "Error in launching program" },
                    { 4, 3, "", new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), "database can not load when choose show all project", 4, 6, "Error in all project showing " },
                    { 6, 3, "", new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), "Get Error in setting class for reminder", 3, 4, "Error in setting Class" },
                    { 1, 5, "", new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), "Program fail with error code 510, unable to open database", 2, 2, "Error in launching program" },
                    { 5, 6, "", new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), "Some time draft can not be tracked", 6, 6, "Error in draft track 2.0" },
                    { 3, 4, "", new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), "404 error when chooose exit option and can not exit", 5, 4, "Error while choose exit option" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryId",
                table: "Customers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerId",
                table: "Incidents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductId",
                table: "Incidents",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechnicianId",
                table: "Incidents",
                column: "TechnicianId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
