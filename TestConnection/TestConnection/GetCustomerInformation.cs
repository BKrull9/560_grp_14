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
    public partial class GetCustomerInformation : Form
    {
        Home homePage;

        public GetCustomerInformation(Home ret)
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
            int num = 0;
            if(textBox1.Text.Length > 0 && Int32.TryParse(textBox1.Text, out num))
            {
               
               int customerId = Convert.ToInt32(textBox1.Text);
               displayData(customerId);
                
            }
            else
            {
                MessageBox.Show("You must insert an integer value into the customer id field.");
            }
        }

        private void displayData(int customerId)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                Group14Connection g14 = new Group14Connection();
                var data = g14.GetCustomerInformation(customerId);
                var table = data.Tables[0];
                var row = table.Rows[0];
                List<string> rowData = new List<string>();
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    if (i != 0)
                    {
                        dataGridView1.Columns.Add(table.Columns[i].ColumnName, table.Columns[i].ColumnName);
                        rowData.Add(row[i].ToString());
                    }
                }
                dataGridView1.Rows.Add(rowData.ToArray());
            }
            catch
            {
                MessageBox.Show("This employee does not exist.");
                textBox1.Text = "";
            }
        }

        // do not use
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetCustomerInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
