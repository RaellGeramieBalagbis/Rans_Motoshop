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
    public partial class ManageAccounts : Form
    {
        public static string setAccountID;
        public static string setUserName;
        public static string setPassword;
        public static string setFirstName;
        public static string setLastName;
        public static string setContactNumber;
        public static string setStreetName;
        public static string setCity;
        public static string setEmailAddress;
        public static string setMotorcycleBrand;
        public static string setMotorcycleModel;

        public  ManageAccounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminHome adminHome = new adminHome();
            this.Visible = false;//closing the form
            adminHome.Show();
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            
                string query = "SELECT * FROM Customer ";
                
                OleDbCommand cmd = new OleDbCommand(query, Repository.Connection.conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridProducts.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
                }
            dataGridProducts.AllowUserToAddRows = false;
            dataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            Repository.Connection.conn.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM Customer WHERE Customer_username LIKE '%" + txtboxSearch.Text + "%' OR Customer_FirstName LIKE '%" + txtboxSearch.Text + "%' OR Customer_LastName LIKE '%" + txtboxSearch.Text + "%' OR Customer_ContactNumber LIKE '%" + txtboxSearch.Text + "%' OR Customer_StreetName LIKE '%" + txtboxSearch.Text + "%' OR Customer_City LIKE '%" + txtboxSearch.Text + "%' OR Customer_EmailAddress LIKE '%" + txtboxSearch.Text + "%' OR Customer_MotorcycleBrand LIKE '%" + txtboxSearch.Text + "%' OR CustomerMotorcycleModel LIKE '%" + txtboxSearch.Text + "%'", Repository.Connection.conn);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);

            //dataGridProducts.ColumnHeadersVisible = false;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridProducts.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
            }

            Repository.Connection.conn.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            addCustomer addCustomer = new addCustomer();
            this.Visible = false;//closing the form
            addCustomer.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select Customer");
            }
            else
            {
                EditCustomer editCustomer = new EditCustomer();
                this.Visible = false;//closing the form
                editCustomer.Show();
            }
        }

        private void dataGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setAccountID = dataGridProducts.CurrentRow.Cells[0].Value.ToString();
            setUserName = dataGridProducts.CurrentRow.Cells[1].Value.ToString();
            setPassword = dataGridProducts.CurrentRow.Cells[2].Value.ToString();
            setFirstName = dataGridProducts.CurrentRow.Cells[3].Value.ToString();
            setLastName = dataGridProducts.CurrentRow.Cells[4].Value.ToString();
            setContactNumber = dataGridProducts.CurrentRow.Cells[5].Value.ToString();
            setStreetName = dataGridProducts.CurrentRow.Cells[6].Value.ToString();
            setCity = dataGridProducts.CurrentRow.Cells[7].Value.ToString();
            setEmailAddress = dataGridProducts.CurrentRow.Cells[8].Value.ToString();
            setMotorcycleBrand = dataGridProducts.CurrentRow.Cells[9].Value.ToString();
            setMotorcycleModel = dataGridProducts.CurrentRow.Cells[10].Value.ToString();
    }
    }
}
