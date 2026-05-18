using Microsoft.EntityFrameworkCore;
using MovieStreamingWinForms.Models;
using BCrypt.Net;

namespace MovieStreamingWinForms.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MovieStreamingFinalDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Watchlist (Many-to-Many)
            modelBuilder.Entity<Watchlist>()
                .HasKey(w => new { w.UserId, w.MovieId });

            modelBuilder.Entity<Watchlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.Watchlists)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Watchlist>()
                .HasOne(w => w.Movie)
                .WithMany(m => m.Watchlists)
                .HasForeignKey(w => w.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            // Review Relationships
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            // Movie Relationships
            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Category)
                .WithMany(c => c.Movies)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Soft Delete Global Filters
            modelBuilder.Entity<Movie>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Review>().HasQueryFilter(r => !r.IsDeleted);

            // ========== SEED DATA ==========
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action" },
                new Category { Id = 2, Name = "Comedy" },
                new Category { Id = 3, Name = "Drama" },
                new Category { Id = 4, Name = "Horror" },
                new Category { Id = 5, Name = "Sci-Fi" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Admin", Email = "admin@example.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"), Role = "Admin", CreatedAt = DateTime.Now },
                new User { Id = 2, Name = "Ahmed Mansour", Email = "ahmed@example.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("ahmed123"), Role = "User", CreatedAt = DateTime.Now },
                new User { Id = 3, Name = "Sara Khalid", Email = "sara@example.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("sara123"), Role = "User", CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Description = "Dream within dreams", ReleaseYear = 2010, CategoryId = 5, CreatedAt = DateTime.Now, IsDeleted = false },
                new Movie { Id = 2, Title = "The Hangover", Description = "Wild bachelor party", ReleaseYear = 2009, CategoryId = 2, CreatedAt = DateTime.Now, IsDeleted = false },
                new Movie { Id = 3, Title = "The Dark Knight", Description = "Batman vs Joker", ReleaseYear = 2008, CategoryId = 1, CreatedAt = DateTime.Now, IsDeleted = false },
                new Movie { Id = 4, Title = "Interstellar", Description = "Space travel", ReleaseYear = 2014, CategoryId = 5, CreatedAt = DateTime.Now, IsDeleted = false },
                new Movie { Id = 5, Title = "Superbad", Description = "High school graduates", ReleaseYear = 2007, CategoryId = 2, CreatedAt = DateTime.Now, IsDeleted = false }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, Comment = "Mind-blowing movie!", Rating = 5, UserId = 2, MovieId = 1, CreatedAt = DateTime.Now, IsDeleted = false },
                new Review { Id = 2, Comment = "Confusing but great", Rating = 4, UserId = 3, MovieId = 1, CreatedAt = DateTime.Now, IsDeleted = false },
                new Review { Id = 3, Comment = "Hilarious! Loved it", Rating = 5, UserId = 2, MovieId = 2, CreatedAt = DateTime.Now, IsDeleted = false },
                new Review { Id = 4, Comment = "Best Batman ever", Rating = 5, UserId = 3, MovieId = 3, CreatedAt = DateTime.Now, IsDeleted = false }
            );

            modelBuilder.Entity<Watchlist>().HasData(
                new Watchlist { UserId = 2, MovieId = 2, AddedDate = DateTime.Now },
                new Watchlist { UserId = 2, MovieId = 4, AddedDate = DateTime.Now },
                new Watchlist { UserId = 3, MovieId = 1, AddedDate = DateTime.Now },
                new Watchlist { UserId = 3, MovieId = 3, AddedDate = DateTime.Now }
            );
        }
    }
}