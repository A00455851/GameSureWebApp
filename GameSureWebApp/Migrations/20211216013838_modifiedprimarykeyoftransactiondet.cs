using Microsoft.EntityFrameworkCore.Migrations;

namespace GameSureWebApp.Migrations
{
    public partial class modifiedprimarykeyoftransactiondet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionDets",
                table: "TransactionDets");

            migrationBuilder.DropColumn(
                name: "TxnDetNo",
                table: "TransactionDets");

            migrationBuilder.AddColumn<int>(
                name: "TxnDetId",
                table: "TransactionDets",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionDets",
                table: "TransactionDets",
                column: "TxnDetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionDets",
                table: "TransactionDets");

            migrationBuilder.DropColumn(
                name: "TxnDetId",
                table: "TransactionDets");

            migrationBuilder.AddColumn<string>(
                name: "TxnDetNo",
                table: "TransactionDets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionDets",
                table: "TransactionDets",
                column: "TxnDetNo");
        }
    }
}
