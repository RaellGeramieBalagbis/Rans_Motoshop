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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

    

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            CussID.Text = ManageAccounts.setAccountID;
            cusUser.Text = ManageAccounts.setUserName;
            cusPass.Text = ManageAccounts.setPassword;
            cussPass2.Text = ManageAccounts.setPassword;
            cussFirst.Text = ManageAccounts.setFirstName;
            cussLast.Text = ManageAccounts.setLastName;
            cussNumber.Text = ManageAccounts.setContactNumber;
            cussStreet.Text = ManageAccounts.setStreetName;
            cussCity.Text = ManageAccounts.setCity;
            cussEmail.Text = ManageAccounts.setEmailAddress;
            cussBrand.Text = ManageAccounts.setMotorcycleBrand;
            cussModel.Text = ManageAccounts.setMotorcycleModel;

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
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussEmail.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussStreet.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussCity.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussBrand.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(cussModel.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }

                //password invalidation
                else if (cussPass2.Text != cusPass.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else if (cusPass.Text != cussPass2.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                //
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
                    var gen = MessageBox.Show("Are you sure you want to update this record?", "Save record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (gen == DialogResult.Yes)
                    {
                        Function.gen = "UPDATE CUSTOMER SET Customer_username='" + cusUser.Text + "',Customer_password='" + cusPass.Text + "', Customer_FirstName = '" + cussFirst.Text + "', Customer_LastName = '" + cussFirst.Text + "',Customer_ContactNumber='" + cussNumber.Text + "',Customer_StreetName = '" + cussStreet.Text + "',Customer_City='" + cussCity.Text + "',Customer_EmailAddress='" + cussEmail.Text + "',Customer_MotorcycleBrand='" + cussBrand.Text + "',CustomerMotorcycleModel='" + cussModel.Text + "' WHERE AccountID='" + Int32.Parse(CussID.Text) + "'";
                        Function.command = new OleDbCommand(Function.gen, Connection.conn);
                        Function.reader = Function.command.ExecuteReader();
                        MessageBox.Show("Account saved!");


                        ManageAccounts manageAccounts = new ManageAccounts();
                        this.Visible = false;//closing the form
                        manageAccounts.Show();
                    }

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageAccounts manageAccounts = new ManageAccounts();
            this.Visible = false;//closing the form
            manageAccounts.Show();
        }
    }
}
