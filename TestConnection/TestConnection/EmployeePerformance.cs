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
    public partial class EmployeePerformance : Form
    {
        Home returnScreen;
        Group14Connection conn;
        public EmployeePerformance(Home ret)
        {
            returnScreen = ret;
            InitializeComponent();
            conn = new Group14Connection();
            uxTimeLine.SelectedIndex = 0;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnScreen.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int employee_id = 0;
            int temp;
            if (Int32.TryParse(uxEmployeeId.Text, out temp))
            {
                employee_id = temp;
            }
            displayData(employee_id, uxStartDate.Value, uxEndDate.Value);
        }
        private void displayData(int employeeId, DateTime StartDate, DateTime EndDate)
        {
            uxDataGrid.Rows.Clear();
            uxDataGrid.Columns.Clear();
            DataSet data;
            if (uxTimeLine.SelectedIndex == 1)
            {
                data = conn.GetYearlyEmployeePerformance(employeeId, StartDate, EndDate);
            }
            else
            {
                data = conn.GetMonthlyEmployeePerformance(employeeId, StartDate, EndDate);
            }
            if (data != null)
            {
                foreach( DataColumn data_row in data.Tables[0].Columns)
                {
                    if(data_row.ColumnName != "EmployeeId" && data_row.ColumnName != "FirstName" && data_row.ColumnName != "LastName")
                    {
                        uxDataGrid.Columns.Add(data_row.ColumnName, data_row.ColumnName);
                    }
                }
                uxDataGrid.Rows.Add();
                DataRow temp = data.Tables[0].Rows[0];
                foreach (DataRow data_row in data.Tables[0].Rows)
                {
                    DataGridViewRow new_row = (DataGridViewRow)uxDataGrid.Rows[0].Clone();
                    for(int i = 0; i < new_row.Cells.Count; i++)
                    {
                        new_row.Cells[i].Value = data_row.ItemArray[i+3].ToString();
                    }
                    uxDataGrid.Rows.Add(new_row);
                }
                uxEmployeeId.Text = temp.ItemArray[2].ToString();
                uxFirstName.Text = "First Name: " + temp.ItemArray[0].ToString();
                uxLastName.Text = "Last Name: " + temp.ItemArray[1].ToString();
                uxDataGrid.Rows.RemoveAt(0);

            }
            else
            {
                MessageBox.Show("This employee does not exist.");
                uxEmployeeId.Text = "";
            }
        }

        private void EmployeePerformance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
