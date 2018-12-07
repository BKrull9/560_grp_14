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
        private int carLocationId;
        private int employeeLocationId;
        public CarSearch(Home ret)
        {
            homePage = ret;
            carLocationId = -1;
            employeeLocationId = -1;
            InitializeComponent();
            updatePurchaseAvailability();
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
            displayResults(make, model, year, color, milage, oc, ap);
        }

        private void displayResults(string make, string model, string year, string color, string milage, string oc, string ap)
        {
            
            int num;
            Nullable<int> milage2 = null;
            Nullable<int> oc2 = null;
            Nullable<int> ap2 = null;
            Nullable<int> year2 = null;
            if(Int32.TryParse(milage, out num))
            {
                milage2 = Convert.ToInt32(milage);
            }
            if(Int32.TryParse(oc, out num))
            {
                oc2 = Convert.ToInt32(oc);
            }
            if(Int32.TryParse(ap, out num))
            {
                ap2 = Convert.ToInt32(ap);
            }
            if (Int32.TryParse(year, out num))
            {
                year2 = Convert.ToInt32(year);
            }
            Group14Connection g14 = new Group14Connection();
            var data = g14.CarSearch(make, model, color, milage2, oc2, ap2, year2);
            if (data == null)
            {
                MessageBox.Show("There was an error proccessing your request.");
                return;
            }
            var table = data.Tables[0];
            if (table.Rows.Count > 0)
            {
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                }
                for (int j = 0; j < table.Rows[0].ItemArray.Length; j++)
                {
                    dataGridView1.Columns.Add(table.Columns[j].ColumnName, table.Columns[j].ColumnName);
                    if (j != 2 && j != 3 && j != 4)
                    {
                        dataGridView1.Columns[j].Visible = false;
                    }
                }


                for (int i = 0; i < table.Rows.Count; i++)
                {
                    List<string> rowData = new List<string>();
                    var row = table.Rows[i];
                    for (int j = 0; j < table.Rows[0].ItemArray.Length; j++)
                    {
                        rowData.Add(row[j].ToString());
                    }
                    string[] arr = rowData.ToArray();
                    string hold = arr[0];
                    dataGridView1.Rows.Add(arr);
                }
            }
            else
            {
                MessageBox.Show("There was an error proccessing your request.");
            }

            
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                label7.Text = "Make: " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                label8.Text = "Model: " + dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                label9.Text = "Color: " + dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                label10.Text = "Year: " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label11.Text = "Milage: " + dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                label12.Text = "Owner Count: " + dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                label13.Text = "Ask Price: " + dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

                Group14Connection g14 = new Group14Connection();

                int carId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var carData = g14.GetCarFeatures(carId);
                string features = "";
                if (carData != null && carData.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < carData.Tables[0].Rows.Count; i++)
                    {
                        features += carData.Tables[0].Rows[i].ItemArray[0] + "\n";
                    }
                }
                else
                {
                    features = "NA";
                }
                label14.Text = "Features: " + features;

                int dealershipId;
                bool success = Int32.TryParse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), out dealershipId);
                if (!success)
                {
                    dealershipId = -1;
                }
                carLocationId = dealershipId;
                var dealershipData = g14.GetDealershipInformation(dealershipId);
                string dealershipName = dealershipData.Tables[0].Rows[0].ItemArray[1].ToString();
                label15.Text = "Location: " + dealershipName;

                updatePurchaseAvailability();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakePurchase purch = new MakePurchase(homePage, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            purch.Show();
            this.Hide();
        }

        private void CarSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uxEmployeeEmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            string employeeEmail = uxEmployeeEmailTxtBox.Text;
            int dealershipId;
            Group14Connection g14 = new Group14Connection();
            var employeeData = g14.GetEmployeeFromEmail(employeeEmail);
            if(employeeData == null)
            {
                dealershipId = -1;
            }
            else
            {
                bool success = Int32.TryParse(employeeData.Tables[0].Rows[0].ItemArray[2].ToString(), out dealershipId);
                if (!success)
                {
                    dealershipId = -1;
                }
            }
            
            employeeLocationId = dealershipId;

            string dealershipName = "";
            var dealershipData = g14.GetDealershipInformation(dealershipId);
            if(dealershipData != null)
            {
                dealershipName = dealershipData.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            uxEmployeeLocationLbl.Text = "Employee Location: " + dealershipName;

            updatePurchaseAvailability();
        }

        private void updatePurchaseAvailability()
        {
            if((carLocationId == employeeLocationId) &&
                (carLocationId != -1 && employeeLocationId != -1))
            {
                uxPurchase.Enabled = true;
            }
            else
            {
                uxPurchase.Enabled = false;
            }
        }
    }
}
