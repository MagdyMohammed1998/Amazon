using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon.Context.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Admins_Admin_Id",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Admin_Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Admin_Id",
                table: "Orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Admin_Id",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Admin_Id",
                table: "Orders",
                column: "Admin_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Admins_Admin_Id",
                table: "Orders",
                column: "Admin_Id",
                principalTable: "Admins",
                principalColumn: "Id");
        }
    }
}
