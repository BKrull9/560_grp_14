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

namespace TestConnection
{
    public partial class FeatureSearchForm : Form
    {
        Home homePage;

        public FeatureSearchForm(Home ret)
        {
            InitializeComponent();
            homePage = ret;
        }

        public List<string> GetFeatures()
        {
            List<string> list = new List<string>();

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
            List<int> id_list = new List<int>();
            foreach( Control cb in uxFeatureTable.Controls )
            {
                int feature_id = Int32.Parse( cb.Name.Substring(cb.Name.Length - 1) );
                id_list.Add(feature_id);
            }
            Group14Connection conn = new Group14Connection();
            DataSet data = conn.CarWithFeature( id_list );
            PopulateDataGrid(data);
        }

        private void PopulateDataGrid(DataSet data)
        {
            DataTable table = data.Tables[0];
            DataRow row1 = data.Tables[0].Rows[0];
            for (int i = 1; i < row.ItemArray.Length; i++)
            {
                if (i != 0)
                {
                    dataGridView1.Columns.Add(table.Columns[i].ColumnName, table.Columns[i].ColumnName);
                    rowData.Add(row[i].ToString());
                }

            }
            for(int i = 0; i < table.Columns.Count; i++)
            {
                dataGridView1.Columns.Add(table.Columns[i].ColumnName, table.Columns[i].ColumnName);
            }
            dataGridView1.Rows.Add(rowData.ToArray());
            foreach (DataRow row in data.Tables[0].Rows)
            {
                List<string> rowData = new List<string>();
                for(int i = 1; i < row.ItemArray.Count; i++)
                {

                }
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

        private void uxTestBtn_Click(object sender, EventArgs e)
        {
            List<Tuple<string, int>> list = new List<Tuple<string, int>>();
            list.Add(new Tuple<String, int>("feature1", 1));
            list.Add(new Tuple<String, int>("feature2", 2));
            list.Add(new Tuple<String, int>("feature3", 3));
            list.Add(new Tuple<String, int>("feature4", 4));
            list.Add(new Tuple<String, int>("feature5", 5));
            list.Add(new Tuple<String, int>("feature6", 6));
            list.Add(new Tuple<String, int>("feature7", 7));
            list.Add(new Tuple<String, int>("feature8", 8));
            list.Add(new Tuple<String, int>("feature9", 9));
            list.Add(new Tuple<String, int>("feature10", 10));
            list.Add(new Tuple<String, int>("feature11", 11));
            list.Add(new Tuple<String, int>("feature12", 12));
            list.Add(new Tuple<String, int>("feature13", 13));
            list.Add(new Tuple<String, int>("feature14", 14));
            list.Add(new Tuple<String, int>("feature15", 15));
            list.Add(new Tuple<String, int>("feature16", 16));
            list.Add(new Tuple<String, int>("feature17", 17));
            list.Add(new Tuple<String, int>("feature18", 18));
            list.Add(new Tuple<String, int>("feature19", 19));
            list.Add(new Tuple<String, int>("feature20", 20));
            //AddFeatures(list);
        }
    }
}
