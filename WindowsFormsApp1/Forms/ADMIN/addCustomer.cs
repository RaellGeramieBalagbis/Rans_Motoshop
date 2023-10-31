using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Forms
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            this.Visible = false;//closing the form
            manageProducts.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageAccounts manageAccounts = new ManageAccounts();
            this.Visible = false;//closing the form
            manageAccounts.Show();
        }
        private bool IsValidEmail(string email)
        {

            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Use regular expressions to validate the email format.
                // This pattern matches the format "user@domain.com".
                var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                var regex = new Regex(pattern);
                return regex.IsMatch(email);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            //TO MAKE TEXTBOX ALL NUMBERS ONLY
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            try
            {

                if (string.IsNullOrEmpty(cusUser.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cusPass.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussPass2.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussFirst.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussLast.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussNumber.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(cussEmail.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(cussStreet.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(cussCity.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(cussBrand.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(cussModel.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (cusPass.Text != cussPass2.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else if (!IsValidEmail(cussEmail.Text))
                {


                    MessageBox.Show(text: "Please enter valid email.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cussEmail.Focus();
                    return;
                }
                else if (cussNumber.Text.Length != 11)
                {
                    MessageBox.Show(text: "Phone number should be 11 digits", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cussNumber.Focus();
                    return;
                }
                else if (regex.IsMatch(cussNumber.Text))
                {
                    MessageBox.Show(text: "Please enter valid phone number.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cussNumber.Focus();
                    return;
                }
                else
                {

                    Connection.DB();
                    Function.gen = "INSERT INTO Customer (Customer_username,Customer_password,Customer_FirstName,Customer_LastName,Customer_ContactNumber,Customer_StreetName,Customer_City,Customer_EmailAddress,Customer_MotorcycleBrand,CustomerMotorcycleModel) VALUES('" + cusUser.Text + "','" + cusPass.Text + "','" + cussFirst.Text + "','" + cussLast.Text + "','" + cussNumber.Text + "','" + cussStreet.Text + "','" + cussCity.Text + "','" + cussEmail.Text + "','" + cussBrand.Text + "','" + cussModel.Text + "')";
                    Function.command = new OleDbCommand(Function.gen, Connection.conn);
                    Function.reader = Function.command.ExecuteReader();
                    MessageBox.Show("Customer added!");


                    ManageAccounts manageAccounts = new ManageAccounts();
                    this.Visible = false;//closing the form
                    manageAccounts.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
