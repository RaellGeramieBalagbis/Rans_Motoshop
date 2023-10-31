using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Repository
{
    internal class Connection
    {
        public static OleDbConnection conn;

        private static string dbconnect = "Provider=MSOLEDBSQL;Data Source=.\\SQLEXPRESS;Initial Catalog=RansMotoShop;Integrated Security=SSPI;";


        public static void DB()
        {
            try
            {
                conn = new OleDbConnection(dbconnect);
                conn.Open();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
