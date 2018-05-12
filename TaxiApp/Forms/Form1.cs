using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiApp.Helpers;

namespace TaxiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Constants.Instance.InitializeConstants();

            signupPanel.Visible = false;
        }

        // Exit button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = true;
        }

        private void signupLoginButton_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = false;
            ResetSignUpPanel();
        }

        private void ResetSignUpPanel()
        {
            signupName.Text = string.Empty;
            signupSurname.Text = string.Empty;
            signupPassword1.Text = string.Empty;
            termsCheckbox.Checked = false;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signupName.Text) || 
                string.IsNullOrWhiteSpace(signupSurname.Text))
            {
                MessageBox.Show("Please enter your valid Name and Surname", "Oops, that's unavailable!");
                return;
            }

            if (string.IsNullOrWhiteSpace(signupUsername.Text))
            {
                MessageBox.Show("Please enter a unique username", "Oops, that's unavailable!");
                return;
            }

            CheckUsername(signupUsername.Text);

            if (string.IsNullOrWhiteSpace(signupPassword1.Text))
            {
                MessageBox.Show("A password is required", "Oops, that's unavailable!");
                return;
            }

            signupPanel.Visible = false;
            // TODO: Login
            OnLogin();
        }

        private void CheckUsername(string username)
        {
            if (username == "kek")
                MessageBox.Show("Please, try another username", "Oops, that's unavailable!");
        }

        private void OnLogin()
        {
            Hide();
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnLogin();
        }
    }
}
