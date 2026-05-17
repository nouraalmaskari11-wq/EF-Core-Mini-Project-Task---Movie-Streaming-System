using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Data;
using MovieStreamingSystem.Models;

namespace MovieStreamingSystem.Services
{
    public class WatchlistService
    {
        private readonly ApplicationDbContext _context;

        public WatchlistService(ApplicationDbContext context)
        {
            _context = context;
        }

        // ========== CREATE (with duplicate prevention) ==========
        public void AddMovieToWatchlist(int userId, int movieId)
        {
            // Check if user exists
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            // Check if movie exists
            var movie = _context.Movies.FirstOrDefault(m => m.Id == movieId);
            if (movie == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            // BONUS: Prevent duplicate movies in Watchlist
            bool exists = _context.Watchlists.Any(w => w.UserId == userId && w.MovieId == movieId);
            if (exists)
            {
                Console.WriteLine($"'{movie.Title}' is already in {user.Name}'s watchlist");
                return;
            }

            var watchlist = new Watchlist
            {
                UserId = userId,
                MovieId = movieId,
                AddedDate = DateTime.Now
            };
            _context.Watchlists.Add(watchlist);
            _context.SaveChanges();
            Console.WriteLine($"'{movie.Title}' added to {user.Name}'s watchlist");
        }

        // ========== DELETE ==========
        public void RemoveFromWatchlist(int userId, int movieId)
        {
            var item = _context.Watchlists.FirstOrDefault(w => w.UserId == userId && w.MovieId == movieId);
            if (item == null)
            {
                Console.WriteLine("Movie not found in watchlist");
                return;
            }

            var movie = _context.Movies.Find(movieId);
            _context.Watchlists.Remove(item);
            _context.SaveChanges();
            Console.WriteLine($"'{movie?.Title}' removed from watchlist");
        }

        // ========== READ (User Watchlist) ==========
        public void DisplayUserWatchlist(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            var watchlist = _context.Watchlists
                .Where(w => w.UserId == userId)
                .Include(w => w.Movie)
                .ToList();

            Console.WriteLine($"\n{user.Name}'s Watchlist:");
            if (!watchlist.Any())
            {
                Console.WriteLine("   (empty)");
            }
            else
            {
                foreach (var w in watchlist)
                {
                    Console.WriteLine($"   - {w.Movie?.Title} (Added: {w.AddedDate.ToShortDateString()})");
                }
            }
        }
    }
}