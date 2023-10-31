using System;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Forms
{
    public partial class createnewaccount : Form
    {
        
        public createnewaccount()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
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
        private void button1_Click(object sender, EventArgs e)
        {
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            try
            {
                if (userName.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (password.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (confirmPass.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (firstName.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (lastName.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (contactNumber.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (streetName.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (streetName.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (cityName.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (emailAddress.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (motorcycleBrand.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (motorcycleModel.Text.Contains("Enter"))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (password.Text != confirmPass.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else if (confirmPass.Text != password.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else if (!IsValidEmail(emailAddress.Text))
                {


                    MessageBox.Show(text: "Please enter valid email.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailAddress.Focus();
                    return;
                }
                else if(contactNumber.Text.Length != 11)
                {
                    MessageBox.Show(text: "Phone number should be 11 digits", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contactNumber.Focus();
                    return;
                }
                else if (regex.IsMatch(contactNumber.Text))
                {
                    MessageBox.Show(text: "Please enter valid phone number.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contactNumber.Focus();
                    return;
                }
                else
                {
                    Connection.DB();
                    Function.gen = "Insert into Customer(Customer_username, Customer_password, Customer_FirstName, Customer_LastName, Customer_ContactNumber, Customer_StreetName, Customer_City, Customer_EmailAddress, Customer_MotorcycleBrand, CustomerMotorcycleModel) values('" + userName.Text + "','" + password.Text + "','" + firstName.Text + "','" + lastName.Text + "','" + contactNumber.Text + "','" + streetName.Text + "', '" + cityName.Text + "', '" + emailAddress.Text + "','" + motorcycleBrand.Text + "', '" + motorcycleModel.Text + "')";
                    Function.command = new OleDbCommand(Function.gen, Connection.conn);
                    Function.reader = Function.command.ExecuteReader();
                    MessageBox.Show("Account Created!");
                    frm_login frm_login = new frm_login();
                    this.Visible = false;//closing the form
                    frm_login.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_login frm_login = new frm_login();
            this.Visible = false;//closing the form
            frm_login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "Enter User Name") 
            {
                
                userName.Text = "";
                userName.ForeColor = Color.Black;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
               
                userName.Text = "Enter User Name";
                userName.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Enter Password")
            {
                password.PasswordChar = '*';
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.PasswordChar = '\0';
                password.Text = "Enter Password";
                password.ForeColor = Color.Silver;
            }
        }

        private void confirmPass_Enter(object sender, EventArgs e)
        {
            if (confirmPass.Text == "Confirm Password")
            {
                confirmPass.PasswordChar = '*';
                confirmPass.Text = "";
                confirmPass.ForeColor = Color.Black;
            }
        }

        private void confirmPass_Leave(object sender, EventArgs e)
        {
            if (confirmPass.Text == "")
            {
                confirmPass.PasswordChar = '\0';
                confirmPass.Text = "Confirm Password";
                confirmPass.ForeColor = Color.Silver;
            }
        }

        private void firstName_Enter(object sender, EventArgs e)
        {
            if (firstName.Text == "Enter First Name")
            {

                firstName.Text = "";
                firstName.ForeColor = Color.Black;
            }
        }

        private void firstName_Leave(object sender, EventArgs e)
        {
            if (firstName.Text == "")
            {

                firstName.Text = "Enter First Name";
                firstName.ForeColor = Color.Silver;
            }
        }

        private void lastName_Enter(object sender, EventArgs e)
        {
            if (lastName.Text == "Enter Last Name")
            {

                lastName.Text = "";
                lastName.ForeColor = Color.Black;
            }
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text == "")
            {

                lastName.Text = "Enter Last Name";
                lastName.ForeColor = Color.Silver;
            }
        }

        private void contactNumber_Enter(object sender, EventArgs e)
        {
            if (contactNumber.Text == "Enter Contact Number")
            {

                contactNumber.Text = "";
                contactNumber.ForeColor = Color.Black;
            }
        }

        private void contactNumber_Leave(object sender, EventArgs e)
        {
            if (contactNumber.Text == "")
            {

                contactNumber.Text = "Enter Contact Number";
                contactNumber.ForeColor = Color.Silver;
            }
        }

        private void streetName_Enter(object sender, EventArgs e)
        {
            if (streetName.Text == "Enter Street Name")
            {

                streetName.Text = "";
                streetName.ForeColor = Color.Black;
            }
        }

        private void streetName_Leave(object sender, EventArgs e)
        {
            if (streetName.Text == "")
            {

                streetName.Text = "Enter Street Name";
                streetName.ForeColor = Color.Silver;
            }
        }

        private void cityName_Enter(object sender, EventArgs e)
        {
            if (cityName.Text == "Enter City")
            {

                cityName.Text = "";
                cityName.ForeColor = Color.Black;
            }
        }

        private void cityName_Leave(object sender, EventArgs e)
        {
            if (cityName.Text == "")
            {

                cityName.Text = "Enter City";
                cityName.ForeColor = Color.Silver;
            }
        }

        private void emailAddress_Enter(object sender, EventArgs e)
        {
            if (emailAddress.Text == "Enter Email Address")
            {

                emailAddress.Text = "";
                emailAddress.ForeColor = Color.Black;
            }
        }

        private void emailAddress_Leave(object sender, EventArgs e)
        {
            if (emailAddress.Text == "")
            {

                emailAddress.Text = "Enter Email Address";
                emailAddress.ForeColor = Color.Silver;
            }
        }

        private void motorcycleBrand_Enter(object sender, EventArgs e)
        {
            if (motorcycleBrand.Text == "Enter Motorcycle Brand")
            {

                motorcycleBrand.Text = "";
                motorcycleBrand.ForeColor = Color.Black;
            }
        }

        private void motorcycleBrand_Leave(object sender, EventArgs e)
        {
            if (motorcycleBrand.Text == "")
            {

                motorcycleBrand.Text = "Enter Motorcycle Brand";
                motorcycleBrand.ForeColor = Color.Silver;
            }
        }

        private void motorcycleModel_Enter(object sender, EventArgs e)
        {
            if (motorcycleModel.Text == "Enter Motorcycle Model")
            {

                motorcycleModel.Text = "";
                motorcycleModel.ForeColor = Color.Black;
            }
        }

        private void motorcycleModel_Leave(object sender, EventArgs e)
        {
            if (motorcycleModel.Text == "")
            {

                motorcycleModel.Text = "Enter Motorcycle Model";
                motorcycleModel.ForeColor = Color.Silver;
            }
        }

        private void contactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            //TO MAKE TEXTBOX ALL NUMBERS ONLY
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void createnewaccount_Load(object sender, EventArgs e)
        {

        }
    }
}
