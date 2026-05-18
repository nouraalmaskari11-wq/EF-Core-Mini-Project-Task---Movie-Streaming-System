using System;

namespace MovieStreamingWinForms.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        public User? User { get; set; }
        public Movie? Movie { get; set; }
    }
}