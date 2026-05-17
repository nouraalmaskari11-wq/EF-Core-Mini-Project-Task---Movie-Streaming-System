using System;
using System.Collections.Generic;

namespace MovieStreamingSystem.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int CategoryId { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        // Soft Delete
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public Category? Category { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Watchlist> Watchlists { get; set; } = new List<Watchlist>();
    }
}