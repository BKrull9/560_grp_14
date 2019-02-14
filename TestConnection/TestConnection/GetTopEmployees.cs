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
    public partial class GetTopEmployees : Form
    {
        Form homePage;
        public GetTopEmployees(Form ret)
        {
            homePage = ret;
            InitializeComponent();
            dataGridView1.Columns.Add("EmployeeId", "EmployeeId");
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
            homePage.Show();
            this.Hide();
        }

        private void usSearch_Click(object sender, EventArgs e)
        {
            int numTop;
            int dealership = findSelectedRadio();
            if(Int32.TryParse(uxNum.Text, out numTop) && dealership != 0)
            {
                displayData(numTop, dealership);
            }
            else
            {
                MessageBox.Show("There was an error proccessing your request.");
            }
        }

        private void displayData(int top, int deal)
        {
            dataGridView1.Rows.Clear();
            Group14Connection g14 = new Group14Connection();
            var data = g14.GetTopEmployees(top, deal);
            if (data == null)
            {
                MessageBox.Show("There was an error proccessing your request.");
                return;
            }
            var table = data.Tables[0];
            for(int i = 0; i < table.Rows.Count; i++)
            {
                object[] currentRow = table.Rows[i].ItemArray;
                List<string> listToUse = new List<string>();
                foreach(object o in currentRow)
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                uxEmplyeeId.Text = "Employee Id: " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                uxfName.Text = "First Name: " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                uxlNAme.Text = "Last Name: " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                uxEmail.Text = "Email: " + dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                uxCity.Text = "City: " + dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                uxSSaleNum.Text = "Number of Sales: " + dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                uxVolume.Text = "Sales Volume: " + string.Format("{0:c}", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()));
            }
        }

        private void GetTopEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
