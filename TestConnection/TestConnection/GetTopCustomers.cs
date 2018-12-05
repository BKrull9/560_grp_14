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
    public partial class GetTopCustomers : Form
    {
        Form homePage;
        public GetTopCustomers(Form ret)
        {
            homePage = ret;
            InitializeComponent();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void usSearch_Click(object sender, EventArgs e)
        {

            runQuery();
        }

        private void runQuery()
        {
            displayResults();
        }

        private void displayResults()
        {

        }
    }
}
