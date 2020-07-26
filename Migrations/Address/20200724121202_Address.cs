using Microsoft.EntityFrameworkCore.Migrations;

namespace NZMSA_mkmu260_Databases.Migrations.Address
{
    public partial class Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    addressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    streetNumber = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    suburb = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    postcode = table.Column<int>(nullable: false),
                    country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.addressId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
