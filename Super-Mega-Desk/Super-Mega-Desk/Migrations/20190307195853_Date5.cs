using Microsoft.EntityFrameworkCore.Migrations;

namespace Super_Mega_Desk.Migrations
{
    public partial class Date5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ShippingDays",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "ShippingCost",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "FinalCost",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "DrawerNumber",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ShippingDays",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "ShippingCost",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "FinalCost",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "DrawerNumber",
                table: "Desk",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
