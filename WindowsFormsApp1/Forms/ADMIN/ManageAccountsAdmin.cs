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
    public partial class ManageAccountsAdmin : Form
    {
        public static string setAdminID;
        public static string setFirstName;
        public static string setLastName;
        public static string setRole;
        public static string setUser;
        public static string setPassword;
        

        public ManageAccountsAdmin()
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
            string roles = "";
            string query = "SELECT * FROM Admin ";
                
                OleDbCommand cmd = new OleDbCommand(query, Repository.Connection.conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridProducts.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                dataGridProducts.Rows.Add(row[0], row[3], row[1], row[2], row[4], row[5]);
                //dataGridProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
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
            ManageAccountsSupplier manageAccountSupplier = new ManageAccountsSupplier();
            this.Visible = false;//closing the form
            manageAccountSupplier.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            Repository.Connection.conn.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM Admin WHERE admin_FirstName LIKE '%" + txtboxSearch.Text + "%' OR admin_LastName LIKE '%" + txtboxSearch.Text + "%' OR admin_role LIKE '%" + txtboxSearch.Text + "%' OR admin_user LIKE '%" + txtboxSearch.Text + "%' ", Repository.Connection.conn);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);

            //dataGridProducts.ColumnHeadersVisible = false;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridProducts.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridProducts.Rows.Add(row[0], row[3], row[1], row[2], row[4], row[5]);
            }

            Repository.Connection.conn.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            addAdmin addAdmin = new addAdmin();
            this.Visible = false;//closing the form
            addAdmin.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select Product");
            }
            else
            {
                EditAdmin editAdmin = new EditAdmin();
                this.Visible = false;//closing the form
                editAdmin.Show();
            }
        }

        private void dataGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setAdminID = dataGridProducts.CurrentRow.Cells[0].Value.ToString();
            setFirstName = dataGridProducts.CurrentRow.Cells[2].Value.ToString();
            setLastName = dataGridProducts.CurrentRow.Cells[3].Value.ToString();
            setRole = dataGridProducts.CurrentRow.Cells[1].Value.ToString();
            setUser = dataGridProducts.CurrentRow.Cells[4].Value.ToString();
            setPassword = dataGridProducts.CurrentRow.Cells[5].Value.ToString();
            

        }
    }
}
