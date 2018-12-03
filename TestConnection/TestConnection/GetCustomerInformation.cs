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
    public partial class GetCustomerInformation : Form
    {
        Home homePage;

        public GetCustomerInformation(Home ret)
        {
            homePage = ret;
            InitializeComponent();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                try
                {
                    int customerId = Convert.ToInt32(textBox1.Text);
                    displayData(customerId);
                }
                catch
                {
                    MessageBox.Show("You must insert an integer value into the customer id field.");
                }
            }
            else
            {
                MessageBox.Show("You must insert an integer value into the customer id field.");
            }
        }

        private void displayData(int customerId)
        {
            //MakeDataCallandDisplayData
        }
    }
}
