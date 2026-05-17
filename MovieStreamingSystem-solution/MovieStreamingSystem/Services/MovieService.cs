using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Data;
using MovieStreamingSystem.Models;

namespace MovieStreamingSystem.Services
{
    public class MovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        // ========== CREATE ==========
        public void AddMovie(string title, string description, int releaseYear, int categoryId)
        {
            var movie = new Movie
            {
                Title = title,
                Description = description,
                ReleaseYear = releaseYear,
                CategoryId = categoryId,
                CreatedAt = DateTime.Now
            };
            _context.Movies.Add(movie);
            _context.SaveChanges();
            Console.WriteLine($"Movie added: {title}");
        }

        // ========== READ (All) ==========
        public List<Movie> GetAllMovies()
        {
            return _context.Movies.Include(m => m.Category).ToList();
        }

        public void DisplayAllMovies()
        {
            var movies = GetAllMovies();
            Console.WriteLine("\nAll Movies:");
            foreach (var m in movies)
            {
                Console.WriteLine($"ID: {m.Id} | {m.Title} ({m.ReleaseYear}) | Category: {m.Category?.Name}");
            }
        }

        // ========== READ (By ID) ==========
        public Movie GetMovieById(int id)
        {
            return _context.Movies.Include(m => m.Category).FirstOrDefault(m => m.Id == id);
        }

        // ========== UPDATE ==========
        public void UpdateMovie(int id, string newTitle, string newDescription, int? newReleaseYear = null, int? newCategoryId = null)
        {
            var movie = GetMovieById(id);
            if (movie == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            movie.Title = newTitle;
            movie.Description = newDescription;
            if (newReleaseYear.HasValue)
                movie.ReleaseYear = newReleaseYear.Value;
            if (newCategoryId.HasValue)
                movie.CategoryId = newCategoryId.Value;
            movie.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
            Console.WriteLine($"Movie updated: {movie.Title}");
        }

        // ========== SOFT DELETE ==========
        public void SoftDeleteMovie(int id)
        {
            var movie = GetMovieById(id);
            if (movie != null)
            {
                movie.IsDeleted = true;
                _context.SaveChanges();
                Console.WriteLine($"Movie '{movie.Title}' soft deleted");
            }
        }

        // ========== HARD DELETE (Permanent) ==========
        public void HardDeleteMovie(int id)
        {
            var movie = _context.Movies.IgnoreQueryFilters().FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
                Console.WriteLine($"Movie permanently deleted");
            }
        }

        // ========== BONUS: Top Rated Movies ==========
        public void GetTopRatedMovies(int topCount = 3)
        {
            var topMovies = _context.Reviews
                .Where(r => !r.IsDeleted)
                .GroupBy(r => r.MovieId)
                .Select(g => new
                {
                    MovieId = g.Key,
                    AvgRating = g.Average(r => r.Rating),
                    ReviewCount = g.Count()
                })
                .OrderByDescending(x => x.AvgRating)
                .Take(topCount)
                .Join(_context.Movies, x => x.MovieId, m => m.Id, (x, m) => new { m.Title, x.AvgRating, x.ReviewCount })
                .ToList();

            Console.WriteLine($"\nTop {topCount} Rated Movies:");
            foreach (var m in topMovies)
            {
                Console.WriteLine($"⭐ {m.Title} - Avg Rating: {m.AvgRating:F2} ({m.ReviewCount} reviews)");
            }
        }

        // ========== BONUS: Filter by Category ==========
        public void FilterMoviesByCategory(string categoryName)
        {
            var movies = _context.Movies
                .Where(m => m.Category.Name.ToLower() == categoryName.ToLower())
                .ToList();

            Console.WriteLine($"\nMovies in Category '{categoryName}':");
            foreach (var m in movies)
            {
                Console.WriteLine($"- {m.Title} ({m.ReleaseYear})");
            }
        }
    }
}