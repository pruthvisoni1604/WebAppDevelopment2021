using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021_DynamicDevelopers.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Postalcode",
                table: "Customers",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Customers",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Customers",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    RegistrationtId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.RegistrationtId);
                    table.ForeignKey(
                        name: "FK_Registration_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registration_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "City", "CountryId", "Email", "Firstname", "Phone", "State" },
                values: new object[] { "Toronto", 1, "Namya.Patel123@domain.com", "Namya", "458-985-9658", "Ontario" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "9, Buckhurt street", "Utica", 3, "Pruthvi.Soni897@domain.com", "Pruthvi", "Soni", "458-987-9696", "M8H8Y9", "Newyork" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "78, Queen Rode", "Brampton", 1, "Sahay.Patel123@domain.com", "Vishwa", "Mavani", "123-456-7777", "M1U7O5", "Ontario" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "85, york residency", "Mumbai", 2, "Harsh.Raval999@domain.com", "Harsh", "Raval", "898-456-8890", "F5Y7U6", "Maharastra" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "65, strong trr", "Toronto", 1, "Vatsal3@domain.com", "Vatsal", "Bhavani", "123-999-7890", "M1T5P5", "Ontario" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "Dateopened",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "Dateopened",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "Dateopened",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 4,
                columns: new[] { "Dateopened", "TechnicianId" },
                values: new object[] { new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 5,
                columns: new[] { "Dateopened", "TechnicianId" },
                values: new object[] { new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local), 3 });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 6,
                column: "Dateopened",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 76, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 9, 23, 14, 20, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 3,
                columns: new[] { "Technicianemail", "Technicianname", "Technicianphone" },
                values: new object[] { "DeepakarMukhraji@domain.com", "Deepakar Mukhraji", "147-147-1474" });

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 4,
                columns: new[] { "Technicianemail", "Technicianname", "Technicianphone" },
                values: new object[] { "MalharDave@domain.com", "Malhar Dave", "456-456-4564" });

            migrationBuilder.CreateIndex(
                name: "IX_Registration_CustomerId",
                table: "Registration",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_ProductId",
                table: "Registration",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "Postalcode",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 51);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "City", "CountryId", "Email", "Firstname", "Phone", "State" },
                values: new object[] { "Ahmedabad", 2, "Rutik.Patel123@domain.com", "Rutik", "145-895-7945", "Gujrat" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "20, bobcat terr", "Toronto", 1, "Namya.Patel123@domain.com", "Namya", "Patel", "458-985-9658", "M1B5C9", "Ontario" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "9, Buckhurt street", "Utica", 3, "Pruthvi.Soni897@domain.com", "Pruthvi", "Soni", "458-987-9696", "M8H8Y9", "Newyork" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "78, Queen Rode", "Brampton", 1, "Sahay.Patel123@domain.com", "Vishwa", "Mavani", "123-456-7777", "M1U7O5", "Ontario" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { "85, york residency", "Mumbai", 2, "Harsh.Raval999@domain.com", "Harsh", "Raval", "898-456-8890", "F5Y7U6", "Maharastra" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[] { 7, "65, strong trr", "Toronto", 1, "Vatsal3@domain.com", "Vatsal", "Bhavani", "123-999-7890", "M1T5P5", "Ontario" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "Dateopened",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "Dateopened",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "Dateopened",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 6,
                column: "Dateopened",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 766, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 2, 27, 25, 769, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 3,
                columns: new[] { "Technicianemail", "Technicianname", "Technicianphone" },
                values: new object[] { "MickleRobert@domain.com", "", "897-897-8979" });

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 4,
                columns: new[] { "Technicianemail", "Technicianname", "Technicianphone" },
                values: new object[] { "MickleRobert@domain.com", "Mickle Robert", "897-897-8979" });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Technicianemail", "Technicianname", "Technicianphone" },
                values: new object[,]
                {
                    { 5, "DeepakarMukhraji@domain.com", "Deepakar Mukhraji", "147-147-1474" },
                    { 6, "MalharDave@domain.com", "Malhar Dave", "456-456-4564" }
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 4,
                columns: new[] { "Dateopened", "TechnicianId" },
                values: new object[] { new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 5,
                columns: new[] { "Dateopened", "TechnicianId" },
                values: new object[] { new DateTime(2021, 2, 20, 2, 27, 25, 770, DateTimeKind.Local), 6 });
        }
    }
}
