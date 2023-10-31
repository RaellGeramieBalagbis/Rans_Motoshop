using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Repository
{
    internal class Function
    {
        public static string gen = "";//variable to hold sql statements
        public static OleDbConnection conn;
        public static OleDbCommand command;//process the sql statements and connections
        public static OleDbDataReader reader;//retrieve data from the database

        public static string gen_admin = "";//variable to hold sql statements
        public static OleDbConnection conn_admin;
        public static OleDbCommand command_admin;//process the sql statements and connections
        public static OleDbDataReader reader_admin;//retrieve data from the database

        public static string gen_customer = "";//variable to hold sql statements
        public static OleDbConnection conn_customer;
        public static OleDbCommand command_customer;//process the sql statements and connections
        public static OleDbDataReader reader_customer;//retrieve data from the database

        public static string gen_supplier = "";//variable to hold sql statements
        public static OleDbConnection conn_supplier;
        public static OleDbCommand command_supplier;//process the sql statements and connections
        public static OleDbDataReader reader_supplier;//retrieve data from the database

        public static void fill(string q, DataGridView dgv)
        {
            try
            {
                Connection.DB();
                DataTable dt = new DataTable();
                OleDbDataAdapter data = null;
                OleDbCommand command = new OleDbCommand(q, Connection.conn);
                data = new OleDbDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;//retrieve all the records and display it in the data grid view
                Connection.conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
