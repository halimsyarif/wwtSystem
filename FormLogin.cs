using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wwtSystem
{
    public partial class FormLogin : Form
    {
        My_Db db = new My_Db();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }
        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (txtUser.Text.Equals("")||txtPass.Text.Equals(""))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (user.UserNameExist(txtUser.Text))
                {
                    string query = "SELECT *FROM [User] WHERE [Username]=@un AND [Password]=@pw";
                    SqlCommand command = new SqlCommand(query, db.GetConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = txtUser.Text;
                    command.Parameters.Add("@pw", SqlDbType.VarChar).Value = txtPass.Text;
                    DataTable dtbl = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtbl);

                    if (dtbl.Rows.Count > 0)
                    {
                        this.Close();
                        this.DialogResult = DialogResult.OK;
                        User.setStatusLogin(true);
                        User.getDataUserLogin(txtUser.Text);
                    }
                    else
                    {
                        MessageBox.Show("Password yang anda masukkan salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("User tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
