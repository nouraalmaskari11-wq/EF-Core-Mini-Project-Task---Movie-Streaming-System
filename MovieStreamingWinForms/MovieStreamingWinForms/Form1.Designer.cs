namespace MovieStreamingWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ==================== MAIN TAB CONTROL ====================
            tabControl1 = new TabControl();
            tabMovies = new TabPage();
            tabUsers = new TabPage();
            tabReviews = new TabPage();
            tabWatchlist = new TabPage();
            tabReports = new TabPage();

            // ==================== MOVIES TAB ====================
            dataGridViewMovies = new DataGridView();
            btnLoadMovies = new Button();
            btnAddMovie = new Button();
            btnSoftDeleteMovie = new Button();
            txtMovieTitle = new TextBox();
            txtMovieYear = new TextBox();
            cmbCategory = new ComboBox();
            lblMovieTitle = new Label();
            lblMovieYear = new Label();
            lblCategory = new Label();
            panelMovieInput = new Panel();

            // ==================== USERS TAB ====================
            dataGridViewUsers = new DataGridView();
            btnLoadUsers = new Button();
            btnAddUser = new Button();
            txtUserName = new TextBox();
            txtUserEmail = new TextBox();
            lblUserName = new Label();
            lblUserEmail = new Label();
            panelUserInput = new Panel();

            // ==================== REVIEWS TAB ====================
            dataGridViewReviews = new DataGridView();
            btnLoadReviews = new Button();
            btnAddReview = new Button();
            cmbMovieForReview = new ComboBox();
            cmbUserForReview = new ComboBox();
            txtReviewComment = new TextBox();
            numRating = new NumericUpDown();
            lblReviewMovie = new Label();
            lblReviewUser = new Label();
            lblReviewComment = new Label();
            lblReviewRating = new Label();
            panelReviewInput = new Panel();

            // ==================== WATCHLIST TAB ====================
            dataGridViewWatchlist = new DataGridView();
            btnLoadWatchlist = new Button();
            btnAddToWatchlist = new Button();
            btnRemoveFromWatchlist = new Button();
            cmbUserForWatchlist = new ComboBox();
            cmbMovieForWatchlist = new ComboBox();
            lblWatchlistUser = new Label();
            lblWatchlistMovie = new Label();
            panelWatchlistInput = new Panel();

            // ==================== REPORTS TAB ====================
            dataGridViewReports = new DataGridView();
            btnTopRated = new Button();
            btnFilterByCategory = new Button();
            cmbFilterCategory = new ComboBox();
            lblFilterCategory = new Label();
            panelReportsInput = new Panel();

            // ==================== TAB CONTROL SETUP ====================
            tabControl1.Controls.Add(tabMovies);
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Controls.Add(tabReviews);
            tabControl1.Controls.Add(tabWatchlist);
            tabControl1.Controls.Add(tabReports);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(950, 650);
            tabControl1.TabIndex = 0;

            // ==================== MOVIES TAB ====================
            tabMovies.Text = " Movies ";
            tabMovies.BackColor = Color.FromArgb(25, 25, 35);
            tabMovies.Controls.Add(dataGridViewMovies);
            tabMovies.Controls.Add(panelMovieInput);
            tabMovies.Controls.Add(btnLoadMovies);
            tabMovies.Controls.Add(btnAddMovie);
            tabMovies.Controls.Add(btnSoftDeleteMovie);

            // DataGridView Movies
            dataGridViewMovies.Location = new Point(20, 20);
            dataGridViewMovies.Size = new Size(580, 300);
            dataGridViewMovies.BackgroundColor = Color.FromArgb(30, 30, 40);
            dataGridViewMovies.ForeColor = Color.White;
            dataGridViewMovies.GridColor = Color.FromArgb(60, 60, 70);
            dataGridViewMovies.BorderStyle = BorderStyle.None;
            dataGridViewMovies.EnableHeadersVisualStyles = false;
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewMovies.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewMovies.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewMovies.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewMovies.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewMovies.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewMovies.RowHeadersVisible = false;

            // Panel Movie Input
            panelMovieInput.BackColor = Color.FromArgb(45, 45, 55);
            panelMovieInput.BorderStyle = BorderStyle.FixedSingle;
            panelMovieInput.Location = new Point(20, 340);
            panelMovieInput.Size = new Size(580, 130);
            panelMovieInput.Controls.Add(lblMovieTitle);
            panelMovieInput.Controls.Add(txtMovieTitle);
            panelMovieInput.Controls.Add(lblMovieYear);
            panelMovieInput.Controls.Add(txtMovieYear);
            panelMovieInput.Controls.Add(lblCategory);
            panelMovieInput.Controls.Add(cmbCategory);

            // Labels and TextBoxes
            lblMovieTitle.Text = "Title:";
            lblMovieTitle.ForeColor = Color.White;
            lblMovieTitle.Location = new Point(20, 20);
            lblMovieTitle.Size = new Size(60, 25);

            txtMovieTitle.Location = new Point(80, 18);
            txtMovieTitle.Size = new Size(180, 27);
            txtMovieTitle.BackColor = Color.FromArgb(60, 60, 70);
            txtMovieTitle.ForeColor = Color.White;
            txtMovieTitle.BorderStyle = BorderStyle.FixedSingle;

            lblMovieYear.Text = "Year:";
            lblMovieYear.ForeColor = Color.White;
            lblMovieYear.Location = new Point(280, 20);
            lblMovieYear.Size = new Size(60, 25);

            txtMovieYear.Location = new Point(330, 18);
            txtMovieYear.Size = new Size(100, 27);
            txtMovieYear.BackColor = Color.FromArgb(60, 60, 70);
            txtMovieYear.ForeColor = Color.White;
            txtMovieYear.BorderStyle = BorderStyle.FixedSingle;

            lblCategory.Text = "Category:";
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(20, 60);
            lblCategory.Size = new Size(80, 25);

            cmbCategory.Location = new Point(100, 58);
            cmbCategory.Size = new Size(150, 27);
            cmbCategory.BackColor = Color.FromArgb(60, 60, 70);
            cmbCategory.ForeColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;

            // Buttons
            btnLoadMovies.Text = "Load Movies";
            btnLoadMovies.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadMovies.ForeColor = Color.White;
            btnLoadMovies.FlatStyle = FlatStyle.Flat;
            btnLoadMovies.FlatAppearance.BorderSize = 0;
            btnLoadMovies.Location = new Point(630, 30);
            btnLoadMovies.Size = new Size(140, 40);
            btnLoadMovies.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLoadMovies.Click += btnLoadMovies_Click;

            btnAddMovie.Text = "Add Movie";
            btnAddMovie.BackColor = Color.FromArgb(40, 167, 69);
            btnAddMovie.ForeColor = Color.White;
            btnAddMovie.FlatStyle = FlatStyle.Flat;
            btnAddMovie.FlatAppearance.BorderSize = 0;
            btnAddMovie.Location = new Point(630, 90);
            btnAddMovie.Size = new Size(140, 40);
            btnAddMovie.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAddMovie.Click += btnAddMovie_Click;

            btnSoftDeleteMovie.Text = "Soft Delete";
            btnSoftDeleteMovie.BackColor = Color.FromArgb(220, 53, 69);
            btnSoftDeleteMovie.ForeColor = Color.White;
            btnSoftDeleteMovie.FlatStyle = FlatStyle.Flat;
            btnSoftDeleteMovie.FlatAppearance.BorderSize = 0;
            btnSoftDeleteMovie.Location = new Point(630, 150);
            btnSoftDeleteMovie.Size = new Size(140, 40);
            btnSoftDeleteMovie.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSoftDeleteMovie.Click += btnSoftDeleteMovie_Click;

            // ==================== USERS TAB ====================
            tabUsers.Text = " Users ";
            tabUsers.BackColor = Color.FromArgb(25, 25, 35);
            tabUsers.Controls.Add(dataGridViewUsers);
            tabUsers.Controls.Add(panelUserInput);
            tabUsers.Controls.Add(btnLoadUsers);
            tabUsers.Controls.Add(btnAddUser);

            dataGridViewUsers.Location = new Point(20, 20);
            dataGridViewUsers.Size = new Size(580, 300);
            dataGridViewUsers.BackgroundColor = Color.FromArgb(30, 30, 40);
            dataGridViewUsers.ForeColor = Color.White;
            dataGridViewUsers.GridColor = Color.FromArgb(60, 60, 70);
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewUsers.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewUsers.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewUsers.RowHeadersVisible = false;

            panelUserInput.BackColor = Color.FromArgb(45, 45, 55);
            panelUserInput.BorderStyle = BorderStyle.FixedSingle;
            panelUserInput.Location = new Point(20, 340);
            panelUserInput.Size = new Size(580, 100);
            panelUserInput.Controls.Add(lblUserName);
            panelUserInput.Controls.Add(txtUserName);
            panelUserInput.Controls.Add(lblUserEmail);
            panelUserInput.Controls.Add(txtUserEmail);

            lblUserName.Text = "Name:";
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(20, 20);
            lblUserName.Size = new Size(60, 25);

            txtUserName.Location = new Point(80, 18);
            txtUserName.Size = new Size(200, 27);
            txtUserName.BackColor = Color.FromArgb(60, 60, 70);
            txtUserName.ForeColor = Color.White;

            lblUserEmail.Text = "Email:";
            lblUserEmail.ForeColor = Color.White;
            lblUserEmail.Location = new Point(20, 55);
            lblUserEmail.Size = new Size(60, 25);

            txtUserEmail.Location = new Point(80, 53);
            txtUserEmail.Size = new Size(250, 27);
            txtUserEmail.BackColor = Color.FromArgb(60, 60, 70);
            txtUserEmail.ForeColor = Color.White;

            btnLoadUsers.Text = "Load Users";
            btnLoadUsers.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadUsers.ForeColor = Color.White;
            btnLoadUsers.FlatStyle = FlatStyle.Flat;
            btnLoadUsers.Location = new Point(630, 30);
            btnLoadUsers.Size = new Size(140, 40);
            btnLoadUsers.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLoadUsers.Click += btnLoadUsers_Click;

            btnAddUser.Text = "Add User";
            btnAddUser.BackColor = Color.FromArgb(40, 167, 69);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(630, 90);
            btnAddUser.Size = new Size(140, 40);
            btnAddUser.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAddUser.Click += btnAddUser_Click;

            // ==================== REVIEWS TAB ====================
            tabReviews.Text = " Reviews ";
            tabReviews.BackColor = Color.FromArgb(25, 25, 35);
            tabReviews.Controls.Add(dataGridViewReviews);
            tabReviews.Controls.Add(panelReviewInput);
            tabReviews.Controls.Add(btnLoadReviews);
            tabReviews.Controls.Add(btnAddReview);

            dataGridViewReviews.Location = new Point(20, 20);
            dataGridViewReviews.Size = new Size(580, 300);
            dataGridViewReviews.BackgroundColor = Color.FromArgb(30, 30, 40);
            dataGridViewReviews.ForeColor = Color.White;
            dataGridViewReviews.GridColor = Color.FromArgb(60, 60, 70);
            dataGridViewReviews.BorderStyle = BorderStyle.None;
            dataGridViewReviews.EnableHeadersVisualStyles = false;
            dataGridViewReviews.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewReviews.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewReviews.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewReviews.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewReviews.RowHeadersVisible = false;

            panelReviewInput.BackColor = Color.FromArgb(45, 45, 55);
            panelReviewInput.BorderStyle = BorderStyle.FixedSingle;
            panelReviewInput.Location = new Point(20, 340);
            panelReviewInput.Size = new Size(580, 150);
            panelReviewInput.Controls.Add(lblReviewUser);
            panelReviewInput.Controls.Add(cmbUserForReview);
            panelReviewInput.Controls.Add(lblReviewMovie);
            panelReviewInput.Controls.Add(cmbMovieForReview);
            panelReviewInput.Controls.Add(lblReviewComment);
            panelReviewInput.Controls.Add(txtReviewComment);
            panelReviewInput.Controls.Add(lblReviewRating);
            panelReviewInput.Controls.Add(numRating);

            lblReviewUser.Text = "User:";
            lblReviewUser.ForeColor = Color.White;
            lblReviewUser.Location = new Point(20, 20);
            lblReviewUser.Size = new Size(60, 25);

            cmbUserForReview.Location = new Point(80, 18);
            cmbUserForReview.Size = new Size(180, 27);
            cmbUserForReview.BackColor = Color.FromArgb(60, 60, 70);
            cmbUserForReview.ForeColor = Color.White;
            cmbUserForReview.DropDownStyle = ComboBoxStyle.DropDownList;

            lblReviewMovie.Text = "Movie:";
            lblReviewMovie.ForeColor = Color.White;
            lblReviewMovie.Location = new Point(280, 20);
            lblReviewMovie.Size = new Size(60, 25);

            cmbMovieForReview.Location = new Point(340, 18);
            cmbMovieForReview.Size = new Size(180, 27);
            cmbMovieForReview.BackColor = Color.FromArgb(60, 60, 70);
            cmbMovieForReview.ForeColor = Color.White;
            cmbMovieForReview.DropDownStyle = ComboBoxStyle.DropDownList;

            lblReviewComment.Text = "Comment:";
            lblReviewComment.ForeColor = Color.White;
            lblReviewComment.Location = new Point(20, 60);
            lblReviewComment.Size = new Size(80, 25);

            txtReviewComment.Location = new Point(100, 58);
            txtReviewComment.Size = new Size(300, 27);
            txtReviewComment.BackColor = Color.FromArgb(60, 60, 70);
            txtReviewComment.ForeColor = Color.White;

            lblReviewRating.Text = "Rating (1-5):";
            lblReviewRating.ForeColor = Color.White;
            lblReviewRating.Location = new Point(20, 100);
            lblReviewRating.Size = new Size(100, 25);

            numRating.Location = new Point(120, 98);
            numRating.Size = new Size(60, 27);
            numRating.Minimum = 1;
            numRating.Maximum = 5;
            numRating.BackColor = Color.FromArgb(60, 60, 70);
            numRating.ForeColor = Color.White;

            btnLoadReviews.Text = "Load Reviews";
            btnLoadReviews.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadReviews.ForeColor = Color.White;
            btnLoadReviews.FlatStyle = FlatStyle.Flat;
            btnLoadReviews.Location = new Point(630, 30);
            btnLoadReviews.Size = new Size(140, 40);
            btnLoadReviews.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLoadReviews.Click += btnLoadReviews_Click;

            btnAddReview.Text = "Add Review";
            btnAddReview.BackColor = Color.FromArgb(255, 193, 7);
            btnAddReview.ForeColor = Color.Black;
            btnAddReview.FlatStyle = FlatStyle.Flat;
            btnAddReview.Location = new Point(630, 90);
            btnAddReview.Size = new Size(140, 40);
            btnAddReview.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAddReview.Click += btnAddReview_Click;

            // ==================== WATCHLIST TAB ====================
            tabWatchlist.Text = " Watchlist ";
            tabWatchlist.BackColor = Color.FromArgb(25, 25, 35);
            tabWatchlist.Controls.Add(dataGridViewWatchlist);
            tabWatchlist.Controls.Add(panelWatchlistInput);
            tabWatchlist.Controls.Add(btnLoadWatchlist);
            tabWatchlist.Controls.Add(btnAddToWatchlist);
            tabWatchlist.Controls.Add(btnRemoveFromWatchlist);

            dataGridViewWatchlist.Location = new Point(20, 20);
            dataGridViewWatchlist.Size = new Size(580, 300);
            dataGridViewWatchlist.BackgroundColor = Color.FromArgb(30, 30, 40);
            dataGridViewWatchlist.ForeColor = Color.White;
            dataGridViewWatchlist.GridColor = Color.FromArgb(60, 60, 70);
            dataGridViewWatchlist.BorderStyle = BorderStyle.None;
            dataGridViewWatchlist.EnableHeadersVisualStyles = false;
            dataGridViewWatchlist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewWatchlist.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewWatchlist.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewWatchlist.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewWatchlist.RowHeadersVisible = false;

            panelWatchlistInput.BackColor = Color.FromArgb(45, 45, 55);
            panelWatchlistInput.BorderStyle = BorderStyle.FixedSingle;
            panelWatchlistInput.Location = new Point(20, 340);
            panelWatchlistInput.Size = new Size(580, 100);
            panelWatchlistInput.Controls.Add(lblWatchlistUser);
            panelWatchlistInput.Controls.Add(cmbUserForWatchlist);
            panelWatchlistInput.Controls.Add(lblWatchlistMovie);
            panelWatchlistInput.Controls.Add(cmbMovieForWatchlist);

            lblWatchlistUser.Text = "User:";
            lblWatchlistUser.ForeColor = Color.White;
            lblWatchlistUser.Location = new Point(20, 25);
            lblWatchlistUser.Size = new Size(60, 25);

            cmbUserForWatchlist.Location = new Point(80, 23);
            cmbUserForWatchlist.Size = new Size(180, 27);
            cmbUserForWatchlist.BackColor = Color.FromArgb(60, 60, 70);
            cmbUserForWatchlist.ForeColor = Color.White;
            cmbUserForWatchlist.DropDownStyle = ComboBoxStyle.DropDownList;

            lblWatchlistMovie.Text = "Movie:";
            lblWatchlistMovie.ForeColor = Color.White;
            lblWatchlistMovie.Location = new Point(280, 25);
            lblWatchlistMovie.Size = new Size(60, 25);

            cmbMovieForWatchlist.Location = new Point(340, 23);
            cmbMovieForWatchlist.Size = new Size(180, 27);
            cmbMovieForWatchlist.BackColor = Color.FromArgb(60, 60, 70);
            cmbMovieForWatchlist.ForeColor = Color.White;
            cmbMovieForWatchlist.DropDownStyle = ComboBoxStyle.DropDownList;

            btnLoadWatchlist.Text = "Load Watchlist";
            btnLoadWatchlist.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadWatchlist.ForeColor = Color.White;
            btnLoadWatchlist.FlatStyle = FlatStyle.Flat;
            btnLoadWatchlist.Location = new Point(630, 30);
            btnLoadWatchlist.Size = new Size(140, 40);
            btnLoadWatchlist.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLoadWatchlist.Click += btnLoadWatchlist_Click;

            btnAddToWatchlist.Text = "Add to Watchlist";
            btnAddToWatchlist.BackColor = Color.FromArgb(40, 167, 69);
            btnAddToWatchlist.ForeColor = Color.White;
            btnAddToWatchlist.FlatStyle = FlatStyle.Flat;
            btnAddToWatchlist.Location = new Point(630, 90);
            btnAddToWatchlist.Size = new Size(140, 40);
            btnAddToWatchlist.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAddToWatchlist.Click += btnAddToWatchlist_Click;

            btnRemoveFromWatchlist.Text = "Remove from Watchlist";
            btnRemoveFromWatchlist.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveFromWatchlist.ForeColor = Color.White;
            btnRemoveFromWatchlist.FlatStyle = FlatStyle.Flat;
            btnRemoveFromWatchlist.Location = new Point(630, 150);
            btnRemoveFromWatchlist.Size = new Size(150, 40);
            btnRemoveFromWatchlist.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnRemoveFromWatchlist.Click += btnRemoveFromWatchlist_Click;

            // ==================== REPORTS TAB ====================
            tabReports.Text = " Reports ";
            tabReports.BackColor = Color.FromArgb(25, 25, 35);
            tabReports.Controls.Add(dataGridViewReports);
            tabReports.Controls.Add(panelReportsInput);
            tabReports.Controls.Add(btnTopRated);
            tabReports.Controls.Add(btnFilterByCategory);

            dataGridViewReports.Location = new Point(20, 20);
            dataGridViewReports.Size = new Size(580, 300);
            dataGridViewReports.BackgroundColor = Color.FromArgb(30, 30, 40);
            dataGridViewReports.ForeColor = Color.White;
            dataGridViewReports.GridColor = Color.FromArgb(60, 60, 70);
            dataGridViewReports.BorderStyle = BorderStyle.None;
            dataGridViewReports.EnableHeadersVisualStyles = false;
            dataGridViewReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewReports.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewReports.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewReports.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewReports.RowHeadersVisible = false;

            panelReportsInput.BackColor = Color.FromArgb(45, 45, 55);
            panelReportsInput.BorderStyle = BorderStyle.FixedSingle;
            panelReportsInput.Location = new Point(20, 340);
            panelReportsInput.Size = new Size(580, 80);
            panelReportsInput.Controls.Add(lblFilterCategory);
            panelReportsInput.Controls.Add(cmbFilterCategory);

            lblFilterCategory.Text = "Filter by Category:";
            lblFilterCategory.ForeColor = Color.White;
            lblFilterCategory.Location = new Point(20, 28);
            lblFilterCategory.Size = new Size(130, 25);

            cmbFilterCategory.Location = new Point(160, 26);
            cmbFilterCategory.Size = new Size(150, 27);
            cmbFilterCategory.BackColor = Color.FromArgb(60, 60, 70);
            cmbFilterCategory.ForeColor = Color.White;
            cmbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            btnTopRated.Text = "Top Rated Movies";
            btnTopRated.BackColor = Color.FromArgb(255, 193, 7);
            btnTopRated.ForeColor = Color.Black;
            btnTopRated.FlatStyle = FlatStyle.Flat;
            btnTopRated.Location = new Point(630, 30);
            btnTopRated.Size = new Size(180, 50);
            btnTopRated.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnTopRated.Click += btnTopRated_Click;

            btnFilterByCategory.Text = "Filter by Category";
            btnFilterByCategory.BackColor = Color.FromArgb(23, 162, 184);
            btnFilterByCategory.ForeColor = Color.White;
            btnFilterByCategory.FlatStyle = FlatStyle.Flat;
            btnFilterByCategory.Location = new Point(630, 100);
            btnFilterByCategory.Size = new Size(180, 50);
            btnFilterByCategory.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnFilterByCategory.Click += btnFilterByCategory_Click;

            // ==================== FORM SETUP ====================
            this.Controls.Add(tabControl1);
            this.Size = new Size(950, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Movie Streaming System - Complete Solution";
            this.BackColor = Color.FromArgb(20, 20, 30);
        }

        // ==================== DECLARATIONS ====================
        private TabControl tabControl1;
        private TabPage tabMovies, tabUsers, tabReviews, tabWatchlist, tabReports;

        // Movies
        private DataGridView dataGridViewMovies;
        private Button btnLoadMovies, btnAddMovie, btnSoftDeleteMovie;
        private TextBox txtMovieTitle, txtMovieYear;
        private ComboBox cmbCategory;
        private Label lblMovieTitle, lblMovieYear, lblCategory;
        private Panel panelMovieInput;

        // Users
        private DataGridView dataGridViewUsers;
        private Button btnLoadUsers, btnAddUser;
        private TextBox txtUserName, txtUserEmail;
        private Label lblUserName, lblUserEmail;
        private Panel panelUserInput;

        // Reviews
        private DataGridView dataGridViewReviews;
        private Button btnLoadReviews, btnAddReview;
        private ComboBox cmbMovieForReview, cmbUserForReview;
        private TextBox txtReviewComment;
        private NumericUpDown numRating;
        private Label lblReviewMovie, lblReviewUser, lblReviewComment, lblReviewRating;
        private Panel panelReviewInput;

        // Watchlist
        private DataGridView dataGridViewWatchlist;
        private Button btnLoadWatchlist, btnAddToWatchlist, btnRemoveFromWatchlist;
        private ComboBox cmbUserForWatchlist, cmbMovieForWatchlist;
        private Label lblWatchlistUser, lblWatchlistMovie;
        private Panel panelWatchlistInput;

        // Reports
        private DataGridView dataGridViewReports;
        private Button btnTopRated, btnFilterByCategory;
        private ComboBox cmbFilterCategory;
        private Label lblFilterCategory;
        private Panel panelReportsInput;
    }
}