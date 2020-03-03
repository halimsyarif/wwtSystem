using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wwtSystem
{
    class Menu
    {
        public void menuClick(UserControl menuX)
        {
            FormUtama.instance.PnlContainer.Controls.Clear();
            menuX.Dock = DockStyle.Fill;
            FormUtama.instance.PnlContainer.Controls.Add(menuX);
        }
    }
}
