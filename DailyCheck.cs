using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wwtSystem
{
    public partial class DailyCheck : UserControl
    {
        public DailyCheck()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_load(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DailyCheck_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Halim Syarif\Documents\wwtSystem.mdf;Integrated Security = True; Connect Timeout = 30;");

            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = 
            //con.Close();

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (User.statusLogin == true)
            {
                Menu menu = new Menu();
                menu.menuClick(new InputDaily());
            }
            else
            {
                if (MessageBox.Show("Anda Harus Login Untuk Bisa Input Data\nLogin sekarang?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    FormLogin fl = new FormLogin();
                    if (fl.ShowDialog() == DialogResult.OK)
                    {
                        Menu menu = new Menu();
                        menu.menuClick(new InputDaily());
                    }
                }
            }
        }
    }
}
