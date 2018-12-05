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
            if(delership != 0 && checkDates())
            {
                displayData(delership, dateTimePicker1.Value, dateTimePicker2.Value);
            }
            else
            {
                MessageBox.Show("There was an error proccessing your request.");
            }
        }

        private void displayData(int dealershipId, DateTimeOffset start, DateTimeOffset end)
        {
            dataGridView1.Rows.Clear();
            Group14Connection g14 = new Group14Connection();
            var data = g14.DealershipPerformance(dealershipId, start, end);
            if(data == null)
            {
                MessageBox.Show("There was an error proccessing your request.");
                return;
            }
            var row = data.Tables[0].Rows[0].ItemArray;
            string[] arr = new string[3];
            arr[0] = string.Format("{0:c}", Convert.ToInt32(row[4]));
            arr[1] = row[5].ToString();
            arr[2] = string.Format("{0:c}", Convert.ToInt32(row[6]));
            dataGridView1.Rows.Add(arr);
        }

        private bool checkDates()
        {
            return (dateTimePicker1.Value < dateTimePicker2.Value);
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
