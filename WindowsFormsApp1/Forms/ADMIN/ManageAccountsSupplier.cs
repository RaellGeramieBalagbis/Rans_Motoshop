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
    public partial class ManageAccountsSupplier : Form
    {
        public static string setSupplierID;
        public static string setUserName;
        public static string setPassword;
        public static string setFirstName;
        public static string setLastName;
        public static string setContactNumber;
        public static string setStreetName;
        public static string setCity;
        public static string setEmailAddress;
        public static string setCompany;
        
        public  ManageAccountsSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminHome adminHome = new adminHome();
            this.Visible = false;//closing the form
            adminHome.Show();
        }
        private void ManageAccountsSupplier_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Supplier ";

            OleDbCommand cmd = new OleDbCommand(query, Repository.Connection.conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridProducts.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridProducts.Rows.Add(row[0], row[9], row[01], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
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

        private void button3_Click(object sender, EventArgs e)
        {
            ManageAccounts manageAccounts = new ManageAccounts();
            this.Visible = false;//closing the form
            manageAccounts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageAccountsAdmin manageAccountsAdmin = new ManageAccountsAdmin();
            this.Visible = false;//closing the form
            manageAccountsAdmin.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addSupplier addSupplier = new addSupplier();
            this.Visible = false;//closing the form
            addSupplier.Show();
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            
            Repository.Connection.conn.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM Supplier WHERE Supplier_FirstName LIKE '%" + txtboxSearch.Text + "%' OR Supplier_LastName LIKE '%" + txtboxSearch.Text + "%' OR Supplier_ContactNumber LIKE '%" + txtboxSearch.Text + "%' OR Supplier_StreetName LIKE '%" + txtboxSearch.Text + "%' OR Supplier_City LIKE '%" + txtboxSearch.Text + "%' OR Supplier_EmailAddress LIKE '%" + txtboxSearch.Text + "%' OR Supplier_userName LIKE '%" + txtboxSearch.Text + "%' OR Supplier_Company LIKE '%" + txtboxSearch.Text + "%'", Repository.Connection.conn);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);

            //dataGridProducts.ColumnHeadersVisible = false;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridProducts.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridProducts.Rows.Add(row[0], row[9], row[01], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
                }

            Repository.Connection.conn.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            addSupplier addSupplier = new addSupplier();
            this.Visible = false;//closing the form
            addSupplier.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select Supplier");
            }
            else
            {
                EditSupplier editSupplier = new EditSupplier();
                this.Visible = false;//closing the form
                editSupplier.Show();
            }
        }

        private void dataGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setSupplierID = dataGridProducts.CurrentRow.Cells[0].Value.ToString();
            setUserName = dataGridProducts.CurrentRow.Cells[8].Value.ToString();
            setPassword = dataGridProducts.CurrentRow.Cells[9].Value.ToString();
            setFirstName = dataGridProducts.CurrentRow.Cells[2].Value.ToString();
            setLastName = dataGridProducts.CurrentRow.Cells[3].Value.ToString();
            setContactNumber = dataGridProducts.CurrentRow.Cells[4].Value.ToString();
            setStreetName = dataGridProducts.CurrentRow.Cells[5].Value.ToString();
            setCity = dataGridProducts.CurrentRow.Cells[6].Value.ToString();
            setEmailAddress = dataGridProducts.CurrentRow.Cells[7].Value.ToString();
            setCompany = dataGridProducts.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
