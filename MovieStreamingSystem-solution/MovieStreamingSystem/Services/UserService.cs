using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Data;
using MovieStreamingSystem.Models;

namespace MovieStreamingSystem.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        // ========== CREATE ==========
        public User CreateUser(string name, string email)
        {
            var user = new User
            {
                Name = name,
                Email = email,
                CreatedAt = DateTime.Now
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            Console.WriteLine($"User created: {name} (ID: {user.Id})");
            return user;
        }

        // ========== READ (All) ==========
        public void DisplayAllUsers()
        {
            var users = _context.Users.ToList();
            Console.WriteLine("\nAll Users:");
            foreach (var u in users)
            {
                Console.WriteLine($"ID: {u.Id} | {u.Name} | {u.Email}");
            }
        }

        // ========== READ (User with Watchlist) ==========
        public void GetUserWithWatchlist(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine($"\nUser: {user.Name} ({user.Email})");
            Console.WriteLine("Watchlist:");

            var watchlist = _context.Watchlists
                .Where(w => w.UserId == userId)
                .Include(w => w.Movie)
                .ToList();

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