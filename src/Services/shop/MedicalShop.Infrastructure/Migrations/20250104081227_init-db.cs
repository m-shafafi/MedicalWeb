using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MedicalShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Bio = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    ProfilePictureURL = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    LogoURL = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ParentCategoryID = table.Column<int>(type: "integer", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "categoryMenus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryMenus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "mainMenus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainMenus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "newsCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    ParentCategoryID = table.Column<int>(type: "integer", nullable: false),
                    Slug = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    BrandID = table.Column<int>(type: "integer", nullable: false),
                    StockQuantity = table.Column<string>(type: "text", nullable: false),
                    SKU = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImageURL = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Warranty = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Rating = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    CategoryID = table.Column<int>(type: "integer", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_products_brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "brands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "newsArticles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Summary = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Content = table.Column<string>(type: "text", nullable: false),
                    AuthorID = table.Column<int>(type: "integer", nullable: false),
                    CategoryID = table.Column<int>(type: "integer", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Tags = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ImageURL = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    ViewsCount = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsArticles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_newsArticles_authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_newsArticles_newsCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "newsCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NewsArticleID = table.Column<string>(type: "text", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    PostedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ArticleID = table.Column<int>(type: "integer", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MOdificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_comments_newsArticles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "newsArticles",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_ArticleID",
                table: "comments",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_newsArticles_AuthorID",
                table: "newsArticles",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_newsArticles_CategoryID",
                table: "newsArticles",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_products_BrandID",
                table: "products",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryID",
                table: "products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categoryMenus");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "mainMenus");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "newsArticles");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "newsCategories");
        }
    }
}
