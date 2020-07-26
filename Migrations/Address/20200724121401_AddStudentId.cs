using Microsoft.EntityFrameworkCore.Migrations;

namespace NZMSA_mkmu260_Databases.Migrations.Address
{
    public partial class AddStudentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "studentId",
                table: "Address",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "studentId",
                table: "Address");
        }
    }
}
