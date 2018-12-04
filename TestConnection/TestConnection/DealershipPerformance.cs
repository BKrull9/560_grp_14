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
    public partial class DealershipPerformance : Form
    {
        Form homePage;
        public DealershipPerformance(Form ret)
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
            int delership = findSelectedRadio();
        }

        public int findSelectedRadio()
        {
            if(uxNorth.Checked)
            {

            }
            return 0;
        }
    }
}
