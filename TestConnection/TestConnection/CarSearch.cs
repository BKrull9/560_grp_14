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
    public partial class CarSearch : Form
    {
        Home homePage;
        public CarSearch(Home ret)
        {
            homePage = ret;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            string make = uxMake.Text;
            string model = uxModel.Text;
            string year = uxYear.Text;
            string color = uxColor.Text;
            string milage = uxMilage.Text;
            string oc = uxOwnerCount.Text;
            string ap = uxAskPrice.Text;

        }
    }
}
