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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Forms
{
    public partial class EditAdmin : Form
    {
        public EditAdmin()
        {
            InitializeComponent();
        }

    

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            adminiD.Text = ManageAccountsAdmin.setAdminID;
            adminUser.Text = ManageAccountsAdmin.setUser;
            adminPass.Text = ManageAccountsAdmin.setPassword;
            adminPass2.Text = ManageAccountsAdmin.setPassword;
            adminFirst.Text = ManageAccountsAdmin.setFirstName;
            adminLast.Text = ManageAccountsAdmin.setLastName;
            listRoleAdmin.Text = ManageAccountsAdmin.setRole;
           

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
            string listcats = listRoleAdmin.Text;
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
                else if (string.IsNullOrEmpty(adminFirst.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(adminLast.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(listcats))
                {
                    MessageBox.Show("Please Select all the Fields");
                }

                //password invalidation
                else if (adminPass2.Text != adminPass.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else if (adminPass.Text != adminPass2.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                

                else
                {
                    Connection.DB();
                    var gen = MessageBox.Show("Are you sure you want to update this record?", "Save record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (gen == DialogResult.Yes)
                    {
                        Function.gen = "UPDATE Admin SET admin_FirstName='" + adminFirst.Text + "',admin_LastName='" + adminLast.Text + "', admin_role = '" + listRoleAdmin.Text + "', admin_user = '" + adminUser.Text + "',admin_password='" + adminPass.Text +  "' WHERE adminID='" + Int32.Parse(adminiD.Text) + "'";
                        Function.command = new OleDbCommand(Function.gen, Connection.conn);
                        Function.reader = Function.command.ExecuteReader();
                        MessageBox.Show("Admin saved!");


                        ManageAccountsAdmin manageAccountsAdmin = new ManageAccountsAdmin();
                        this.Visible = false;//closing the form
                        manageAccountsAdmin.Show();
                    }

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                ManageAccountsAdmin manageAccountsAdmin = new ManageAccountsAdmin();
                this.Visible = false;//closing the form
                manageAccountsAdmin.Show();
            

        }
    }

       
}

