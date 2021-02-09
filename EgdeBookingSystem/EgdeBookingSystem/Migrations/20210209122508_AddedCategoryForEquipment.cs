using Microsoft.EntityFrameworkCore.Migrations;

namespace EgdeBookingSystem.Migrations
{
    public partial class AddedCategoryForEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Equipment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CategoryID",
                table: "Equipment",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Category_CategoryID",
                table: "Equipment",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Category_CategoryID",
                table: "Equipment");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_CategoryID",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Equipment");
        }
    }
}
