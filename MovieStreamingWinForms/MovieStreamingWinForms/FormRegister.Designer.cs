namespace MovieStreamingWinForms
{
    partial class FormRegister
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
            this.txtName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            this.btnRegister = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.SuspendLayout();

            this.BackColor = Color.FromArgb(240, 244, 248);

            this.txtName.Location = new Point(140, 30); this.txtName.Size = new Size(200, 27); this.txtName.BackColor = Color.White;
            this.txtEmail.Location = new Point(140, 70); this.txtEmail.Size = new Size(200, 27); this.txtEmail.BackColor = Color.White;
            this.txtPassword.Location = new Point(140, 110); this.txtPassword.Size = new Size(200, 27); this.txtPassword.UseSystemPasswordChar = true; this.txtPassword.BackColor = Color.White;
            this.txtConfirmPassword.Location = new Point(140, 150); this.txtConfirmPassword.Size = new Size(200, 27); this.txtConfirmPassword.UseSystemPasswordChar = true; this.txtConfirmPassword.BackColor = Color.White;

            this.btnRegister.Text = "Register";
            this.btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Location = new Point(140, 200);
            this.btnRegister.Size = new Size(100, 40);
            this.btnRegister.Click += btnRegister_Click;

            this.label1.Text = "Name:"; this.label1.Location = new Point(40, 33); this.label1.Size = new Size(80, 25);
            this.label2.Text = "Email:"; this.label2.Location = new Point(40, 73); this.label2.Size = new Size(80, 25);
            this.label3.Text = "Password:"; this.label3.Location = new Point(40, 113); this.label3.Size = new Size(80, 25);
            this.label4.Text = "Confirm:"; this.label4.Location = new Point(40, 153); this.label4.Size = new Size(80, 25);

            this.Text = "Register New Account";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtName, txtEmail, txtPassword, txtConfirmPassword;
        private Button btnRegister;
        private Label label1, label2, label3, label4;
    }
}