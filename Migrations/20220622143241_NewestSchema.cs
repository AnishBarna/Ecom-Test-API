using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.Migrations
{
    public partial class NewestSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Transactions_TransactionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TransactionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTransaction",
                columns: table => new
                {
                    ProductsProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionsTransactionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTransaction", x => new { x.ProductsProductId, x.TransactionsTransactionId });
                    table.ForeignKey(
                        name: "FK_ProductTransaction_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTransaction_Transactions_TransactionsTransactionId",
                        column: x => x.TransactionsTransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransaction_TransactionsTransactionId",
                table: "ProductTransaction",
                column: "TransactionsTransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTransaction");

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_TransactionId",
                table: "Products",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Transactions_TransactionId",
                table: "Products",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "TransactionId");
        }
    }
}
