﻿using System;
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

        // get car features button click
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Car search button click
        private void uxCarSearch_Click(object sender, EventArgs e)
        {

        }

        //car informationm button click
        private void uxCarInfo_Click(object sender, EventArgs e)
        {

        }

        // Get car with features button click
        private void uxCarWithFeat_Click(object sender, EventArgs e)
        {

        }

        // list employees button click
        private void uxListEmployees_Click(object sender, EventArgs e)
        {

        }

        // get employees button click
        private void uxGetEmployees_Click(object sender, EventArgs e)
        {

        }

        // employee performance button click
        private void uxEmployeePerf_Click(object sender, EventArgs e)
        {

        }

        // get top employees button click
        private void uxGetTopEmployees_Click(object sender, EventArgs e)
        {

        }

        // get stock total value 
        private void uxGetStockTotal_Click(object sender, EventArgs e)
        {

        }

        // deqalership performance button click
        private void uxDealershipPerf_Click(object sender, EventArgs e)
        {

        }
    }
}