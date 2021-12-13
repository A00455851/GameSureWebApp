using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameSureWebApp.Migrations
{
    public partial class addedDBSetinContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PayId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ptype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProdId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TxnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TxnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TxnStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethodPayId = table.Column<int>(type: "int", nullable: true),
                    GameSureWebAppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TxnId);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_GameSureWebAppUserId",
                        column: x => x.GameSureWebAppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Payments_PaymentMethodPayId",
                        column: x => x.PaymentMethodPayId,
                        principalTable: "Payments",
                        principalColumn: "PayId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionDets",
                columns: table => new
                {
                    TxnDetNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EquipmentDet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    ProductProdId = table.Column<int>(type: "int", nullable: true),
                    TransactionTxnId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDets", x => x.TxnDetNo);
                    table.ForeignKey(
                        name: "FK_TransactionDets_Products_ProductProdId",
                        column: x => x.ProductProdId,
                        principalTable: "Products",
                        principalColumn: "ProdId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionDets_Transactions_TransactionTxnId",
                        column: x => x.TransactionTxnId,
                        principalTable: "Transactions",
                        principalColumn: "TxnId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDets_ProductProdId",
                table: "TransactionDets",
                column: "ProductProdId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDets_TransactionTxnId",
                table: "TransactionDets",
                column: "TransactionTxnId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_GameSureWebAppUserId",
                table: "Transactions",
                column: "GameSureWebAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentMethodPayId",
                table: "Transactions",
                column: "PaymentMethodPayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionDets");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
