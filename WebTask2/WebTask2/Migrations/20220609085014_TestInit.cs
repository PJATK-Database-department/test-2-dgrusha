using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTask2.Migrations
{
    public partial class TestInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Confectioneries",
                columns: table => new
                {
                    IdConfectionery = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PricePerOne = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confectioneries", x => x.IdConfectionery);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "ClientOrders",
                columns: table => new
                {
                    IdClientOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IDClient = table.Column<int>(type: "int", nullable: false),
                    IDEmployee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrders", x => x.IdClientOrder);
                    table.ForeignKey(
                        name: "FK_ClientOrders_Clients_IDClient",
                        column: x => x.IDClient,
                        principalTable: "Clients",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientOrders_Employees_IDEmployee",
                        column: x => x.IDEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Confectionary_ClientOrders",
                columns: table => new
                {
                    IdClientOrder = table.Column<int>(type: "int", nullable: false),
                    IdConfectionary = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confectionary_ClientOrders", x => new { x.IdClientOrder, x.IdConfectionary });
                    table.ForeignKey(
                        name: "FK_Confectionary_ClientOrders_ClientOrders_IdClientOrder",
                        column: x => x.IdClientOrder,
                        principalTable: "ClientOrders",
                        principalColumn: "IdClientOrder",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Confectionary_ClientOrders_Confectioneries_IdConfectionary",
                        column: x => x.IdConfectionary,
                        principalTable: "Confectioneries",
                        principalColumn: "IdConfectionery",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "IdClient", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "string1", "String2" },
                    { 2, "string3", "String4" },
                    { 3, "string5", "String6" }
                });

            migrationBuilder.InsertData(
                table: "Confectioneries",
                columns: new[] { "IdConfectionery", "Name", "PricePerOne" },
                values: new object[,]
                {
                    { 1, "string1", 5.75f },
                    { 2, "string2", 5.75f },
                    { 3, "string3", 5.75f },
                    { 4, "string4", 5.75f }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdEmployee", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "string1", "String2" },
                    { 2, "string3", "String4" },
                    { 3, "string5", "String6" }
                });

            migrationBuilder.InsertData(
                table: "ClientOrders",
                columns: new[] { "IdClientOrder", "Comments", "CompletionDate", "IDClient", "IDEmployee", "OrderDate" },
                values: new object[] { 1, "dadaczcz", new DateTime(2022, 6, 10, 10, 50, 13, 998, DateTimeKind.Local).AddTicks(8593), 1, 1, new DateTime(2022, 6, 9, 10, 50, 13, 996, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.InsertData(
                table: "ClientOrders",
                columns: new[] { "IdClientOrder", "Comments", "CompletionDate", "IDClient", "IDEmployee", "OrderDate" },
                values: new object[] { 2, "dadaczdadadacz", new DateTime(2022, 6, 11, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(313), 2, 2, new DateTime(2022, 6, 9, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.InsertData(
                table: "ClientOrders",
                columns: new[] { "IdClientOrder", "Comments", "CompletionDate", "IDClient", "IDEmployee", "OrderDate" },
                values: new object[] { 3, "dadaczcdadadadddadaz", new DateTime(2022, 6, 12, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(319), 3, 3, new DateTime(2022, 6, 9, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.InsertData(
                table: "Confectionary_ClientOrders",
                columns: new[] { "IdClientOrder", "IdConfectionary", "Amount", "Comments" },
                values: new object[,]
                {
                    { 1, 1, 20, "dadaczcz" },
                    { 2, 2, 30, "dadacdadazcz" },
                    { 3, 3, 40, "dadacdadazdadacz" },
                    { 3, 4, 50, "dada1111dadazdadacz" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrders_IDClient",
                table: "ClientOrders",
                column: "IDClient");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrders_IDEmployee",
                table: "ClientOrders",
                column: "IDEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Confectionary_ClientOrders_IdConfectionary",
                table: "Confectionary_ClientOrders",
                column: "IdConfectionary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Confectionary_ClientOrders");

            migrationBuilder.DropTable(
                name: "ClientOrders");

            migrationBuilder.DropTable(
                name: "Confectioneries");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
