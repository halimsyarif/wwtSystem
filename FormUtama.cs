using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace wwtSystem
{
    public partial class FormUtama : Form
    {
        static FormUtama _obj;

        My_Db db = new My_Db();
        
        public static FormUtama instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormUtama();
                }
                return _obj;
            }
        }
        public Panel panelUser
        {
            get { return pnlLogin; }
            set { pnlLogin = value; }
        }
        public Panel PnlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }
        public Label labeltime
        {
            get { return labelTimer; }
            set { labelTimer = value; }
        }
        public FormUtama()
        {
            InitializeComponent();

        }
        public void showDataUserLogin()
        {
            labelUserLogin.Text = User.nama;
            labelJabatan.Text = User.jabatan;
            try
            {
                boxImage.Image = Image.FromStream(User.image);
            }
            catch { boxImage.Image = null; }
            pnlLogin.Visible = true;

        }
        private void FormUtama_Load(object sender, EventArgs e)
        {
            Time time = new Time();
            time.showTime();
            tanggal.Text = DateTime.Now.ToString("dd MMM yyyy");

            _obj = this;
            Menu menu = new Menu();
            levelRawpit lr = new levelRawpit();
            menu.menuClick(lr);
        }
        private void buttonDshbrd_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonDshbrd.Height;
            panelTandaMenu.Top = buttonDshbrd.Top;
            Menu menu = new Menu();
            menu.menuClick(new levelRawpit());
        }
        private void buttonDaily_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonDaily.Height;
            panelTandaMenu.Top = buttonDaily.Top;
            Menu menu = new Menu();
            menu.menuClick(new DailyCheck());
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonProses.Height;
            panelTandaMenu.Top = buttonProses.Top;
            Menu menu = new Menu();
            menu.menuClick(new ProsesWWT());

        }

        private void buttonDomestik_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonDomestik.Height;
            panelTandaMenu.Top = buttonDomestik.Top;
            Menu menu = new Menu();
            menu.menuClick(new Domestik());
        }

        private void buttonMistScrubber_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonMistScrubber.Height;
            panelTandaMenu.Top = buttonMistScrubber.Top;
        }

        private void buttonpHmeter_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonpHmeter.Height;
            panelTandaMenu.Top = buttonpHmeter.Top;
        }
        private void buttonLogbook_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonLogbook.Height;
            panelTandaMenu.Top = buttonLogbook.Top;
        }

        private void buttonEquipment_Click(object sender, EventArgs e)
        {
            panelTandaMenu.Height = buttonEquipment.Height;
            panelTandaMenu.Top = buttonEquipment.Top;
            Menu menu = new Menu();
            menu.menuClick(new equipment());
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Agar form bisa digeser
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
            User.setStatusLogin(false);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.menuClick(new EditUser());
        }
    }
}
