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
    public partial class ReviewsControl : UserControl
    {
        public ReviewsControl()
        {
            InitializeComponent();

            LoadReviews();
        }

        private void LoadReviews()
        {
            reviewsDG.DataSource = GetReviewList();
        }

        private DataTable GetReviewList()
        {
            var dtReview = new DataTable();

            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From ClientsReview";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var reader = cmd.ExecuteReader();

                    dtReview.Load(reader);
                    return dtReview;
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
