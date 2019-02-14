using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnection
{
    public partial class ListEmployeesForm : Form
    {
        Group14Connection conn;
        Home homePage;
        public ListEmployeesForm(Home ret)
        {
            conn = new Group14Connection();
            homePage = ret;
            InitializeComponent();
        }

        private void uxEmployeeSearchButton_Click(object sender, EventArgs e)
        {
            Nullable<int> employee_id = null;
            int temp;
            if (Int32.TryParse(uxTxtEmployeeId.Text, out temp))
            {
                employee_id = temp;
            }
            DataSet data = conn.ListEmployee(employee_id, firstNameText.Text, lastNameText.Text);
            displayData(data);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void displayData(DataSet data)
        {
            if( data != null )
            {
                DataTable table = data.Tables[0];
                dataGridView1.Rows.Clear();

                dataGridView1.Rows.Add();
                foreach (DataRow data_row in data.Tables[0].Rows)
                {
                    DataGridViewRow new_row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    new_row.Cells[0].Value = data_row.ItemArray[0].ToString();
                    new_row.Cells[1].Value = data_row.ItemArray[1].ToString();
                    new_row.Cells[2].Value = data_row.ItemArray[2].ToString();
                    new_row.Cells[3].Value = data_row.ItemArray[3].ToString();
                    new_row.Cells[4].Value = data_row.ItemArray[4].ToString();
                    new_row.Cells[5].Value = data_row.ItemArray[5].ToString();
                    new_row.Cells[6].Value = data_row.ItemArray[6].ToString();
                    new_row.Cells[7].Value = data_row.ItemArray[7].ToString();
                    new_row.Cells[8].Value = data_row.ItemArray[8].ToString();
                    new_row.Cells[9].Value = data_row.ItemArray[9].ToString();
                    new_row.Cells[10].Value = data_row.ItemArray[10].ToString();
                    new_row.Cells[11].Value = data_row.ItemArray[11].ToString();
                    dataGridView1.Rows.Add(new_row);
                }
                dataGridView1.Rows.RemoveAt(0);
            }
            else
            {
                MessageBox.Show( "Employee does not exist." );
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows.Count == 0 ? null : dataGridView1.SelectedRows[0];
            if (row != null && row.Cells != null && row.Cells[0].Value != null)
            {
                employeeId.Text         = row.Cells[0].Value.ToString();
                //First name = row.Cells[1].Value.ToString();
                //Last Name = row.Cells[2].Value.ToString();
                PhoneLabel.Text         = row.Cells[3].Value.ToString();
                EmailLabel.Text         = row.Cells[4].Value.ToString();
                DealershipName.Text     = row.Cells[5].Value.ToString();
                StreetAddress.Text      = row.Cells[6].Value.ToString();
                StreetAddress2.Text     = row.Cells[7].Value.ToString();
                CityLabel.Text          = row.Cells[8].Value.ToString();
                ZipCodeLabel.Text       = row.Cells[9].Value.ToString();
                NumberOfSalesLabel.Text = row.Cells[10].Value.ToString();
                TotalSalesLabel.Text    = Int32.Parse( row.Cells[11].Value.ToString() ).ToString( "C", CultureInfo.CurrentCulture );
            }
        }

        private void ListEmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
