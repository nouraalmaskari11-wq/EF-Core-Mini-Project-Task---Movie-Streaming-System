using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Data;
using MovieStreamingSystem.Models;

namespace MovieStreamingSystem.Services
{
    public class ReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }

        // ========== CREATE ==========
        public void AddReview(int userId, int movieId, string comment, int rating)
        {
            // Validate rating
            if (rating < 1 || rating > 5)
            {
                Console.WriteLine("Rating must be between 1 and 5");
                return;
            }

            var review = new Review
            {
                UserId = userId,
                MovieId = movieId,
                Comment = comment,
                Rating = rating,
                CreatedAt = DateTime.Now
            };
            _context.Reviews.Add(review);
            _context.SaveChanges();
            Console.WriteLine($"⭐ Review added for Movie ID {movieId} by User ID {userId}");
        }

        // ========== READ (Reviews per Movie) ==========
        public void GetReviewsPerMovie(int movieId)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == movieId);
            if (movie == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            var reviews = _context.Reviews
                .Where(r => r.MovieId == movieId && !r.IsDeleted)
                .Include(r => r.User)
                .ToList();

            Console.WriteLine($"\nReviews for '{movie.Title}':");
            if (!reviews.Any())
            {
                Console.WriteLine("   No reviews yet");
            }
            else
            {
                foreach (var r in reviews)
                {
                    Console.WriteLine($"   ⭐ {r.Rating}/5 - {r.Comment} (by {r.User?.Name}, {r.CreatedAt.ToShortDateString()})");
                }
            }
        }

        // ========== UPDATE ==========
        public void UpdateReview(int reviewId, string newComment, int newRating)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.Id == reviewId);
            if (review == null)
            {
                Console.WriteLine("Review not found");
                return;
            }

            review.Comment = newComment;
            review.Rating = newRating;
            review.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            Console.WriteLine($"Review updated");
        }

        // ========== SOFT DELETE ==========
        public void SoftDeleteReview(int reviewId)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.Id == reviewId);
            if (review != null)
            {
                review.IsDeleted = true;
                _context.SaveChanges();
                Console.WriteLine($"Review soft deleted");
            }
        }
    }
}