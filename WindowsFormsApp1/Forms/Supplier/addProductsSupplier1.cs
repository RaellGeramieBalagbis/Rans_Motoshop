using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class addProductsSupplier1 : Form
    {
        public addProductsSupplier1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierProducts supplierP = new SupplierProducts();
            this.Visible = false;//closing the form
            supplierP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
