using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon.Context.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardItems_Cards_CardID",
                table: "CardItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CardItems_Products_ProductID",
                table: "CardItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Admins_AdminID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UsertID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_AdminID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UsertID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "OrderDetails",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameColumn(
                name: "AdminID",
                table: "Categories",
                newName: "AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_AdminID",
                table: "Categories",
                newName: "IX_Categories_AdminId");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "CardItems",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "CardID",
                table: "CardItems",
                newName: "cardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardItems_ProductID",
                table: "CardItems",
                newName: "IX_CardItems_productId");

            migrationBuilder.RenameIndex(
                name: "IX_CardItems_CardID",
                table: "CardItems",
                newName: "IX_CardItems_cardId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Admins",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardItems_Cards_cardId",
                table: "CardItems",
                column: "cardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardItems_Products_productId",
                table: "CardItems",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Admins_AdminId",
                table: "Categories",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_AdminID",
                table: "Products",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardItems_Cards_cardId",
                table: "CardItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CardItems_Products_productId",
                table: "CardItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Admins_AdminId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_AdminID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderDetails",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductID");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Categories",
                newName: "AdminID");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_AdminId",
                table: "Categories",
                newName: "IX_Categories_AdminID");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "CardItems",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "cardId",
                table: "CardItems",
                newName: "CardID");

            migrationBuilder.RenameIndex(
                name: "IX_CardItems_productId",
                table: "CardItems",
                newName: "IX_CardItems_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_CardItems_cardId",
                table: "CardItems",
                newName: "IX_CardItems_CardID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Admins",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsertID",
                table: "Orders",
                column: "UsertID");

            migrationBuilder.AddForeignKey(
                name: "FK_CardItems_Cards_CardID",
                table: "CardItems",
                column: "CardID",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardItems_Products_ProductID",
                table: "CardItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Admins_AdminID",
                table: "Categories",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UsertID",
                table: "Orders",
                column: "UsertID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_AdminID",
                table: "Products",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
