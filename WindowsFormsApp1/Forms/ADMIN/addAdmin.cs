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
    public partial class addAdmin : Form
    {
        public addAdmin()
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
            ManageAccountsAdmin manageAccountsAdmin = new ManageAccountsAdmin();
            this.Visible = false;//closing the form
            manageAccountsAdmin.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            string listcats2 = listRoleAdmin.Text;
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            try
            {

                if (string.IsNullOrEmpty(adminUser.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(adminPass.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(adminPass2.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(adminFirstName.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(adminLastName.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                
                else if (string.IsNullOrEmpty(listcats2))
                {
                    MessageBox.Show("Please Select all the Fields");
                }
                
                else if (adminPass.Text != adminPass2.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                
                
                else
                {

                    Connection.DB();
                    Function.gen = "INSERT INTO Admin (admin_FirstName,admin_LastName,admin_role,admin_user,admin_password) VALUES('" + adminFirstName.Text + "','" + adminLastName.Text + "','" + listcats2 + "','" + adminUser.Text + "','" + adminPass.Text + "')";
                    Function.command = new OleDbCommand(Function.gen, Connection.conn);
                    Function.reader = Function.command.ExecuteReader();
                    MessageBox.Show("Admin added!");


                    ManageAccountsAdmin manageAccountsAdmin = new ManageAccountsAdmin();
                    this.Visible = false;//closing the form
                    manageAccountsAdmin.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
