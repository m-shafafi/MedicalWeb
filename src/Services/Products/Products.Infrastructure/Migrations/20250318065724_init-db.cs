using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LogoURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    Permalink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    BannerUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/500x100.png"),
                    IconUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/85.png"),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150x150.png"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 18, 6, 57, 23, 703, DateTimeKind.Utc).AddTicks(4560)),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 18, 6, 57, 23, 703, DateTimeKind.Utc).AddTicks(5106))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_category_category_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    StockQuantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Warranty = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_products_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 1, false, "Aliquip Lorem deserunt cupidatat deserunt sit qui excepteur. Ea aliquip eu irure et fugiat esse sit duis ad cillum mollit. Consectetur exercitation qui ea mollit enim ipsum excepteur. In velit aliqua adipisicing velit non in nisi commodo cupidatat Lorem voluptate labore. Enim cillum do ullamco proident ullamco ex Lorem consequat elit veniam sunt minim Lorem.\r\n", null, "Lancaster-Greene", 4, "Baird Moreno" },
                    { 2, false, "Adipisicing in aliquip duis excepteur laborum ullamco commodo duis consectetur elit labore sint. Eiusmod duis esse ex deserunt ipsum id adipisicing occaecat veniam proident ad. Occaecat officia enim eu laboris et in nulla nulla voluptate ad. Ullamco eiusmod reprehenderit amet ad enim. Sit Lorem cillum consectetur amet minim officia nulla. Ex ipsum Lorem consequat adipisicing.\r\n", null, "Bullock-Odonnell", 1, "Carr Simmons" },
                    { 3, false, "Reprehenderit nisi anim irure irure officia laborum incididunt anim. Laborum laborum adipisicing adipisicing incididunt velit labore dolor ut. Consectetur culpa ut nisi officia excepteur reprehenderit ad eu consequat voluptate sint.\r\n", null, "Walker-Rose", 3, "Barrera Hogan" },
                    { 4, false, "Ullamco est eiusmod sint laboris elit esse. Adipisicing minim dolore irure ut tempor culpa non consequat nostrud Lorem mollit aliquip. Aliquip nisi Lorem laborum nostrud eiusmod nisi anim officia eiusmod anim culpa. Qui elit cillum id eiusmod.\r\n", null, "Karyn-Mccullough", 2, "Carrillo Maddox" },
                    { 5, true, "Pariatur proident eu velit consectetur ullamco. Velit do esse magna esse proident incididunt laborum elit enim occaecat incididunt anim fugiat. Lorem deserunt adipisicing excepteur et. Dolor officia et in ex id fugiat. Culpa elit ullamco enim eu amet pariatur eiusmod do.\r\n", null, "Keith-Underwood", 1, "Mccray Hoover" },
                    { 6, true, "In culpa commodo Lorem reprehenderit consectetur consectetur. Esse elit exercitation enim non mollit ea deserunt nisi nostrud consequat labore duis proident. Fugiat sint mollit Lorem quis voluptate reprehenderit tempor ut velit elit amet. Deserunt veniam officia incididunt reprehenderit.\r\n", 1, "Kris-Schultz", 5, "Nelson Mckinney" },
                    { 7, true, "Dolor qui ad exercitation in anim proident aliquip consectetur. Eu eiusmod laboris proident reprehenderit reprehenderit anim exercitation dolore culpa occaecat eu nostrud eiusmod sunt. Occaecat deserunt ullamco occaecat non cillum tempor. Cupidatat sint ad ipsum elit ad mollit exercitation. Esse aliquip sunt proident laborum cillum esse nulla do mollit. Laborum est veniam veniam occaecat tempor laboris qui do elit incididunt. Nulla aliquip cupidatat ex voluptate eu id sint aliquip incididunt enim.\r\n", 2, "Mays-Dennis", 4, "Violet Clarke" },
                    { 8, true, "Deserunt nisi sint magna magna ad fugiat esse culpa ipsum cillum ullamco. Minim fugiat duis reprehenderit sint nisi exercitation qui cupidatat duis velit ut in cillum eiusmod. Ea aliquip sunt et qui ea ipsum aliqua minim ex ad culpa ea. Labore qui in tempor eu voluptate duis cupidatat aliqua do veniam dolore Lorem. Labore cupidatat Lorem sunt ad aliquip eiusmod non culpa pariatur ullamco do exercitation sunt minim.\r\n", 3, "Lewis-Avila", 2, "Krystal Johnson" },
                    { 9, false, "Magna aute adipisicing amet deserunt sint quis dolor mollit nisi officia qui reprehenderit duis occaecat. Consequat sit sit quis dolore sunt nulla cupidatat et tempor consectetur duis labore elit. Aute adipisicing ullamco incididunt fugiat esse aliqua elit velit. Culpa amet aute do velit anim pariatur. Pariatur ex quis ex dolor est qui. Non velit anim et laboris adipisicing nostrud proident do proident mollit elit minim. Occaecat mollit proident nostrud nisi irure ipsum amet incididunt dolore magna ex.\r\n", 4, "Kirk-Spence", 1, "Mack Ross" },
                    { 10, false, "Ullamco cupidatat tempor proident deserunt elit occaecat magna est aute. Aliqua excepteur aliquip anim dolore deserunt irure. Ullamco ex nulla ipsum mollit velit aliqua mollit. Deserunt enim quis tempor est esse pariatur aliquip nulla proident officia ullamco commodo. Fugiat qui ipsum officia non sint. Sit reprehenderit aute Lorem nisi quis aliquip culpa sunt cupidatat.\r\n", 9, "Dona-Soto", 1, "Patel Castaneda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_ParentCategoryId",
                table: "category",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_BrandId",
                table: "products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
