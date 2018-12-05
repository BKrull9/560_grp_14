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
    public partial class GetTopEmployees : Form
    {
        Form homePage;
        public GetTopEmployees(Form ret)
        {
            homePage = ret;
            InitializeComponent();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            homePage.Show();
            this.Hide();
        }

        private void usSearch_Click(object sender, EventArgs e)
        {
            int numTop;
            if(Int32.TryParse(uxNum.Text, out numTop))
            {

            }
            else
            {

            }
        }
        private int findSelectedRadio()
        {
            if (uxNorth.Checked)
            {
                return 2;
            }
            else if (uxCentral.Checked)
            {
                return 7;
            }
            else if (uxEast.Checked)
            {
                return 3;
            }
            else if (uxNorthWest.Checked)
            {
                return 5;
            }
            else if (uxSouth.Checked)
            {
                return 4;
            }
            else if (uxSouthEast.Checked)
            {
                return 6;
            }
            else if (uxWest.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
