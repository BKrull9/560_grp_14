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
    public partial class MakePurchase : Form
    {
        Form returnScreen;
        int carID;
        public MakePurchase(Form ret, int cID)
        {
            returnScreen = ret;
            carID = cID;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            returnScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            string customerEmail = textBox1.Text;
            string employeeEmail = textBox2.Text;
            if(Int32.TryParse(textBox3.Text, out num))
            {
                int purchaseAmount = Convert.ToInt32(textBox3.Text);
                makePurchase(customerEmail, employeeEmail, purchaseAmount);
            }
            else
            {
                MessageBox.Show("There was an error proccessing your request.");
            }
        }

        public void makePurchase(string ce, string ee, int amount)
        {
            Group14Connection g14 = new Group14Connection();
            var data = g14.MakePurchase(ee, ce, carID, amount);
            try
            {
                if (Convert.ToInt32(data.Tables[0].Rows[0].ItemArray[0].ToString()) == carID)
                {
                    this.Hide();
                    returnScreen.Show();
                    MessageBox.Show("Purchase has been logged.");
                }
                else
                {
                    MessageBox.Show("There was an error proccessing your request.");
                }
            }
            catch
            {
                MessageBox.Show("There was an error proccessing your request.");
            }

        }

        private void MakePurchase_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }
}
