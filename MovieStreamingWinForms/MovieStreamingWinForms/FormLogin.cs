using System;
using System.Linq;
using System.Windows.Forms;
using MovieStreamingWinForms.Data;
using MovieStreamingWinForms.Models;
using BCrypt.Net;

namespace MovieStreamingWinForms
{
    public partial class FormLogin : Form
    {
        public static User? LoggedInUser { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoggedInUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new FormRegister();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration successful! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}