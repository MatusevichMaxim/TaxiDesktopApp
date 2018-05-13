using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiApp.Helpers;
using TaxiApp.Models;

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

        // Open SugnUp Panel
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
            signupUsername.Text = string.Empty;
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

            if (string.IsNullOrWhiteSpace(signupPassword1.Text))
            {
                MessageBox.Show("A password is required", "Oops, that's unavailable!");
                return;
            }

            if (!termsCheckbox.Checked)
            {
                MessageBox.Show("Make sure you accept the terms of service and privacy policy", "Oops, that's unavailable!");
                return;
            }

            var result = TryCreateAccount(signupName.Text, signupSurname.Text, signupUsername.Text, signupPassword1.Text, 2);

            signupPanel.Visible = false;
            ResetSignUpPanel();

            if (result)
            {
                loginUsername.Text = signupUsername.Text;
                loginPassword.Text = signupPassword1.Text;
            }
        }

        private bool TryCreateAccount(string name, string surname, string login, string pass, int status)
        {
            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Insert Into Accounts (Name, Surname, Login, Password, UserStatus) Values (@name, @surname, @login, @pass, @status)";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("surname", surname);
                    cmd.Parameters.AddWithValue("login", login);
                    cmd.Parameters.AddWithValue("pass", pass);
                    cmd.Parameters.AddWithValue("status", status);

                    var result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error inserting data into Database");
                        return false;
                    }
                    else
                        return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void OnLogin(string login, string pass)
        {
            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Accounts";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (login == dr["Login"].ToString())
                        {
                            if (pass == dr["Password"].ToString())
                            {
                                Constants.Instance.SetStatus(Convert.ToInt32(dr["UserStatus"]));
                                Hide();
                                MainMenuForm mainMenu = new MainMenuForm();
                                mainMenu.Show();
                                return;
                            }
                        }
                    }

                    MessageBox.Show("The email/password combination used was not found on the system", "Oops, that's unavailable!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // main menu "Login"
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginUsername.Text) || string.IsNullOrWhiteSpace(loginPassword.Text))
            {
                MessageBox.Show("Please enter your Name and Password", "Oops, that's unavailable!");
                return;
            }
            else
            {
                OnLogin(loginUsername.Text, loginPassword.Text);
            }
        }
    }
}
