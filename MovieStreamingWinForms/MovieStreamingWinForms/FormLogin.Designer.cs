namespace MovieStreamingWinForms
{
    partial class FormLogin
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
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnRegister = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.SuspendLayout();

            this.BackColor = Color.FromArgb(240, 244, 248);

            this.txtEmail.Location = new Point(120, 40);
            this.txtEmail.Size = new Size(200, 27);
            this.txtEmail.BackColor = Color.White;

            this.txtPassword.Location = new Point(120, 90);
            this.txtPassword.Size = new Size(200, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BackColor = Color.White;

            this.btnLogin.Text = "Login";
            this.btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Location = new Point(120, 140);
            this.btnLogin.Size = new Size(90, 35);
            this.btnLogin.Click += btnLogin_Click;

            this.btnRegister.Text = "Register";
            this.btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Location = new Point(230, 140);
            this.btnRegister.Size = new Size(90, 35);
            this.btnRegister.Click += btnRegister_Click;

            this.label1.Text = "Email:"; this.label1.Location = new Point(40, 43); this.label1.Size = new Size(60, 25);
            this.label2.Text = "Password:"; this.label2.Location = new Point(40, 93); this.label2.Size = new Size(80, 25);

            this.Text = "Movie Streaming System - Login";
            this.Size = new Size(380, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label label1;
        private Label label2;
    }
}