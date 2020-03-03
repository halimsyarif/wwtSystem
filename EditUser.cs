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
using System.IO;

namespace wwtSystem
{
    public partial class EditUser : UserControl
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            txtNama.Text = User.nama;
            txtJabatan.Text = User.jabatan;
            txtUsername.Text = User.userLogin;
            txtPass.Text = User.password;
            try
            {
                boxImageUser.Image = Image.FromStream(User.image);
            }
            catch { boxImageUser.Image = null; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userlogin = User.userLogin;
            string nama = txtNama.Text;
            string jabatan = txtJabatan.Text;
            string username = txtUsername.Text;
            string password = txtPass.Text;

            ///save image to database
            MemoryStream image = new MemoryStream();
            boxImageUser.Image.Save(image, boxImageUser.Image.RawFormat);
            byte[] pict = image.GetBuffer();

            if (txtNama.Text.Equals("") || txtJabatan.Text.Equals("") || txtUsername.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Semua Data Harus Diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (User.updateDataUser(userlogin, nama, jabatan, username, password, pict))
                {
                    MessageBox.Show("Data Berhasil diedit", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormUtama.instance.PnlContainer.Controls.Clear();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image .jpg; .png; .bmp | *.jpg; *.png; *.bmp";
            if (opf.ShowDialog()==DialogResult.OK)
            {
                boxImageUser.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
