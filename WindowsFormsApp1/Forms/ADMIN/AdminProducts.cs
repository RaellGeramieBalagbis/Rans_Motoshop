using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Forms
{
    public partial class AdminProducts : Form
    {
        public static string productID;
        public AdminProducts()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            prodname.Text = ManageProducts.setproductname;

            prodcat.SelectedItem = ManageProducts.setcategory;
            prodprice.Text = ManageProducts.setproductprice.Replace("₱ ", string.Empty);

            prodqual.Text = ManageProducts.setquantity;
            prodbrand.Text = ManageProducts.setmotorbrand;
            prodmodel.Text = ManageProducts.setmotormodel;
            productID = ManageProducts.setProdID;

            

        }



        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ManageProducts manageProducts = new ManageProducts();
            this.Visible = false;//closing the form
            manageProducts.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string listcats = prodcat.Text;
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            try
            {

                if (string.IsNullOrEmpty(prodqual.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(prodname.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(prodprice.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(prodbrand.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(prodmodel.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(listcats))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else
                {
                    if (prodqual.Text.Contains("SOLD"))
                    {
                        prodqual.Text = "0";
                    }
                

                    Connection.DB();
                    var gen = MessageBox.Show("Are you sure you want to update this record?", "Save record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (gen == DialogResult.Yes)
                    {
                        Function.gen = "UPDATE Product SET Product_Name='" +prodname.Text + "',Product_Price='" + prodprice.Text + "', Product_Quantity = '" + prodqual.Text + "', Product_Category = '" + listcats + "',Product_MotorcycleBrand='" + prodbrand.Text + "',Product_MotorcycleModel = '" + prodmodel.Text + "' WHERE ProductID='"+productID+"'";
                        Function.command = new OleDbCommand(Function.gen, Connection.conn);
                        Function.reader = Function.command.ExecuteReader();
                        MessageBox.Show("product saved!");


                        ManageProducts manageProducts = new ManageProducts();
                        this.Visible = false;//closing the form
                        manageProducts.Show();
                    }
              
                }
                
               
            }


            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void prodprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            //TO MAKE TEXTBOX ALL NUMBERS ONLY
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void prodqual_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            //TO MAKE TEXTBOX ALL NUMBERS ONLY
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                Connection.DB();
                var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gen == DialogResult.Yes)
                {
                    Function.gen = "DELETE FROM Product WHERE ProductID = '"+productID+"'";
                    Function.command = new OleDbCommand(Function.gen, Connection.conn);
                    Function.reader = Function.command.ExecuteReader();
                    MessageBox.Show("product deleted!");


                    ManageProducts manageProducts = new ManageProducts();
                    this.Visible = false;//closing the form
                    manageProducts.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
}
