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
            int num = 0;
            if (textBox1.Text.Length > 0 && Int32.TryParse(textBox1.Text, out num))
            {
                int dealershipId = Convert.ToInt32(textBox1.Text);
                displayData(dealershipId);
            }
            else
            {
                MessageBox.Show("You must insert an integer value between 1 and 7 into the dealership id field.");
            }
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void displayData(int dealershipId)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            Group14Connection g14 = new Group14Connection();
            var data = g14.ListEmployee(dealershipId);
            var table = data.Tables[0];
           

            for (int i = 0; i < table.Rows[0].ItemArray.Length; i++)
            {
                dataGridView1.Columns.Add(table.Columns[i].ColumnName, table.Columns[i].ColumnName);
                

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
    }
}
