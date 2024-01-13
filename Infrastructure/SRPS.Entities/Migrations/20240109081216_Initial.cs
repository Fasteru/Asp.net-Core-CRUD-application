using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRPS.Entities.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SRPS_TBL_Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Class = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FathersName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MothersName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Marks = table.Column<int>(type: "int", nullable: true),
                    SchoolHouse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsFeesPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRPS_TBL_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SRPS_TBL_Students",
                columns: new[] { "Id", "Class", "FathersName", "IsFeesPaid", "Marks", "MothersName", "SchoolHouse", "StudentName" },
                values: new object[] { new Guid("a7b4f091-8c66-4a0b-9e86-02b8c1f64c5e"), "XII", "Raj Shukla", false, 90, "Gayatri Shukla", "Challenger", "Rahul Shukla" });

            migrationBuilder.InsertData(
                table: "SRPS_TBL_Students",
                columns: new[] { "Id", "Class", "FathersName", "IsFeesPaid", "Marks", "MothersName", "SchoolHouse", "StudentName" },
                values: new object[] { new Guid("d3f6452d-b736-4d05-8390-79048e69c3cc"), "XI", "Ram Kumar", false, 80, "Shoobha Devi", "Challenger", "Rohit Kumar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SRPS_TBL_Students");
        }
    }
}
