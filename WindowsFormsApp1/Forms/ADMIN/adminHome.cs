﻿using System;
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
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             ManageProducts manageProducts = new ManageProducts();
            this.Visible = false;//closing the form
            manageProducts.Show();
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
            ManageAccounts manageAccounts = new ManageAccounts();
            this.Visible = false;//closing the form
            manageAccounts.Show();
        }
    }
}
