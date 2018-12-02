using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace TestConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn_str;
            SqlConnection conn;

            conn_str = @"Server=mssql.cs.ksu.edu;Database=cis560_team14;Integrated Security=SSPI;";

            conn = new SqlConnection(conn_str);
            conn.Open();

            SqlCommand cmd;
            SqlDataReader data_reader;
            string sql, output = "";

            sql = "SELECT CarId FROM Demo.Car";
            cmd = new SqlCommand(sql, conn);
            data_reader = cmd.ExecuteReader();

            while (data_reader.Read())
            {
                output += data_reader.GetValue(0) + "\n";
            }

            MessageBox.Show(output);

            conn.Close();
        }
    }
}
