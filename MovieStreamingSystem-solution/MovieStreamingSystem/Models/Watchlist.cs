using System;

namespace MovieStreamingSystem.Models
{
    public class Watchlist
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;

        // Navigation Properties (Optional - marked with ?)
        public User? User { get; set; }
        public Movie? Movie { get; set; }
    }
}