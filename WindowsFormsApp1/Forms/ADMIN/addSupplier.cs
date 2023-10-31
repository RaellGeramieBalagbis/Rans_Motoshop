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
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Forms
{
    public partial class addSupplier : Form
    {
        public addSupplier()
        {
            InitializeComponent();
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
        private void button2_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            this.Visible = false;//closing the form
            manageProducts.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageAccountsSupplier manageAccountsSupplier = new ManageAccountsSupplier();
            this.Visible = false;//closing the form
            manageAccountsSupplier.Show();
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

                if (string.IsNullOrEmpty(suppUser.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppPassword.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppConfirmPass.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppCompany.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppFirstName.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppLastName.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(suppContactNumber.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(suppEmail.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(suppCity.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (string.IsNullOrEmpty(suppStreet.Text))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                else if (suppPassword.Text != suppConfirmPass.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else if (!IsValidEmail(suppEmail.Text))
                {


                    MessageBox.Show(text: "Please enter valid email.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    suppEmail.Focus();
                    return;
                }
                else if (suppContactNumber.Text.Length != 11)
                {
                    MessageBox.Show(text: "Phone number should be 11 digits", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    suppContactNumber.Focus();
                    return;
                }
                else if (regex.IsMatch(suppContactNumber.Text))
                {
                    MessageBox.Show(text: "Please enter valid phone number.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    suppContactNumber.Focus();
                    return;
                }
                else
                {

                    Connection.DB();
                    Function.gen = "INSERT INTO Supplier (Supplier_FirstName,Supplier_LastName,Supplier_ContactNumber,Supplier_StreetName,Supplier_City,Supplier_EmailAddress,Supplier_userName,Supplier_password,Supplier_Company) VALUES('" + suppFirstName.Text + "','" + suppLastName.Text + "','" + suppContactNumber.Text + "','" + suppStreet.Text + "','" + suppCity.Text + "','" + suppEmail.Text + "','" + suppUser.Text + "','" + suppPassword.Text + "','" + suppCompany.Text + "')";
                    Function.command = new OleDbCommand(Function.gen, Connection.conn);
                    Function.reader = Function.command.ExecuteReader();
                    MessageBox.Show("Supplier added!");


                    ManageAccountsSupplier manageAccountsSupplier = new ManageAccountsSupplier();
                    this.Visible = false;//closing the form
                    manageAccountsSupplier.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
