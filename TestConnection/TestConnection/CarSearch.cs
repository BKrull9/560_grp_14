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
        public CarSearch(Home ret)
        {
            homePage = ret;
            InitializeComponent();
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
            Group14Connection g14 = new Group14Connection();
            var data = g14.CarSearch(make, model, color, milage2, oc2, ap2);
            var table = data.Tables[0];

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
                label7.Text = "Make: " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                label8.Text = "Model: " + dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                label9.Text = "Color: " + dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                label10.Text = "Year: " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label11.Text = "Milage: " + dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                label12.Text = "Owner Count: " + dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                label13.Text = "Ask Price: " + dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                Group14Connection g14 = new Group14Connection();
                int num = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var data = g14.GetCarFeatures(num);
                string features = "";
                if (data.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                    {
                        features += data.Tables[0].Rows[i].ItemArray[0] + "\n";
                    }
                }
                else
                {
                    features = "NA";
                }
                label14.Text = "Features: " + features;
            }
            catch
            {

            }

        }
    }
}
