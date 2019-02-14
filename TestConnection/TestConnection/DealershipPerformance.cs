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
            if (delership != 0 && checkDates())
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
            DataSet data = new DataSet();
            if (comboBox1.SelectedIndex == 0)
            {
                data = g14.DealershipPerformance2(dealershipId, start, end);
                if (data != null)
                {
                    foreach (DataRow r in data.Tables[0].Rows)
                    {
                        string[] arr = new string[5];
                        arr[0] = r.ItemArray[0].ToString();
                        arr[1] = r.ItemArray[1].ToString();
                        arr[2] = string.Format("{0:c}", Convert.ToInt32(r.ItemArray[2].ToString()));
                        arr[3] = r.ItemArray[3].ToString();
                        arr[4] = string.Format("{0:c}", Convert.ToInt32(r.ItemArray[4].ToString()));
                        dataGridView1.Rows.Add(arr);
                    }
                }
                else
                {
                    MessageBox.Show("There was an error proccessing your request.");
                    return;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                data = g14.DealershipPerformance(dealershipId, start, end);
                if (data != null)
                {
                    foreach (DataRow r in data.Tables[0].Rows)
                    {
                        string[] arr = new string[5];
                        arr[0] = r.ItemArray[0].ToString();
                        arr[1] = "NA";
                        arr[2] = string.Format("{0:c}", Convert.ToInt32(r.ItemArray[1].ToString()));
                        arr[3] = r.ItemArray[2].ToString();
                        arr[4] = string.Format("{0:c}", Convert.ToInt32(r.ItemArray[3].ToString()));
                        dataGridView1.Rows.Add(arr);
                    }
                }
                else
                {
                    MessageBox.Show("There was an error proccessing your request.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("There was an error proccessing your request.");
                return;
            }
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
