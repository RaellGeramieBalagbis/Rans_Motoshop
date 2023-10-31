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
    public partial class EditSupplier : Form
    {
        public EditSupplier()
        {
            InitializeComponent();
        }

    

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            suppID.Text = ManageAccountsSupplier.setSupplierID;
            suppUser.Text = ManageAccountsSupplier.setUserName;
            suppPass.Text = ManageAccountsSupplier.setPassword;
            suppPass2.Text = ManageAccountsSupplier.setPassword;
            suppFirst.Text = ManageAccountsSupplier.setFirstName;
            suppLast.Text = ManageAccountsSupplier.setLastName;
            suppNumber.Text = ManageAccountsSupplier.setContactNumber;
            suppStreet.Text = ManageAccountsSupplier.setStreetName;
            suppCity.Text = ManageAccountsSupplier.setCity;
            suppEmail.Text = ManageAccountsSupplier.setEmailAddress;
            suppCompany.Text = ManageAccountsSupplier.setCompany;
           

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

                if (string.IsNullOrEmpty(suppUser.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppPass.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppPass2.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppFirst.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppLast.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppNumber.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppEmail.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppStreet.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppCity.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }
                else if (string.IsNullOrEmpty(suppCompany.Text))
                {
                    MessageBox.Show("Please Fill all the Fields");
                }

                //password invalidation
                else if (suppPass2.Text != suppPass.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else if (suppPass.Text != suppPass2.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                //
                else if (!IsValidEmail(suppEmail.Text))
                {


                    MessageBox.Show(text: "Please enter valid email.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    suppEmail.Focus();
                    return;
                }
                else if (suppNumber.Text.Length != 11)
                {
                    MessageBox.Show(text: "Phone number should be 11 digits", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    suppNumber.Focus();
                    return;
                }
                else if (regex.IsMatch(suppNumber.Text))
                {
                    MessageBox.Show(text: "Please enter valid phone number.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    suppNumber.Focus();
                    return;
                }

                else
                {
                    Connection.DB();
                    var gen = MessageBox.Show("Are you sure you want to update this record?", "Save record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (gen == DialogResult.Yes)
                    {
                        Function.gen = "UPDATE Supplier SET Supplier_FirstName='" + suppFirst.Text + "',Supplier_LastName='" + suppLast.Text + "', Supplier_ContactNumber = '" + suppNumber.Text + "', Supplier_StreetName = '" + suppStreet.Text + "',Supplier_City='" + suppCity.Text + "',Supplier_EmailAddress = '" + suppEmail.Text + "',Supplier_userName='" + suppUser.Text + "',Supplier_password='" + suppPass.Text + "',Supplier_Company='" + suppCompany.Text + "' WHERE SupplierID='" + Int32.Parse(suppID.Text) + "'";
                    Function.command = new OleDbCommand(Function.gen, Connection.conn);
                        Function.reader = Function.command.ExecuteReader();
                        MessageBox.Show("Supplier saved!");


                        ManageAccountsSupplier manageAccountsSupplier = new ManageAccountsSupplier();
                        this.Visible = false;//closing the form
                        manageAccountsSupplier.Show();
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
            
                ManageAccountsSupplier manageAccountsSupplier = new ManageAccountsSupplier();
                this.Visible = false;//closing the form
                manageAccountsSupplier.Show();
            

        }
    }

       
}

