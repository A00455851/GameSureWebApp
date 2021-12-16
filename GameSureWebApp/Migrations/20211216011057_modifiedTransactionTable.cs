using Microsoft.EntityFrameworkCore.Migrations;

namespace GameSureWebApp.Migrations
{
    public partial class modifiedTransactionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDets_Products_ProductProdId",
                table: "TransactionDets");

            migrationBuilder.DropIndex(
                name: "IX_TransactionDets_ProductProdId",
                table: "TransactionDets");

            migrationBuilder.DropColumn(
                name: "ProductProdId",
                table: "TransactionDets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductProdId",
                table: "TransactionDets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDets_ProductProdId",
                table: "TransactionDets",
                column: "ProductProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDets_Products_ProductProdId",
                table: "TransactionDets",
                column: "ProductProdId",
                principalTable: "Products",
                principalColumn: "ProdId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
