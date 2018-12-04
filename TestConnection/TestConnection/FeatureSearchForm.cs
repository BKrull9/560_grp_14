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
            foreach(DataRow row in data.Tables[0].Rows)
            {

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
            List<string> list = new List<string>();
            list.Add("feature1");
            list.Add("feature2");
            list.Add("feature3");
            list.Add("feature4");
            list.Add("feature5");
            list.Add("feature6");
            list.Add("feature7");
            list.Add("feature8");
            list.Add("feature9");
            list.Add("feature10");
            list.Add("feature11");
            list.Add("feature12");
            list.Add("feature13");
            list.Add("feature14");
            list.Add("feature15");
            list.Add("feature16");
            list.Add("feature17");
            list.Add("feature18");
            list.Add("feature19");
            list.Add("feature20");
           // AddFeatures(list);
        }
    }
}
