using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieStreamingWinForms.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Watchlists",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watchlists", x => new { x.UserId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_Watchlists_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Watchlists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Drama" },
                    { 4, "Horror" },
                    { 5, "Sci-Fi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "PasswordHash", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 18, 9, 52, 2, 653, DateTimeKind.Local).AddTicks(4688), "admin@example.com", "Admin", "$2a$11$Uzqm.NB39O/QbQ2nZEFbe.t34C6J5Ws/9wDkN9rxi9wejBYENkyly", "Admin", null },
                    { 2, new DateTime(2026, 5, 18, 9, 52, 2, 760, DateTimeKind.Local).AddTicks(7933), "ahmed@example.com", "Ahmed Mansour", "$2a$11$31ErVezRDwNc0Z7/iQnGcuDYzlaCZIgC8Xfy34Hg1X9tY0ri.vDmy", "User", null },
                    { 3, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(2432), "sara@example.com", "Sara Khalid", "$2a$11$XPtbaXHUG8mC92IX8s0mse29G4YM2e3RRawj5CJRUmUyg.wXqu.Qy", "User", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "IsDeleted", "ReleaseYear", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(2949), "Dream within dreams", false, 2010, "Inception", null },
                    { 2, 2, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(2951), "Wild bachelor party", false, 2009, "The Hangover", null },
                    { 3, 1, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(2953), "Batman vs Joker", false, 2008, "The Dark Knight", null },
                    { 4, 5, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(2955), "Space travel", false, 2014, "Interstellar", null },
                    { 5, 2, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(2956), "High school graduates", false, 2007, "Superbad", null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "IsDeleted", "MovieId", "Rating", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Mind-blowing movie!", new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3025), false, 1, 5, null, 2 },
                    { 2, "Confusing but great", new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3027), false, 1, 4, null, 3 },
                    { 3, "Hilarious! Loved it", new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3028), false, 2, 5, null, 2 },
                    { 4, "Best Batman ever", new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3030), false, 3, 5, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Watchlists",
                columns: new[] { "MovieId", "UserId", "AddedDate" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3069) },
                    { 4, 2, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3070) },
                    { 1, 3, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3072) },
                    { 3, 3, new DateTime(2026, 5, 18, 9, 52, 2, 868, DateTimeKind.Local).AddTicks(3073) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieId",
                table: "Reviews",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchlists_MovieId",
                table: "Watchlists",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Watchlists");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
