﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TaxiApp.Helpers;
using TaxiApp.Models;

namespace TaxiApp.Forms
{
    public partial class HomeControl : UserControl
    {
        private int currentOrder;
        private bool initialized;

        public HomeControl()
        {
            InitializeComponent();
            LoadOrders();
            LoadDrivers();

            orderMainPanel.Visible = false;
            ordersList.ItemActivate += OnOrderOpen;
        }

        private void OnOrderOpen(object sender, EventArgs e)
        {
            var item = ordersList.SelectedItems[0];

            orderMainPanel.Visible = true;

            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Orders Where OrderId = @id";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", item.Text);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        currentOrder = Convert.ToInt32(dr["OrderId"]);
                        orderIdLabel.Text = $"Order: #{currentOrder.ToString()}";
                        orderClientLabel.Text = dr["ClientName"].ToString();
                        orderPhoneLabel.Text = dr["Phone"].ToString();
                        orderLandingLabel.Text = $"{dr["LandingStreet"].ToString()}, {dr["LandingAddress"].ToString()}";
                        orderTargetLabel.Text = $"{dr["TargetStreet"].ToString()}, {dr["TargetAddress"].ToString()}";
                        orderDiscountLabel.Text = $"Discount: {dr["DiscountCode"].ToString()}";
                    }
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            ordersList.Items.Clear();

            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Orders Order By OrderDate Asc";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var item = new ListViewItem(dr["OrderId"].ToString());
                        item.SubItems.Add(dr["ClientName"].ToString());
                        item.SubItems.Add(dr["Phone"].ToString());
                        item.SubItems.Add($"{dr["LandingStreet"].ToString()}, {dr["LandingAddress"].ToString()}");
                        item.SubItems.Add($"{dr["TargetStreet"].ToString()}, {dr["TargetAddress"].ToString()}");

                        ordersList.Items.Add(item);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadDrivers()
        {
            orderDriversDropdown.Clear();

            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Drivers";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        orderDriversDropdown.AddItem($"{dr["Name"].ToString()} {dr["Surname"].ToString()}");
                    }
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void startTripButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    string query = "Insert Into TripReport (Driver, CompletedOrder, Comment, DriverName) Values (@driver, @completedOrder, @comment, @driverName)";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("driver", "");
                    cmd.Parameters.AddWithValue("completedOrder", currentOrder);
                    cmd.Parameters.AddWithValue("comment", GetRandomComment());
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string GetRandomComment()
        {
            var comments = new string[]
                {
                    "Tremendously thought out! Contrast.",
                    "Bold work you have here.",
                    "",
                    "Vastly sublime illustration mate",
                    "I adore your style m8",
                    "",
                    "Nice use of red in this shot m8",
                    "So sick and good!"
                };

            var rand = new Random();
            return comments[rand.Next(0, comments.Length)];
        }
    }
}
