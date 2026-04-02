using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G8.PosDemo.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderSummary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderSummary",
                table: "Orders",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderSummary",
                table: "Orders");
        }
    }
}
