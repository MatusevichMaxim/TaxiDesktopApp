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
    public partial class FeedbackControl : UserControl
    {
        private int currentPage = 1;
        private int pageSize = 40;

        public FeedbackControl()
        {
            InitializeComponent();
            LoadFeedbackList();
        }

        private void LoadFeedbackList()
        {
            feedbackDG.DataSource = GetReportsList();
        }

        private DataTable GetReportsList()
        {
            var dtFeedback = new DataTable();

            using (var connection = new SqlConnection(Constants.Instance.DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Feedback";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var reader = cmd.ExecuteReader();

                    dtFeedback.Load(reader);
                    return dtFeedback;
                }
                catch (SqlException ex)
                { return null; }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void printImage_Click(object sender, EventArgs e)
        {
            var dialog = new PrintPreviewDialog();
            dialog.Document = printDocument1;
            dialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bmp = new Bitmap(feedbackDG.Width, feedbackDG.Height);
            feedbackDG.DrawToBitmap(bmp, new Rectangle(0, 0, feedbackDG.Width * 2, feedbackDG.Height * 2));

            e.Graphics.DrawImage(bmp, 50, 90);
        }
    }
}
