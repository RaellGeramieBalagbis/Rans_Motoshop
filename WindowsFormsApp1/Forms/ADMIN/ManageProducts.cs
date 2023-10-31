using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class ManageProducts : Form
    {
        public static string setProdID;
        public static string setproductname;
        public static string setquantity;
        public static string setproductprice;
        public static string setmotorbrand;
        public static string setmotormodel;
        public static string setcategory;
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminHome adminHome = new adminHome();
            this.Visible = false;//closing the form
            adminHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            
            string quantities ="";
                string query = "SELECT * FROM Product ";
                OleDbCommand cmd = new OleDbCommand(query, Repository.Connection.conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridProducts.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                if (row[3].Equals(0))
                {
                    quantities = "SOLD OUT";
                }
                else { 
                quantities = row[3].ToString();
                }
                dataGridProducts.Rows.Add(row[0], row[1], "₱ " + row[2], quantities, row[4], row[5], row[6]);
                }
                dataGridProducts.AllowUserToAddRows = false;

            dataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageAccounts manageAccounts = new ManageAccounts();
            this.Visible = false;//closing the form
            manageAccounts.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addProducts AddplsProduct = new addProducts();
            this.Visible = false;//closing the form
            AddplsProduct.Show();
        }

        private void dataGridProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            setproductname = dataGridProducts.CurrentRow.Cells[1].Value.ToString();
            setproductprice = dataGridProducts.CurrentRow.Cells[2].Value.ToString();
            setquantity = dataGridProducts.CurrentRow.Cells[3].Value.ToString();
            setcategory = dataGridProducts.CurrentRow.Cells[4].Value.ToString();
            setmotorbrand = dataGridProducts.CurrentRow.Cells[5].Value.ToString();
            setmotormodel = dataGridProducts.CurrentRow.Cells[6].Value.ToString();
            setProdID = dataGridProducts.CurrentRow.Cells[0].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count <=0)
            {
                MessageBox.Show("Please select Product");
            }
            else
            {
                AdminProducts adminProducts = new AdminProducts();
                this.Visible = false;//closing the form
                adminProducts.Show();
            }

        }
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            string quantities = "";
            Repository.Connection.conn.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM Product WHERE Product_Name LIKE '%" + txtboxSearch.Text + "%' OR Product_Price LIKE '%" + txtboxSearch.Text + "%' OR Product_Quantity LIKE '%" + txtboxSearch.Text + "%' OR Product_Category LIKE '%" + txtboxSearch.Text + "%' OR Product_MotorcycleBrand LIKE '%" + txtboxSearch.Text + "%' OR Product_MotorcycleModel LIKE '%" + txtboxSearch.Text + "%'", Repository.Connection.conn);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);

            //dataGridProducts.ColumnHeadersVisible = false;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridProducts.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                if (row[3].Equals(0))
                {
                    quantities = "SOLD OUT";
                }
                else
                {
                    quantities = row[3].ToString();
                }
                dataGridProducts.Rows.Add(row[0], row[1], "₱ " + row[2], quantities, row[4], row[5], row[6]);
            }

            Repository.Connection.conn.Close();

        }
    }
}
