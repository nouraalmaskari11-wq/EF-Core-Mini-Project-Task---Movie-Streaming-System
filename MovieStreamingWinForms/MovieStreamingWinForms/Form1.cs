using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MovieStreamingWinForms.Data;
using MovieStreamingWinForms.Models;
using BCrypt.Net;

namespace MovieStreamingWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCategories();
            LoadUsersForCombo();
            LoadMoviesForCombo();

            if (FormLogin.LoggedInUser != null)
            {
                this.Text = $"Movie Streaming System - Welcome {FormLogin.LoggedInUser.Name} ({FormLogin.LoggedInUser.Role})";
            }
        }

        // ==================== HELPER METHODS ====================

        private void LoadCategories()
        {
            using (var context = new ApplicationDbContext())
            {
                var categories = context.Categories.ToList();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";

                cmbFilterCategory.DataSource = categories.ToList();
                cmbFilterCategory.DisplayMember = "Name";
                cmbFilterCategory.ValueMember = "Id";
            }
        }

        private void LoadUsersForCombo()
        {
            using (var context = new ApplicationDbContext())
            {
                var users = context.Users.ToList();
                cmbUserForReview.DataSource = users.ToList();
                cmbUserForReview.DisplayMember = "Name";
                cmbUserForReview.ValueMember = "Id";

                cmbUserForWatchlist.DataSource = users.ToList();
                cmbUserForWatchlist.DisplayMember = "Name";
                cmbUserForWatchlist.ValueMember = "Id";
            }
        }

        private void LoadMoviesForCombo()
        {
            using (var context = new ApplicationDbContext())
            {
                var movies = context.Movies.ToList();
                cmbMovieForReview.DataSource = movies.ToList();
                cmbMovieForReview.DisplayMember = "Title";
                cmbMovieForReview.ValueMember = "Id";

                cmbMovieForWatchlist.DataSource = movies.ToList();
                cmbMovieForWatchlist.DisplayMember = "Title";
                cmbMovieForWatchlist.ValueMember = "Id";
            }
        }

        // ==================== MOVIES CRUD ====================

        private void LoadMovies()
        {
            using (var context = new ApplicationDbContext())
            {
                var movies = context.Movies.Include(m => m.Category).Select(m => new
                {
                    m.Id,
                    m.Title,
                    m.ReleaseYear,
                    Category = m.Category.Name,
                    m.CreatedAt
                }).ToList();

                dataGridViewMovies.DataSource = movies;
            }
        }

        private void btnLoadMovies_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMovieTitle.Text) || string.IsNullOrWhiteSpace(txtMovieYear.Text))
            {
                MessageBox.Show("Please enter title and year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var movie = new Movie
                    {
                        Title = txtMovieTitle.Text,
                        ReleaseYear = int.Parse(txtMovieYear.Text),
                        CategoryId = (int)cmbCategory.SelectedValue,
                        CreatedAt = DateTime.Now
                    };

                    context.Movies.Add(movie);
                    context.SaveChanges();

                    MessageBox.Show("Movie added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMovieTitle.Text = "";
                    txtMovieYear.Text = "";
                    LoadMovies();
                    LoadMoviesForCombo();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSoftDeleteMovie_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovies.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridViewMovies.CurrentRow.Cells["Id"].Value;

            using (var context = new ApplicationDbContext())
            {
                var movie = context.Movies.Find(id);
                if (movie != null)
                {
                    movie.IsDeleted = true;
                    context.SaveChanges();
                    MessageBox.Show("Movie soft deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMovies();
                    LoadMoviesForCombo();
                }
            }
        }

        // ==================== USERS CRUD ====================

        private void LoadUsers()
        {
            using (var context = new ApplicationDbContext())
            {
                var users = context.Users.Select(u => new
                {
                    u.Id,
                    u.Name,
                    u.Email,
                    u.Role,
                    u.CreatedAt
                }).ToList();

                dataGridViewUsers.DataSource = users;
            }
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserEmail.Text))
            {
                MessageBox.Show("Please enter name and email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var user = new User
                {
                    Name = txtUserName.Text,
                    Email = txtUserEmail.Text,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                    Role = "User",
                    CreatedAt = DateTime.Now
                };

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("User added successfully! Default password: 123456", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = "";
                txtUserEmail.Text = "";
                LoadUsers();
                LoadUsersForCombo();
            }
        }

        // ==================== REVIEWS CRUD ====================

        private void LoadReviews()
        {
            using (var context = new ApplicationDbContext())
            {
                var reviews = context.Reviews.Include(r => r.User).Include(r => r.Movie).Select(r => new
                {
                    r.Id,
                    User = r.User.Name,
                    Movie = r.Movie.Title,
                    r.Rating,
                    r.Comment,
                    r.CreatedAt
                }).ToList();

                dataGridViewReviews.DataSource = reviews;
            }
        }

        private void btnLoadReviews_Click(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (cmbUserForReview.SelectedValue == null || cmbMovieForReview.SelectedValue == null)
            {
                MessageBox.Show("Please select user and movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var review = new Review
                {
                    UserId = (int)cmbUserForReview.SelectedValue,
                    MovieId = (int)cmbMovieForReview.SelectedValue,
                    Comment = txtReviewComment.Text,
                    Rating = (int)numRating.Value,
                    CreatedAt = DateTime.Now
                };

                context.Reviews.Add(review);
                context.SaveChanges();

                MessageBox.Show("Review added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReviewComment.Text = "";
                numRating.Value = 1;
                LoadReviews();
            }
        }

        // ==================== WATCHLIST CRUD ====================

        private void LoadWatchlist()
        {
            using (var context = new ApplicationDbContext())
            {
                var watchlist = context.Watchlists.Include(w => w.User).Include(w => w.Movie).Select(w => new
                {
                    w.UserId,
                    User = w.User.Name,
                    w.MovieId,
                    Movie = w.Movie.Title,
                    w.AddedDate
                }).ToList();

                dataGridViewWatchlist.DataSource = watchlist;
            }
        }

        private void btnLoadWatchlist_Click(object sender, EventArgs e)
        {
            LoadWatchlist();
        }

        private void btnAddToWatchlist_Click(object sender, EventArgs e)
        {
            if (cmbUserForWatchlist.SelectedValue == null || cmbMovieForWatchlist.SelectedValue == null)
            {
                MessageBox.Show("Please select user and movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = (int)cmbUserForWatchlist.SelectedValue;
            int movieId = (int)cmbMovieForWatchlist.SelectedValue;

            using (var context = new ApplicationDbContext())
            {
                bool exists = context.Watchlists.Any(w => w.UserId == userId && w.MovieId == movieId);
                if (exists)
                {
                    MessageBox.Show("Movie already in user's watchlist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var watchlist = new Watchlist
                {
                    UserId = userId,
                    MovieId = movieId,
                    AddedDate = DateTime.Now
                };

                context.Watchlists.Add(watchlist);
                context.SaveChanges();

                MessageBox.Show("Movie added to watchlist!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWatchlist();
            }
        }

        private void btnRemoveFromWatchlist_Click(object sender, EventArgs e)
        {
            if (dataGridViewWatchlist.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = (int)dataGridViewWatchlist.CurrentRow.Cells["UserId"].Value;
            int movieId = (int)dataGridViewWatchlist.CurrentRow.Cells["MovieId"].Value;

            using (var context = new ApplicationDbContext())
            {
                var item = context.Watchlists.FirstOrDefault(w => w.UserId == userId && w.MovieId == movieId);
                if (item != null)
                {
                    context.Watchlists.Remove(item);
                    context.SaveChanges();
                    MessageBox.Show("Removed from watchlist!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadWatchlist();
                }
            }
        }

        // ==================== REPORTS ====================

        private void btnTopRated_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var topMovies = context.Reviews
                    .Where(r => !r.IsDeleted)
                    .GroupBy(r => r.MovieId)
                    .Select(g => new
                    {
                        Movie = g.First().Movie.Title,
                        AverageRating = g.Average(r => r.Rating),
                        ReviewCount = g.Count()
                    })
                    .OrderByDescending(x => x.AverageRating)
                    .Take(5)
                    .ToList();

                dataGridViewReports.DataSource = topMovies;
            }
        }

        private void btnFilterByCategory_Click(object sender, EventArgs e)
        {
            if (cmbFilterCategory.SelectedValue == null) return;

            int categoryId = (int)cmbFilterCategory.SelectedValue;

            using (var context = new ApplicationDbContext())
            {
                var movies = context.Movies
                    .Where(m => m.CategoryId == categoryId && !m.IsDeleted)
                    .Select(m => new
                    {
                        m.Id,
                        m.Title,
                        m.ReleaseYear,
                        Category = m.Category.Name
                    })
                    .ToList();

                dataGridViewReports.DataSource = movies;
            }
        }
    }
}