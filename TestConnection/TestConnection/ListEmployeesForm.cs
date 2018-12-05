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
    public partial class ListEmployeesForm : Form
    {
        Home homePage;
        public ListEmployeesForm(Home ret)
        {
            homePage = ret;
            InitializeComponent();
        }

        private void uxEmployeeSearchButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            displayData(firstName, lastName);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void displayData(string firstName, string lastName)
        {
            Group14Connection g14 = new Group14Connection();
            var data = g14.ListEmployee(firstName, lastName);
            var table = data.Tables[0];

            if(dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
           

            for (int i = 0; i < table.Rows[0].ItemArray.Length; i++)
            {
                dataGridView1.Columns.Add(table.Columns[i].ColumnName, table.Columns[i].ColumnName);
                if(i != 0 && i !=1 && i != 2)
                {
                    dataGridView1.Columns[i].Visible = false;
                }

            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                List<string> rowData = new List<string>();
                var row = table.Rows[i];
                for(int j = 0; j < table.Rows[0].ItemArray.Length; j++)
                {
                    rowData.Add(row[j].ToString());
                }
                string[] arr = rowData.ToArray();
                string hold = arr[0];
                dataGridView1.Rows.Add(arr);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                employeeId.Text = "Employee ID: " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                PhoneLabel.Text = "Phone Number: " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                EmailLabel.Text = "Email: " + dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                DealershipName.Text = "Dealership: " + dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                StreetAddress.Text = "Street: " + dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                CityLabel.Text = "City: " + dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                ZipCodeLabel.Text = "Zip Code: " + dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                NumberOfSalesLabel.Text = "Number of Sales: " + dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                TotalSalesLabel.Text = "Total Sales: " + dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
