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
    public partial class InputDaily : UserControl
    {
        public InputDaily()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUtama.instance.PnlContainer.Controls["InputDaily"].SendToBack();
        }
    }
}
