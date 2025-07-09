using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class M04041801 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", nullable: false),
                    FatherName = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NationalCode = table.Column<double>(type: "REAL", nullable: false),
                    BirthCertificateNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<double>(type: "REAL", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<double>(type: "REAL", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    CertificateNumber = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<double>(type: "REAL", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cooperatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandName = table.Column<string>(type: "TEXT", nullable: false),
                    Employee_1Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Employee_2Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Employee_3Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Driver_1Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Driver_2Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Driver_3Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Driver_4Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Driver_5Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Driver_6Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Driver_7Id = table.Column<int>(type: "INTEGER", nullable: true),
                    PhoneNumber = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Driver_1Id",
                        column: x => x.Driver_1Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Driver_2Id",
                        column: x => x.Driver_2Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Driver_3Id",
                        column: x => x.Driver_3Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Driver_4Id",
                        column: x => x.Driver_4Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Driver_5Id",
                        column: x => x.Driver_5Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Driver_6Id",
                        column: x => x.Driver_6Id,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Driver_7Id",
                        column: x => x.Driver_7Id,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Employee_1Id",
                        column: x => x.Employee_1Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Employee_2Id",
                        column: x => x.Employee_2Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cooperatives_Employees_Employee_3Id",
                        column: x => x.Employee_3Id,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Driver_1Id",
                table: "Cooperatives",
                column: "Driver_1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Driver_2Id",
                table: "Cooperatives",
                column: "Driver_2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Driver_3Id",
                table: "Cooperatives",
                column: "Driver_3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Driver_4Id",
                table: "Cooperatives",
                column: "Driver_4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Driver_5Id",
                table: "Cooperatives",
                column: "Driver_5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Driver_6Id",
                table: "Cooperatives",
                column: "Driver_6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Driver_7Id",
                table: "Cooperatives",
                column: "Driver_7Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Employee_1Id",
                table: "Cooperatives",
                column: "Employee_1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Employee_2Id",
                table: "Cooperatives",
                column: "Employee_2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cooperatives_Employee_3Id",
                table: "Cooperatives",
                column: "Employee_3Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cooperatives");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
