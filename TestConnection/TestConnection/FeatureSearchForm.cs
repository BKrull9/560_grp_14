using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TestConnection
{
    public partial class FeatureSearchForm : Form
    {
        Home homePage;
        Group14Connection conn; 

        public FeatureSearchForm(Home ret)
        {
            InitializeComponent();
            homePage = ret;

            conn = new Group14Connection();
            List<Tuple<string, int>> features = GetFeatures();
            AddFeatures(features);
            GetCarsWithFeatures(null, null);
        }

        public List<Tuple<string, int>> GetFeatures()
        {
            List<Tuple<string, int>> list = new List<Tuple<string, int>>();
            DataSet data = conn.ListFeature();
            if( data != null )
            { 
                foreach( DataRow row in data.Tables[0].Rows )
                {
                    list.Add( new Tuple<string, int>( row.ItemArray[0].ToString(), Int32.Parse( row.ItemArray[1].ToString() ) ) );
                }
            }

            return list;
        }

        public void AddFeatures(List<Tuple<string, int>> feature_list)
        {
            uxFeatureTable.Controls.Clear();
            uxFeatureTable.ColumnCount = 0;
            int feature_count = 0;
            foreach( Tuple<string, int> feature in feature_list )
            {
                int modulo_feature = feature_count % 5;
                if(modulo_feature % 5 == 0 )
                {
                    uxFeatureTable.ColumnCount += 1;
                    uxFeatureTable.ColumnStyles[0].SizeType = SizeType.AutoSize;
                }
                CheckBox cb = new CheckBox();
                cb.Text = feature.Item1;
                cb.Name = "ux" + feature.Item1.Replace(" ", string.Empty) + feature.Item2.ToString();
                cb.CheckedChanged += GetCarsWithFeatures;
                uxFeatureTable.Controls.Add( cb, uxFeatureTable.ColumnCount - 1, modulo_feature );
                feature_count++;
            }
        }

        private void GetCarsWithFeatures(object sender, EventArgs e)
        {
            List<string> id_list = new List<string>();
            foreach (Control control in uxFeatureTable.Controls)
            {
                CheckBox cb = control as CheckBox;
                if (cb.Checked)
                {
                    string feature_id = Regex.Match(cb.Name, @"\d+").Value;
                    id_list.Add(feature_id);
                }
            }
            
            if (id_list.Count == 0)
            {
                id_list.Add("null");
            }

            DataSet data = conn.CarWithFeature(id_list); //conn.CarSearch("", "", "", null, null, null);
            PopulateDataGrid(data);
        }

        private void PopulateDataGrid(DataSet data)
        {
            uxDataGrid.Rows.Clear();
            uxDataGrid.Rows.Add();
            if (data != null)
            {
                DataTable table = data.Tables[0];
                foreach (DataRow data_row in table.Rows)
                {
                    DataGridViewRow new_row = (DataGridViewRow)uxDataGrid.Rows[0].Clone();
                    new_row.Cells[0].Value = data_row.ItemArray[0].ToString();
                    new_row.Cells[1].Value = data_row.ItemArray[1].ToString();
                    new_row.Cells[2].Value = data_row.ItemArray[2].ToString();
                    new_row.Cells[3].Value = data_row.ItemArray[3].ToString();
                    new_row.Cells[4].Value = Int32.Parse(data_row.ItemArray[4].ToString()).ToString("C", CultureInfo.CurrentCulture);
                    new_row.Cells[5].Value = data_row.ItemArray[5].ToString();
                    new_row.Cells[6].Value = data_row.ItemArray[6].ToString();
                    new_row.Cells[7].Value = data_row.ItemArray[7].ToString();
                    new_row.Cells[8].Value = data_row.ItemArray[8].ToString();
                    uxDataGrid.Rows.Add(new_row);
                }
                uxDataGrid.Rows.RemoveAt(0);
            }
        }

        private void FeatureSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void uxDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = uxDataGrid.SelectedRows.Count == 0 ? null : uxDataGrid.SelectedRows[0];
            if( row != null && row.Cells != null && row.Cells[0].Value != null )
            {
                uxMake.Text     = row.Cells[1].Value.ToString();
                uxModel.Text    = row.Cells[2].Value.ToString();
                uxYear.Text     = row.Cells[3].Value.ToString();
                uxAskPrice.Text = row.Cells[4].Value.ToString();
                uxColor.Text    = row.Cells[5].Value.ToString();
                uxMilage.Text   = row.Cells[6].Value.ToString();
                //DealershipId = row.Cells[7].Value.ToString();
                uxOwnerCount.Text = row.Cells[8].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakePurchase purch = new MakePurchase(homePage, Convert.ToInt32(uxDataGrid.SelectedRows[0].Cells[0].Value));
            purch.Show();
            this.Hide();
        }
    }
}
