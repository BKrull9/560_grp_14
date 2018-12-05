using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnection
{
    public partial class EmployeePerformance : Form
    {
        Home returnScreen;
        public EmployeePerformance(Home ret)
        {
            returnScreen = ret;
            uxTimeLine.SelectedIndex = 1;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnScreen.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
            if (uxEmployeeId.Text.Length > 0)
            {

            }
            else
            {

            }
            uxEmployeeId.Text = "";
            uxFirstName.Text = "";
            uxLastName.Text = "";
        }
    }
}
