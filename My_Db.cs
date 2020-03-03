using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace wwtSystem
{
    class My_Db
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial catalog=C:\Users\Halim Syarif\source\repos\Database\wwtSystem.mdf;Integrated Security = True; Connect Timeout = 10");
        
        public SqlConnection GetConnection
        {
            get { return con; }
        }
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Can't connect to Database\nCheck again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
