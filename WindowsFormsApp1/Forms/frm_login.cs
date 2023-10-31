using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class frm_login : Form
    {
        public static string firstnameHome = "";
        public static string lastnameHome = "";
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) && string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please Fill all the Fields");
            }
          
            if (username.Text.Trim() == String.Empty)
            {
                MessageBox.Show(text: "Please enter username", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();
                return;
            }
            if (password.Text.Trim() == String.Empty)
            {
                MessageBox.Show(text: "Please enter password", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
                return;
            }

            try
            {
                Connection.DB();
                //ADMIN
                Function.gen_admin = "Select * from Admin where admin_user='" + username.Text + "' AND admin_password='" + password.Text + "';";
                
                Function.command_admin = new OleDbCommand(Function.gen_admin, Connection.conn);
                //CUSTOMER
                Function.gen_customer = "Select * from Customer where Customer_username='" + username.Text + "' AND Customer_password='" + password.Text + "';";
                Function.command_customer = new OleDbCommand(Function.gen_customer, Connection.conn);

                //SUPPLIER
                Function.gen_supplier = "Select * from Supplier where Supplier_userName='" + username.Text + "' AND Supplier_password='" + password.Text + "';";
                Function.command_supplier = new OleDbCommand(Function.gen_supplier, Connection.conn);

                Function.reader_admin = Function.command_admin.ExecuteReader();
                Function.reader_customer = Function.command_customer.ExecuteReader();
                Function.reader_supplier = Function.command_supplier.ExecuteReader();

                //IF ADMIN HOME
                if (Function.reader_admin.HasRows)
                {
                    Function.reader_admin.Read();

                    username.Text = Function.reader_admin["admin_user"].ToString();
                    password.Text = Function.reader_admin["admin_password"].ToString();

                    firstnameHome = Function.reader_admin["admin_FirstName"].ToString();

                    adminHome homeadmin = new adminHome();
                    this.Visible = false;//closing the form
                    homeadmin.Show();
                  
                    Connection.conn.Close();
                }
                //IF CUSTOMER HOME
                else if (Function.reader_customer.HasRows)
                {
                    Function.reader_customer.Read();

                    username.Text = Function.reader_customer["Customer_username"].ToString();
                    password.Text = Function.reader_customer["Customer_password"].ToString();

                    firstnameHome = Function.reader_customer["Customer_FirstName"].ToString();
                    lastnameHome = Function.reader_customer["Customer_LastName"].ToString();
                    

                    customerHome customerHome = new customerHome();
                    this.Visible = false;//closing the form
                    customerHome.Show();
                }
                //SUPPLIER
                else if (Function.reader_supplier.HasRows)
                {
                    Function.reader_supplier.Read();

                    username.Text = Function.reader_supplier["Supplier_userName"].ToString();
                    password.Text = Function.reader_supplier["Supplier_password"].ToString();

                    firstnameHome = Function.reader_supplier["Supplier_FirstName"].ToString();
                    lastnameHome = Function.reader_supplier["Supplier_LastName"].ToString();

                    supplierHome supplierHome = new supplierHome();
                    this.Visible = false;//closing the form
                    supplierHome.Show();
                }
                else
                {
                    MessageBox.Show("Account not Found!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                    
                    createnewaccount createnewaccount = new createnewaccount();
                    this.Visible = false;//closing the form
                    createnewaccount.Show();
               

        }

     
    }
}
