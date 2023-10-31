﻿using System;
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
    public partial class SupplierProducts : Form
    {
        public SupplierProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplierHome supplierHome = new supplierHome();
            this.Visible = false;//closing the form
            supplierHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            

                string query = "SELECT * FROM Product ";
                OleDbCommand cmd = new OleDbCommand(query, Repository.Connection.conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridProducts.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridProducts.Rows.Add(row[0], row[1], "₱ " + row[2], row[3], row[4], row[5], row[6]);
                }
                
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addProductsSupplier1 addProducts = new addProductsSupplier1();
            this.Visible = false;//closing the form
            addProducts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addProductsSupplier1 addProductsSupplier1 = new addProductsSupplier1();
            this.Visible = false; //closing the form
            addProductsSupplier1.Show();
        }
    }
}
