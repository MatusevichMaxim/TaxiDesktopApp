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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            tabPointer.Height = HomeTab.Height;
            tabPointer.Top = HomeTab.Top;
            homeControl.BringToFront();
        }

        private void HomeTab_Click(object sender, EventArgs e)
        {
            tabPointer.Height = HomeTab.Height;
            tabPointer.Top = HomeTab.Top;
            homeControl.BringToFront();
        }

        private void ReportsTab_Click(object sender, EventArgs e)
        {
            tabPointer.Height = ReportsTab.Height;
            tabPointer.Top = ReportsTab.Top;
            reportsControl.BringToFront();
        }
    }
}
