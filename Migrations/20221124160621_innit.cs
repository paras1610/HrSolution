using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class innit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Employees",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employees", x => x.Id);
            //    });

            //    migrationBuilder.CreateTable(
            //        name: "PreviousEmploymentInfos",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //            CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //            CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //            Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //            CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //            salary = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_PreviousEmploymentInfos", x => x.Id);
            //        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Employees");

            //migrationBuilder.DropTable(
            //    name: "PreviousEmploymentInfos");
        }
    }
}
