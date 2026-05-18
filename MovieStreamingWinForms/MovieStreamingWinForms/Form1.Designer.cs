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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabMovies = new TabPage();
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
            tabUsers = new TabPage();
            dataGridViewUsers = new DataGridView();
            btnLoadUsers = new Button();
            btnAddUser = new Button();
            txtUserName = new TextBox();
            txtUserEmail = new TextBox();
            lblUserName = new Label();
            lblUserEmail = new Label();
            tabReviews = new TabPage();
            dataGridViewReviews = new DataGridView();
            btnLoadReviews = new Button();
            btnAddReview = new Button();
            cmbUserForReview = new ComboBox();
            cmbMovieForReview = new ComboBox();
            txtReviewComment = new TextBox();
            numRating = new NumericUpDown();
            lblReviewUser = new Label();
            lblReviewMovie = new Label();
            lblReviewComment = new Label();
            lblReviewRating = new Label();
            tabWatchlist = new TabPage();
            dataGridViewWatchlist = new DataGridView();
            btnLoadWatchlist = new Button();
            btnAddToWatchlist = new Button();
            btnRemoveFromWatchlist = new Button();
            cmbUserForWatchlist = new ComboBox();
            cmbMovieForWatchlist = new ComboBox();
            lblWatchlistUser = new Label();
            lblWatchlistMovie = new Label();
            tabReports = new TabPage();
            dataGridViewReports = new DataGridView();
            btnTopRated = new Button();
            btnFilterByCategory = new Button();
            cmbFilterCategory = new ComboBox();
            lblFilterCategory = new Label();
            tabControl1.SuspendLayout();
            tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabReviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            tabWatchlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWatchlist).BeginInit();
            tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMovies);
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Controls.Add(tabReviews);
            tabControl1.Controls.Add(tabWatchlist);
            tabControl1.Controls.Add(tabReports);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(884, 561);
            tabControl1.TabIndex = 0;
            // 
            // tabMovies
            // 
            tabMovies.BackColor = Color.White;
            tabMovies.Controls.Add(dataGridViewMovies);
            tabMovies.Controls.Add(btnLoadMovies);
            tabMovies.Controls.Add(btnAddMovie);
            tabMovies.Controls.Add(btnSoftDeleteMovie);
            tabMovies.Controls.Add(txtMovieTitle);
            tabMovies.Controls.Add(txtMovieYear);
            tabMovies.Controls.Add(cmbCategory);
            tabMovies.Controls.Add(lblMovieTitle);
            tabMovies.Controls.Add(lblMovieYear);
            tabMovies.Controls.Add(lblCategory);
            tabMovies.Location = new Point(4, 26);
            tabMovies.Name = "tabMovies";
            tabMovies.Size = new Size(876, 531);
            tabMovies.TabIndex = 0;
            tabMovies.Text = " Movies ";
            // 
            // dataGridViewMovies
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 244, 248);
            dataGridViewMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMovies.BackgroundColor = Color.White;
            dataGridViewMovies.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewMovies.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMovies.EnableHeadersVisualStyles = false;
            dataGridViewMovies.Location = new Point(20, 20);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersVisible = false;
            dataGridViewMovies.Size = new Size(580, 300);
            dataGridViewMovies.TabIndex = 0;
            // 
            // btnLoadMovies
            // 
            btnLoadMovies.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadMovies.FlatStyle = FlatStyle.Flat;
            btnLoadMovies.ForeColor = Color.White;
            btnLoadMovies.Location = new Point(630, 59);
            btnLoadMovies.Name = "btnLoadMovies";
            btnLoadMovies.Size = new Size(140, 40);
            btnLoadMovies.TabIndex = 1;
            btnLoadMovies.Text = "Load Movies";
            btnLoadMovies.UseVisualStyleBackColor = false;
            btnLoadMovies.Click += btnLoadMovies_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.BackColor = Color.FromArgb(40, 167, 69);
            btnAddMovie.FlatStyle = FlatStyle.Flat;
            btnAddMovie.ForeColor = Color.White;
            btnAddMovie.Location = new Point(590, 265);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(124, 40);
            btnAddMovie.TabIndex = 2;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = false;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnSoftDeleteMovie
            // 
            btnSoftDeleteMovie.BackColor = Color.FromArgb(220, 53, 69);
            btnSoftDeleteMovie.FlatStyle = FlatStyle.Flat;
            btnSoftDeleteMovie.ForeColor = Color.White;
            btnSoftDeleteMovie.Location = new Point(630, 105);
            btnSoftDeleteMovie.Name = "btnSoftDeleteMovie";
            btnSoftDeleteMovie.Size = new Size(140, 40);
            btnSoftDeleteMovie.TabIndex = 3;
            btnSoftDeleteMovie.Text = "Soft Delete";
            btnSoftDeleteMovie.UseVisualStyleBackColor = false;
            btnSoftDeleteMovie.Click += btnSoftDeleteMovie_Click;
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location = new Point(590, 326);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(180, 25);
            txtMovieTitle.TabIndex = 4;
            // 
            // txtMovieYear
            // 
            txtMovieYear.Location = new Point(590, 371);
            txtMovieYear.Name = "txtMovieYear";
            txtMovieYear.Size = new Size(100, 25);
            txtMovieYear.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(590, 417);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 25);
            cmbCategory.TabIndex = 6;
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.Location = new Point(500, 328);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(100, 23);
            lblMovieTitle.TabIndex = 7;
            lblMovieTitle.Text = "Title:";
            // 
            // lblMovieYear
            // 
            lblMovieYear.Location = new Point(500, 371);
            lblMovieYear.Name = "lblMovieYear";
            lblMovieYear.Size = new Size(100, 23);
            lblMovieYear.TabIndex = 8;
            lblMovieYear.Text = "Year:";
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(500, 419);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category:";
            // 
            // tabUsers
            // 
            tabUsers.BackColor = Color.White;
            tabUsers.Controls.Add(dataGridViewUsers);
            tabUsers.Controls.Add(btnLoadUsers);
            tabUsers.Controls.Add(btnAddUser);
            tabUsers.Controls.Add(txtUserName);
            tabUsers.Controls.Add(txtUserEmail);
            tabUsers.Controls.Add(lblUserName);
            tabUsers.Controls.Add(lblUserEmail);
            tabUsers.Location = new Point(4, 26);
            tabUsers.Name = "tabUsers";
            tabUsers.Size = new Size(876, 531);
            tabUsers.TabIndex = 1;
            tabUsers.Text = " Users ";
            // 
            // dataGridViewUsers
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(240, 244, 248);
            dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.Location = new Point(20, 20);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.Size = new Size(580, 300);
            dataGridViewUsers.TabIndex = 0;
            // 
            // btnLoadUsers
            // 
            btnLoadUsers.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadUsers.FlatStyle = FlatStyle.Flat;
            btnLoadUsers.ForeColor = Color.White;
            btnLoadUsers.Location = new Point(630, 30);
            btnLoadUsers.Name = "btnLoadUsers";
            btnLoadUsers.Size = new Size(140, 40);
            btnLoadUsers.TabIndex = 1;
            btnLoadUsers.Text = "Load Users";
            btnLoadUsers.UseVisualStyleBackColor = false;
            btnLoadUsers.Click += btnLoadUsers_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(40, 167, 69);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(630, 90);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(140, 40);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(80, 350);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 25);
            txtUserName.TabIndex = 3;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(80, 390);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(250, 25);
            txtUserEmail.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.Location = new Point(20, 353);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(100, 23);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "Name:";
            // 
            // lblUserEmail
            // 
            lblUserEmail.Location = new Point(20, 393);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(100, 23);
            lblUserEmail.TabIndex = 6;
            lblUserEmail.Text = "Email:";
            // 
            // tabReviews
            // 
            tabReviews.BackColor = Color.White;
            tabReviews.Controls.Add(dataGridViewReviews);
            tabReviews.Controls.Add(btnLoadReviews);
            tabReviews.Controls.Add(btnAddReview);
            tabReviews.Controls.Add(cmbUserForReview);
            tabReviews.Controls.Add(cmbMovieForReview);
            tabReviews.Controls.Add(txtReviewComment);
            tabReviews.Controls.Add(numRating);
            tabReviews.Controls.Add(lblReviewUser);
            tabReviews.Controls.Add(lblReviewMovie);
            tabReviews.Controls.Add(lblReviewComment);
            tabReviews.Controls.Add(lblReviewRating);
            tabReviews.Location = new Point(4, 26);
            tabReviews.Name = "tabReviews";
            tabReviews.Size = new Size(876, 531);
            tabReviews.TabIndex = 2;
            tabReviews.Text = " Reviews ";
            // 
            // dataGridViewReviews
            // 
            dataGridViewCellStyle7.BackColor = Color.FromArgb(240, 244, 248);
            dataGridViewReviews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewReviews.BackgroundColor = Color.White;
            dataGridViewReviews.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewReviews.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewReviews.EnableHeadersVisualStyles = false;
            dataGridViewReviews.Location = new Point(20, 20);
            dataGridViewReviews.Name = "dataGridViewReviews";
            dataGridViewReviews.RowHeadersVisible = false;
            dataGridViewReviews.Size = new Size(580, 300);
            dataGridViewReviews.TabIndex = 0;
            // 
            // btnLoadReviews
            // 
            btnLoadReviews.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadReviews.FlatStyle = FlatStyle.Flat;
            btnLoadReviews.ForeColor = Color.White;
            btnLoadReviews.Location = new Point(630, 30);
            btnLoadReviews.Name = "btnLoadReviews";
            btnLoadReviews.Size = new Size(140, 40);
            btnLoadReviews.TabIndex = 1;
            btnLoadReviews.Text = "Load Reviews";
            btnLoadReviews.UseVisualStyleBackColor = false;
            btnLoadReviews.Click += btnLoadReviews_Click;
            // 
            // btnAddReview
            // 
            btnAddReview.BackColor = Color.FromArgb(255, 193, 7);
            btnAddReview.FlatStyle = FlatStyle.Flat;
            btnAddReview.ForeColor = Color.Black;
            btnAddReview.Location = new Point(630, 90);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(140, 40);
            btnAddReview.TabIndex = 2;
            btnAddReview.Text = "Add Review";
            btnAddReview.UseVisualStyleBackColor = false;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // cmbUserForReview
            // 
            cmbUserForReview.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserForReview.Location = new Point(80, 350);
            cmbUserForReview.Name = "cmbUserForReview";
            cmbUserForReview.Size = new Size(180, 25);
            cmbUserForReview.TabIndex = 3;
            // 
            // cmbMovieForReview
            // 
            cmbMovieForReview.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovieForReview.Location = new Point(340, 350);
            cmbMovieForReview.Name = "cmbMovieForReview";
            cmbMovieForReview.Size = new Size(180, 25);
            cmbMovieForReview.TabIndex = 4;
            // 
            // txtReviewComment
            // 
            txtReviewComment.Location = new Point(80, 390);
            txtReviewComment.Name = "txtReviewComment";
            txtReviewComment.Size = new Size(300, 25);
            txtReviewComment.TabIndex = 5;
            // 
            // numRating
            // 
            numRating.Location = new Point(120, 430);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(60, 25);
            numRating.TabIndex = 6;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblReviewUser
            // 
            lblReviewUser.Location = new Point(20, 353);
            lblReviewUser.Name = "lblReviewUser";
            lblReviewUser.Size = new Size(100, 23);
            lblReviewUser.TabIndex = 7;
            lblReviewUser.Text = "User:";
            // 
            // lblReviewMovie
            // 
            lblReviewMovie.Location = new Point(280, 353);
            lblReviewMovie.Name = "lblReviewMovie";
            lblReviewMovie.Size = new Size(100, 23);
            lblReviewMovie.TabIndex = 8;
            lblReviewMovie.Text = "Movie:";
            // 
            // lblReviewComment
            // 
            lblReviewComment.Location = new Point(20, 393);
            lblReviewComment.Name = "lblReviewComment";
            lblReviewComment.Size = new Size(100, 23);
            lblReviewComment.TabIndex = 9;
            lblReviewComment.Text = "Comment:";
            // 
            // lblReviewRating
            // 
            lblReviewRating.Location = new Point(20, 433);
            lblReviewRating.Name = "lblReviewRating";
            lblReviewRating.Size = new Size(100, 23);
            lblReviewRating.TabIndex = 10;
            lblReviewRating.Text = "Rating (1-5):";
            // 
            // tabWatchlist
            // 
            tabWatchlist.BackColor = Color.White;
            tabWatchlist.Controls.Add(dataGridViewWatchlist);
            tabWatchlist.Controls.Add(btnLoadWatchlist);
            tabWatchlist.Controls.Add(btnAddToWatchlist);
            tabWatchlist.Controls.Add(btnRemoveFromWatchlist);
            tabWatchlist.Controls.Add(cmbUserForWatchlist);
            tabWatchlist.Controls.Add(cmbMovieForWatchlist);
            tabWatchlist.Controls.Add(lblWatchlistUser);
            tabWatchlist.Controls.Add(lblWatchlistMovie);
            tabWatchlist.Location = new Point(4, 26);
            tabWatchlist.Name = "tabWatchlist";
            tabWatchlist.Size = new Size(876, 531);
            tabWatchlist.TabIndex = 3;
            tabWatchlist.Text = " Watchlist ";
            // 
            // dataGridViewWatchlist
            // 
            dataGridViewCellStyle10.BackColor = Color.FromArgb(240, 244, 248);
            dataGridViewWatchlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewWatchlist.BackgroundColor = Color.White;
            dataGridViewWatchlist.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewWatchlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewWatchlist.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewWatchlist.EnableHeadersVisualStyles = false;
            dataGridViewWatchlist.Location = new Point(20, 20);
            dataGridViewWatchlist.Name = "dataGridViewWatchlist";
            dataGridViewWatchlist.RowHeadersVisible = false;
            dataGridViewWatchlist.Size = new Size(580, 300);
            dataGridViewWatchlist.TabIndex = 0;
            // 
            // btnLoadWatchlist
            // 
            btnLoadWatchlist.BackColor = Color.FromArgb(0, 120, 215);
            btnLoadWatchlist.FlatStyle = FlatStyle.Flat;
            btnLoadWatchlist.ForeColor = Color.White;
            btnLoadWatchlist.Location = new Point(630, 30);
            btnLoadWatchlist.Name = "btnLoadWatchlist";
            btnLoadWatchlist.Size = new Size(160, 40);
            btnLoadWatchlist.TabIndex = 1;
            btnLoadWatchlist.Text = "Load Watchlist";
            btnLoadWatchlist.UseVisualStyleBackColor = false;
            btnLoadWatchlist.Click += btnLoadWatchlist_Click;
            // 
            // btnAddToWatchlist
            // 
            btnAddToWatchlist.BackColor = Color.FromArgb(40, 167, 69);
            btnAddToWatchlist.FlatStyle = FlatStyle.Flat;
            btnAddToWatchlist.ForeColor = Color.White;
            btnAddToWatchlist.Location = new Point(630, 90);
            btnAddToWatchlist.Name = "btnAddToWatchlist";
            btnAddToWatchlist.Size = new Size(160, 40);
            btnAddToWatchlist.TabIndex = 2;
            btnAddToWatchlist.Text = "Add to Watchlist";
            btnAddToWatchlist.UseVisualStyleBackColor = false;
            btnAddToWatchlist.Click += btnAddToWatchlist_Click;
            // 
            // btnRemoveFromWatchlist
            // 
            btnRemoveFromWatchlist.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveFromWatchlist.FlatStyle = FlatStyle.Flat;
            btnRemoveFromWatchlist.ForeColor = Color.White;
            btnRemoveFromWatchlist.Location = new Point(630, 150);
            btnRemoveFromWatchlist.Name = "btnRemoveFromWatchlist";
            btnRemoveFromWatchlist.Size = new Size(160, 40);
            btnRemoveFromWatchlist.TabIndex = 3;
            btnRemoveFromWatchlist.Text = "Remove from Watchlist";
            btnRemoveFromWatchlist.UseVisualStyleBackColor = false;
            btnRemoveFromWatchlist.Click += btnRemoveFromWatchlist_Click;
            // 
            // cmbUserForWatchlist
            // 
            cmbUserForWatchlist.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserForWatchlist.Location = new Point(80, 350);
            cmbUserForWatchlist.Name = "cmbUserForWatchlist";
            cmbUserForWatchlist.Size = new Size(180, 25);
            cmbUserForWatchlist.TabIndex = 4;
            // 
            // cmbMovieForWatchlist
            // 
            cmbMovieForWatchlist.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovieForWatchlist.Location = new Point(340, 350);
            cmbMovieForWatchlist.Name = "cmbMovieForWatchlist";
            cmbMovieForWatchlist.Size = new Size(180, 25);
            cmbMovieForWatchlist.TabIndex = 5;
            // 
            // lblWatchlistUser
            // 
            lblWatchlistUser.Location = new Point(20, 353);
            lblWatchlistUser.Name = "lblWatchlistUser";
            lblWatchlistUser.Size = new Size(100, 23);
            lblWatchlistUser.TabIndex = 6;
            lblWatchlistUser.Text = "User:";
            // 
            // lblWatchlistMovie
            // 
            lblWatchlistMovie.Location = new Point(280, 353);
            lblWatchlistMovie.Name = "lblWatchlistMovie";
            lblWatchlistMovie.Size = new Size(100, 23);
            lblWatchlistMovie.TabIndex = 7;
            lblWatchlistMovie.Text = "Movie:";
            // 
            // tabReports
            // 
            tabReports.BackColor = Color.White;
            tabReports.Controls.Add(dataGridViewReports);
            tabReports.Controls.Add(btnTopRated);
            tabReports.Controls.Add(btnFilterByCategory);
            tabReports.Controls.Add(cmbFilterCategory);
            tabReports.Controls.Add(lblFilterCategory);
            tabReports.Location = new Point(4, 26);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(876, 531);
            tabReports.TabIndex = 4;
            tabReports.Text = " Reports ";
            // 
            // dataGridViewReports
            // 
            dataGridViewCellStyle13.BackColor = Color.FromArgb(240, 244, 248);
            dataGridViewReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewReports.BackgroundColor = Color.White;
            dataGridViewReports.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridViewReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dataGridViewReports.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewReports.EnableHeadersVisualStyles = false;
            dataGridViewReports.Location = new Point(20, 20);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowHeadersVisible = false;
            dataGridViewReports.Size = new Size(580, 300);
            dataGridViewReports.TabIndex = 0;
            // 
            // btnTopRated
            // 
            btnTopRated.BackColor = Color.FromArgb(255, 193, 7);
            btnTopRated.FlatStyle = FlatStyle.Flat;
            btnTopRated.ForeColor = Color.Black;
            btnTopRated.Location = new Point(630, 30);
            btnTopRated.Name = "btnTopRated";
            btnTopRated.Size = new Size(180, 50);
            btnTopRated.TabIndex = 1;
            btnTopRated.Text = "Top Rated Movies";
            btnTopRated.UseVisualStyleBackColor = false;
            btnTopRated.Click += btnTopRated_Click;
            // 
            // btnFilterByCategory
            // 
            btnFilterByCategory.BackColor = Color.FromArgb(23, 162, 184);
            btnFilterByCategory.FlatStyle = FlatStyle.Flat;
            btnFilterByCategory.ForeColor = Color.White;
            btnFilterByCategory.Location = new Point(630, 100);
            btnFilterByCategory.Name = "btnFilterByCategory";
            btnFilterByCategory.Size = new Size(180, 50);
            btnFilterByCategory.TabIndex = 2;
            btnFilterByCategory.Text = "Filter by Category";
            btnFilterByCategory.UseVisualStyleBackColor = false;
            btnFilterByCategory.Click += btnFilterByCategory_Click;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterCategory.Location = new Point(160, 380);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(150, 25);
            cmbFilterCategory.TabIndex = 3;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.Location = new Point(20, 383);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(100, 23);
            lblFilterCategory.TabIndex = 4;
            lblFilterCategory.Text = "Filter by Category:";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(884, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Streaming System";
            tabControl1.ResumeLayout(false);
            tabMovies.ResumeLayout(false);
            tabMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tabReviews.ResumeLayout(false);
            tabReviews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            tabWatchlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWatchlist).EndInit();
            tabReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage tabMovies, tabUsers, tabReviews, tabWatchlist, tabReports;
        private DataGridView dataGridViewMovies, dataGridViewUsers, dataGridViewReviews, dataGridViewWatchlist, dataGridViewReports;
        private Button btnLoadMovies, btnAddMovie, btnSoftDeleteMovie, btnLoadUsers, btnAddUser, btnLoadReviews, btnAddReview, btnLoadWatchlist, btnAddToWatchlist, btnRemoveFromWatchlist, btnTopRated, btnFilterByCategory;
        private TextBox txtMovieTitle, txtMovieYear, txtUserName, txtUserEmail, txtReviewComment;
        private ComboBox cmbCategory, cmbUserForReview, cmbMovieForReview, cmbUserForWatchlist, cmbMovieForWatchlist, cmbFilterCategory;
        private NumericUpDown numRating;
        private Label lblMovieTitle, lblMovieYear, lblCategory, lblUserName, lblUserEmail, lblReviewUser, lblReviewMovie, lblReviewComment, lblReviewRating, lblWatchlistUser, lblWatchlistMovie, lblFilterCategory;
    }
}