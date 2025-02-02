using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCategoryApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "products",
                newName: "productName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "productId");

            migrationBuilder.AddColumn<string>(
                name: "categoryId",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "productName",
                table: "products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "products",
                newName: "Id");
        }
    }
}
