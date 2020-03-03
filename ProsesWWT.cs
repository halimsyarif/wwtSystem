using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wwtSystem
{
    public partial class ProsesWWT : UserControl
    {
        public ProsesWWT()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (User.statusLogin == true)
            {
                Menu menu = new Menu();
                menu.menuClick(new InputProses());
            }
            else
            {
                if (MessageBox.Show("Anda Harus Login Untuk Bisa Input Data\nLogin sekarang?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    FormLogin fl = new FormLogin();
                    if (fl.ShowDialog() == DialogResult.OK)
                    {
                        Menu menu = new Menu();
                        menu.menuClick(new InputProses());
                    }
                }
            }
        }
    }
}
