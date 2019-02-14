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
    public partial class GetTopCustomers : Form
    {
        Form homePage;
        public GetTopCustomers(Form ret)
        {
            homePage = ret;
            InitializeComponent();
            dataGridView1.Columns.Add("CustomerId", "CustomerId");
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns.Add("E.Email", "E.Email");
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns.Add("City", "City");
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns.Add("NumberSales", "NumberSales");
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns.Add("SalesVolume", "SalesVolume");
            dataGridView1.Columns[7].Visible = false;
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void usSearch_Click(object sender, EventArgs e)
        {
            int numTop;
            int dealership = findSelectedRadio();
            if (Int32.TryParse(uxNum.Text, out numTop) && dealership != 0)
            {
                runQuery(numTop, dealership);
            }
            else
            {
                MessageBox.Show("There was an error proccessing your request.");
            }
        }

        private void runQuery(int numCustomers, int dealershipId)
        {
            Group14Connection conn = new Group14Connection();
            DataSet data = conn.GetTopCustomers(dealershipId, numCustomers);
            if (data != null)
            {
                DataTable table = data.Tables[0];
                displayResults(table);
            } else
            {
                MessageBox.Show("There was an error proccessing your request");
            }
        }

        private void displayResults(DataTable table)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                object[] currentRow = table.Rows[i].ItemArray;
                List<string> listToUse = new List<string>();
                foreach (object o in currentRow)
                {
                    listToUse.Add(o.ToString());
                }
                dataGridView1.Rows.Add(listToUse.ToArray());
            }
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0] : null;
            if (row != null)
            {
                uxEmplyeeId.Text = "Customer Id: " + row.Cells[3].Value.ToString();
                uxfName.Text = "First Name: " + row.Cells[1].Value.ToString();
                uxlNAme.Text = "Last Name: " + row.Cells[2].Value.ToString();
                uxEmail.Text = "Email: " + row.Cells[4].Value.ToString();
                uxCity.Text = "City: " + row.Cells[5].Value.ToString();
                uxSSaleNum.Text = "Sales Volume: " + row.Cells[7].Value.ToString();
            }
        }
        
    }
}
