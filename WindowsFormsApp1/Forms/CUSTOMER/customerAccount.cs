using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Forms
{
    public partial class customerAccount : Form
    {
        private object firstnamehome;

        public  customerAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerHome customerHome = new customerHome();
            this.Visible = false;//closing the form
            customerHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            label1.Text = "" + char.ToUpper(frm_login.firstnameHome[0]) + frm_login.firstnameHome.Substring(1); //LABEL FIRSTNAME
            label2.Text = "" + char.ToUpper(frm_login.lastnameHome[0]) + frm_login.lastnameHome.Substring(1);   //LABEL LASTNAME

            string query = "SELECT * FROM Customer WHERE Customer.Customer_FirstName = '" +frm_login.firstnameHome+"'";


            OleDbCommand cmd = new OleDbCommand(query, Repository.Connection.conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridProducts.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
                }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            this.Visible = false;//closing the form
            manageProducts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageAccountsAdmin manageAccountsAdmin = new ManageAccountsAdmin();
            this.Visible = false;//closing the form
            manageAccountsAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageAccountsSupplier manageAccountsSupplier = new ManageAccountsSupplier();
            this.Visible = false;//closing the form
            manageAccountsSupplier.Show();
        }

    }
}
