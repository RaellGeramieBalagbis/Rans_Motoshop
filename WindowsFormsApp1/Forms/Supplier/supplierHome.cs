using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class supplierHome : Form
    {
        public supplierHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierProducts supplierProd = new SupplierProducts();
            this.Visible = false;//closing the form
            supplierProd.Show();
        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            lblfirstnameDisplay.Text = "" + char.ToUpper(frm_login.firstnameHome[0]) + frm_login.firstnameHome.Substring(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            this.Visible = false;//closing the form
            frm_login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            supplierAccount supplierAccount = new supplierAccount();
            this.Visible = false;//closing the form
            supplierAccount.Show();
        }

        private void lblfirstnameDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
