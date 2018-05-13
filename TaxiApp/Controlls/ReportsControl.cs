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
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
            LoadTripReports();
        }

        private void LoadTripReports()
        {
            tripReportDG.DataSource = GetReportsList();
        }

        private DataTable GetReportsList()
        {
            var dtReports = new DataTable();

            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From TripReport";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var reader = cmd.ExecuteReader();

                    dtReports.Load(reader);
                    return dtReports;
                }
                catch (SqlException ex)
                { return null; }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
