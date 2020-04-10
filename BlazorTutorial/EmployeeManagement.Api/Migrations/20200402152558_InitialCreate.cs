using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Eberhard@gamil.com", "Boy", 0, "Satterfitt", "images/Boy.jpg" },
                    { 2, new DateTime(1981, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Wyllcock@gamil.com", "Lindsy", 1, "James", "images/Lindsy.jpg" },
                    { 3, new DateTime(1981, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Simkovich@gamil.com", "Ryann", 1, "Harris", "images/Ryann.jpg" },
                    { 4, new DateTime(1975, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Mandry@gamil.com", "Ruy", 0, "Mandry", "images/Ruy.jpg" },
                    { 5, new DateTime(1975, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Marcel@gamil.com", "Marcel", 0, "Mandry", "images/Marcel.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
