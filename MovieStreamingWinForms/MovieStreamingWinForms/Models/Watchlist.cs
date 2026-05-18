using System;

namespace MovieStreamingWinForms.Models
{
    public class Watchlist
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;

        public User? User { get; set; }
        public Movie? Movie { get; set; }
    }
}