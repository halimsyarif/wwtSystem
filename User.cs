using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace wwtSystem
{
    class User
    {
        public static bool statusLogin { get; private set; } = false;
        public static string userLogin;
        public static string nama;
        public static string jabatan;
        public static string password;
        public static MemoryStream image;
        
        public static void setStatusLogin(bool status)
        {
            statusLogin = status;
        }
        public static void getDataUserLogin(string usrlogin)
        {
            userLogin = usrlogin;
            My_Db db = new My_Db();
            db.openConnection();
            SqlCommand command = new SqlCommand("SELECT *FROM [User] WHERE [Username]=@un", db.GetConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = userLogin;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            nama = dtbl.Rows[0]["Name"].ToString();
            jabatan = dtbl.Rows[0]["Jabatan"].ToString();
            password = dtbl.Rows[0]["Password"].ToString();
            try
            {
                byte[] pic = (byte[])dtbl.Rows[0]["Image"];
                MemoryStream pict = new MemoryStream(pic);
                image = pict;
            }
            catch { image = null; }
            db.closeConnection();
            FormUtama.instance.showDataUserLogin();
        }
        public static bool updateDataUser(string userLogin, string nama, string jabatan, string username, string password, byte[] image)
        {
            My_Db db = new My_Db();
            db.openConnection();
            SqlCommand command = new SqlCommand("UPDATE [User] SET [Name]=@un,[Jabatan]=@jb,[Username]=@usn,[Password]=@pw,[Image]=@im WHERE [Username]=@usl", db.GetConnection);
            command.Parameters.Add("@usl", SqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@jb", SqlDbType.VarChar).Value = jabatan;
            command.Parameters.Add("@usn", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@im", SqlDbType.Image).Value = image;


            if (command.ExecuteNonQuery()==1)
            {
                db.closeConnection();
                getDataUserLogin(username);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UserNameExist(string username)
        {
            try
            {
                My_Db db = new My_Db();
                db.openConnection();
                SqlCommand command = new SqlCommand("SELECT *FROM [User] WHERE [Username]=@un", db.GetConnection);
                command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                db.closeConnection();
                if (dtbl.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
    }
}
