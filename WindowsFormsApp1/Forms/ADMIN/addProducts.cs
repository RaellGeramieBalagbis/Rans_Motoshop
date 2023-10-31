using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Forms
{
    public partial class addProducts : Form
    {
        public addProducts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            this.Visible = false;//closing the form
            manageProducts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string listcats = listCategory.Text;
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            try
            {
               
                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(txtProductPrice.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(txtMotorBrand.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(txtMotorModel.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(listcats))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else
                {

                    Connection.DB();
                     Function.gen = "INSERT INTO Product (Product_Name,Product_Price,Product_Quantity,Product_Category,Product_MotorcycleBrand,Product_MotorcycleModel) VALUES('"+txtProductName.Text+ "','"+txtProductPrice.Text+"','"+txtQuantity.Text+"','"+listcats+"','"+txtMotorBrand.Text+ "','"+txtMotorModel.Text+"')";
                     Function.command = new OleDbCommand(Function.gen, Connection.conn);
                     Function.reader = Function.command.ExecuteReader();
                     MessageBox.Show("product added!");


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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            //TO MAKE TEXTBOX ALL NUMBERS ONLY
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void addProductsSupplier_Load(object sender, EventArgs e)
        {

        }

        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            //TO MAKE TEXTBOX ALL NUMBERS ONLY
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
