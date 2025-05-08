using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentForeignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_SelleR_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_SelleR_Department_DepartmentId",
                table: "SelleR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SelleR",
                table: "SelleR");

            migrationBuilder.RenameTable(
                name: "SelleR",
                newName: "Seller");

            migrationBuilder.RenameIndex(
                name: "IX_SelleR_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seller",
                table: "Seller",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seller",
                table: "Seller");

            migrationBuilder.RenameTable(
                name: "Seller",
                newName: "SelleR");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "SelleR",
                newName: "IX_SelleR_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SelleR",
                table: "SelleR",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_SelleR_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "SelleR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SelleR_Department_DepartmentId",
                table: "SelleR",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
