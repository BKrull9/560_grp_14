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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //get customer information button click
        private void button1_Click(object sender, EventArgs e)
        {
            GetCustomerInformation GCI = new GetCustomerInformation(this);
            GCI.Show();
            this.Hide();
        }        

        //Car search button click
        private void uxCarSearch_Click(object sender, EventArgs e)
        {
            CarSearch CS = new CarSearch(this);
            CS.Show();
            this.Hide();
        }

        // Get car with features button click
        private void uxCarWithFeat_Click(object sender, EventArgs e)
        {
            FeatureSearchForm feature_search_form = new FeatureSearchForm(this);
            feature_search_form.Show();
            this.Hide();
        }

        // list employees button click
        private void uxListEmployees_Click(object sender, EventArgs e)
        {
            ListEmployeesForm LES = new ListEmployeesForm(this);
            LES.Show();
            this.Hide();

        }

        // get employees button click
        private void uxGetEmployees_Click(object sender, EventArgs e)
        {

        }

        // employee performance button click
        private void uxEmployeePerf_Click(object sender, EventArgs e)
        {
            EmployeePerformance EP = new EmployeePerformance(this);
            EP.Show();
            this.Hide();
        }

        // get top employees button click
        private void uxGetTopEmployees_Click(object sender, EventArgs e)
        {
            GetTopEmployees gte = new GetTopEmployees(this);
            gte.Show();
            this.Hide();
        }
        // get stock total value 
        private void uxGetStockTotal_Click(object sender, EventArgs e)
        {

        }

        // deqalership performance button click
        private void uxDealershipPerf_Click(object sender, EventArgs e)
        {
            DealershipPerformance dp = new DealershipPerformance(this);
            dp.Show();
            this.Hide();
        }
    }
}
