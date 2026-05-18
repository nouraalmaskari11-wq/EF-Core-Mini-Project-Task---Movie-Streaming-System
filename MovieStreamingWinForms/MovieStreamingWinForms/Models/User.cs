using System;
using System.Collections.Generic;

namespace MovieStreamingWinForms.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? Role { get; set; } = "User";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public List<Review>? Reviews { get; set; } = new List<Review>();
        public List<Watchlist>? Watchlists { get; set; } = new List<Watchlist>();
    }
}