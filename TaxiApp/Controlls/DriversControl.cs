using System;
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

namespace TaxiApp.Controlls
{
    public partial class DriversControl : UserControl
    {
        public DriversControl()
        {
            InitializeComponent();
            LoadDrivers();
        }

        private void LoadDrivers()
        {
            driversList.Items.Clear();

            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Drivers Order By Rating Desc";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var item = new ListViewItem(dr["Name"].ToString());
                        item.SubItems.Add(dr["Surname"].ToString());
                        item.SubItems.Add(GetCar(Convert.ToInt32(dr["Car"])));
                        item.SubItems.Add(dr["Rating"].ToString());

                        driversList.Items.Add(item);
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

        private string GetCar(int id)
        {
            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    string query = "Update Cars Set BrandName = (select Name from Brands where Brand = BrandId)";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error inserting data into Database");
                        return null;
                    }

                    query = "Select * From Cars Where CarId = @id";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);

                    var dr = cmd.ExecuteReader();
                    string brand = "";

                    while (dr.Read())
                    {
                        brand = dr["BrandName"].ToString();
                    }

                    return brand;
                }
                catch (SqlException ex)
                { return null; }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void driversRefresh_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        // Add new driver
        private void startTripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newDriverName.Text) || string.IsNullOrWhiteSpace(newDriverSurname.Text) ||
                string.IsNullOrWhiteSpace(newDriverBrand.Text) || string.IsNullOrWhiteSpace(newDriverColor.Text) ||
                string.IsNullOrWhiteSpace(newDriverNumber.Text))
            {
                MessageBox.Show("Fill all the fields before adding", "Oops, that's unavailable!");
                return;
            }
            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    string query = "Insert Into Cars (Brand, Number, Color) Output INSERTED.CarId Values (@brand, @number, @color)";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("brand", newDriverBrand.Text);
                    cmd.Parameters.AddWithValue("number", newDriverNumber.Text);
                    cmd.Parameters.AddWithValue("color", newDriverColor.Text);

                    var result = cmd.ExecuteScalar();

                    query = "Insert Into Drivers (Name, Surname, Car, Rating) Values (@name, @surname, @car, @rating)";
                    cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("name", newDriverName.Text);
                    cmd.Parameters.AddWithValue("surname", newDriverSurname.Text);
                    cmd.Parameters.AddWithValue("car", result);
                    cmd.Parameters.AddWithValue("rating", 5);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                    newDriverName.Text = newDriverSurname.Text = newDriverBrand.Text = newDriverColor.Text =
                    newDriverNumber.Text = string.Empty;
                    LoadDrivers();
                }
            }
        }
    }
}
