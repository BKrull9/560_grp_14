using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnection
{
    public partial class GetCustomerInformation : Form
    {
        Home homePage;
        Group14Connection conn;
        //TODO: Add first/last name options to search with
        public GetCustomerInformation(Home ret)
        {
            homePage = ret;
            InitializeComponent();
            conn = new Group14Connection();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage.Show();
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {            
            Nullable<int> customer_id = null;
            int temp;
            if( Int32.TryParse(uxTxtCustomerId.Text, out temp ) )
            {
                customer_id = temp;
            }
            
            displayData( customer_id, uxTxtFistName.Text, uxTxtLastName.Text );
        }

        private void displayData(int? customerId, string first, string last)
        {
            uxDataGrid.Rows.Clear();
            var data = conn.GetCustomerInformation( customerId, first, last );
            var table = data.Tables[0];
            if( table.Rows.Count > 0 )
            {
                uxDataGrid.Rows.Add();
                foreach ( DataRow data_row in table.Rows )
                {
                    DataGridViewRow new_row = (DataGridViewRow)uxDataGrid.Rows[0].Clone();
                    new_row.Cells[0].Value = data_row.ItemArray[0].ToString();
                    new_row.Cells[1].Value = data_row.ItemArray[1].ToString();
                    new_row.Cells[2].Value = data_row.ItemArray[2].ToString();
                    new_row.Cells[3].Value = data_row.ItemArray[3].ToString();
                    new_row.Cells[4].Value = data_row.ItemArray[4].ToString();
                    new_row.Cells[5].Value = data_row.ItemArray[5].ToString();
                    new_row.Cells[6].Value = data_row.ItemArray[6].ToString();
                    new_row.Cells[7].Value = data_row.ItemArray[7].ToString();
                    new_row.Cells[8].Value = data_row.ItemArray[8].ToString();
                    uxDataGrid.Rows.Add(new_row);
                }
                uxDataGrid.Rows.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("This employee does not exist.");
                uxTxtCustomerId.Text = "";
                uxTxtFistName.Text = "";
                uxTxtLastName.Text = "";
            }
        }

        private void GetCustomerInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uxDataGird_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = uxDataGrid.SelectedRows.Count == 0 ? null : uxDataGrid.SelectedRows[0];
            if( row != null && row.Cells != null && row.Cells[0].Value != null )
            {
                uxCustomerId.Text   = row.Cells[0].Value.ToString();
                uxPhoneNumber.Text  = row.Cells[1].Value.ToString();
                uxEmail.Text        = row.Cells[2].Value.ToString();
                //First Name = row.Cells[3].Value.ToString();
                //Last Name = row.Cells[4].Value.ToString();
                uxStreet.Text       = row.Cells[5].Value.ToString();
                uxStreet2.Text      = row.Cells[6].Value.ToString();
                uxCity.Text         = row.Cells[7].Value.ToString();
                uxZipcode.Text      = row.Cells[8].Value.ToString();
            

                DataSet data = conn.GetCustomerPurchase( Int32.Parse(row.Cells[0].Value.ToString() ) );
                DataTable table = data.Tables[0];
                if( table.Rows.Count > 0 )
                {
                    DataRow data_row = table.Rows[0];
                    uxNumPurchase.Text = data_row.ItemArray[0].ToString();
                    uxPurchaseAmount.Text = Int32.Parse( data_row.ItemArray[1].ToString() ).ToString( "C", CultureInfo.CurrentCulture);
                }
                else
                {
                    uxNumPurchase.Text = "N/A";
                    uxPurchaseAmount.Text = "N/A";
                }
            }
        }
    }
}
