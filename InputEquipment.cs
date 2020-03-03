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
    public partial class InputEquipment : UserControl
    {
        public InputEquipment()
        {
            InitializeComponent();
        }

        public ComboBox statusAlat
        {
            get { return comboBoxStatus; }
            set { comboBoxStatus.SelectedItem = value; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.menuClick(new equipment());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (insertData())
            {
                MessageBox.Show("Data Berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.menuClick(new equipment());
            }
            else
            {
                MessageBox.Show("Gagal Menyimpan ke database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool insertData()
        {
            My_Db db = new My_Db();
            db.openConnection();


            //History
            string history = tglMasuk.Value.ToString("dd-MMM-yyyy") + "  :  Pembelian Alat";

            //Posisi Alat
            string posisiAlat = "";
            string keterangan = "";
            if (comboBoxStatus.SelectedItem.Equals("Cadangan")) { posisiAlat = "Office WWT"; }
            else
            {
                posisiAlat = txtKet.Text;
                history += "\n" + tglPemakaian.Value.ToString("dd-MMM-yyyy") + "  :  Alat Terpasang di  " + txtKet.Text;
            }

            //kondisi alat
            string kondisiAlat = "OK";

            //image
            byte[] pict = new byte[0];
            bool noImage = false;

            try
            {
                MemoryStream img = new MemoryStream();
                boxGambarAlat.Image.Save(img, boxGambarAlat.Image.RawFormat);
                pict = img.GetBuffer();
            }
            catch { noImage = true; }

            try
            {
                string noImg = "insert into [Equipment] ([Kode Alat],[Nama Alat],[Tahun Beli],[Posisi Alat],[Kondisi Alat],[Keterangan],[No. NCR],[No. Buang Aktiva Tetap],[History]) values (@ka,@na,@tb,@po,@ko,@ket,@ncr,@at,@hi)";
                string withImg = "insert into [Equipment] ([Kode Alat],[Nama Alat],[Tahun Beli],[Posisi Alat],[Kondisi Alat],[Keterangan],[No. NCR],[No. Buang Aktiva Tetap],[History],[Image]) values (@ka,@na,@tb,@po,@ko,@ket,@ncr,@at,@hi,@im)";

                SqlCommand command = new SqlCommand(noImage == true ? noImg : withImg, db.GetConnection);
                command.Parameters.AddWithValue("@ka", txtKode.Text);
                command.Parameters.AddWithValue("@na", txtNama.Text);
                command.Parameters.AddWithValue("@tb", tglMasuk.Value);
                command.Parameters.AddWithValue("@po", posisiAlat == "" ? "Terpasang" : posisiAlat);
                command.Parameters.AddWithValue("@ko", kondisiAlat);
                command.Parameters.AddWithValue("@ket", keterangan);
                command.Parameters.AddWithValue("@ncr", txtNCR.Text);
                command.Parameters.AddWithValue("@at", txtNoBuang.Text);
                command.Parameters.AddWithValue("@hi", history);
                if (noImage == false) { command.Parameters.AddWithValue("@im", pict); }

                command.ExecuteScalar();

                db.closeConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem.Equals("Cadangan"))
            {
                panelTanggal.Visible = false;
                panelKet.Visible = false;
                panelNCR.Visible = false;
                panelNoBuang.Visible = false;
            }
            else if (comboBoxStatus.SelectedItem.Equals("Terpasang"))
            {
                panelTanggal.Visible = true;
                panelKet.Visible = true;
                labelket.Text = "Lokasi Pemasangan";
                panelNCR.Visible = false;
                panelNoBuang.Visible = false;
            }
            else if (comboBoxStatus.SelectedItem.Equals("Rusak"))
            {
                panelTanggal.Visible = true;
                labelTanggalStatus.Text = "Tanggal Rusak";
                panelKet.Visible = true;
                labelket.Text = "Jenis Kerusakan";
                panelNCR.Visible = true;
                panelNoBuang.Visible = false;
            }
            else if (comboBoxStatus.SelectedItem.Equals("Dibuang"))
            {
                panelTanggal.Visible = true;
                labelTanggalStatus.Text = "Tanggal Dibuang";
                panelKet.Visible = false;
                panelNCR.Visible = false;
                panelNoBuang.Visible = true;
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image .jpg, .png, .bmp | *.jpg; *.png; *.bmp";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                boxGambarAlat.Image = Image.FromFile(opf.FileName);
            }
        }
        string itemEdit = "";
        public void editData(string kode)
        {
            itemEdit = kode;
            btnDelete.Visible = true;
            panelTglMasuk.Visible = false;
            My_Db db = new My_Db();
            db.openConnection();
            SqlCommand command = new SqlCommand("SELECT *FROM [Equipment] WHERE [Kode Alat]=@ko", db.GetConnection);
            command.Parameters.Add("@ko", SqlDbType.VarChar).Value = kode;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);

            //posisi alat
            string dataStatus = dtbl.Rows[0]["Posisi Alat"].ToString();
            string statusAlat;
            if (dataStatus == "Office WWT") { statusAlat = "Cadangan"; }
            else if (dataStatus == "Maintenance") { statusAlat = "Rusak"; }
            else if (dataStatus == "Dibuang") { statusAlat = "Dibuang"; }
            else {statusAlat = "Terpasang"; }

            txtKode.Text = dtbl.Rows[0]["Kode Alat"].ToString();
            txtNama.Text = dtbl.Rows[0]["Nama Alat"].ToString();
            comboBoxStatus.Text = statusAlat;
            if (statusAlat == "Terpasang")
            {
                txtKet.Text = dataStatus;
            }
            if (statusAlat == "Maintenance")
            {
                txtKet.Text = dtbl.Rows[0]["Keterangan"].ToString();
            }

            if (dtbl.Rows[0]["No. NCR"].ToString() != "")
            {
                txtNCR.Text = dtbl.Rows[0]["No. NCR"].ToString();
            }
            if (dtbl.Rows[0]["No. Buang Aktiva Tetap"].ToString() != "")
            {
                txtNoBuang.Text = dtbl.Rows[0]["No. Buang Aktiva Tetap"].ToString();
            }
            //try
            //{
            //    byte[] pict = (byte[])dtbl.Rows[0]["Image"];
            //    MemoryStream pic = new MemoryStream(pict);
            //    boxGambarAlat.Image = Image.FromStream(pic);
            //}
            //catch { }

            db.closeConnection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Setiap Melakukan Update Data Akan Tercatat di History\nPeriksa Kembali Data yang Anda Masukkan\nApakah Data yang dimasukkan sudah benar?", "Konfirmasi Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                My_Db db = new My_Db();
                db.openConnection();

                //Posisi Alat
                string posisiAlat = "";
                string ket = "";
                if (comboBoxStatus.SelectedItem.Equals("Cadangan")) { posisiAlat = "Office WWT"; }
                else if (comboBoxStatus.SelectedItem.Equals("Terpasang")) { posisiAlat = txtKet.Text; }
                else if (comboBoxStatus.SelectedItem.Equals("Rusak")) { posisiAlat = "Maintenance"; ket = txtKet.Text; }
                else if (comboBoxStatus.SelectedItem.Equals("Dibuang")) { posisiAlat = "Dibuang"; }

                //kondisi alat
                string kondisiAlat;
                if (comboBoxStatus.SelectedItem.Equals("Cadangan") || comboBoxStatus.SelectedItem.Equals("Terpasang"))
                {
                    kondisiAlat = "OK";
                }
                else if (comboBoxStatus.SelectedItem.Equals("Rusak"))
                {
                    kondisiAlat = "Rusak";
                }
                else { kondisiAlat = "Dibuang"; }

                //image
                //byte[] pict;
                //try
                //{
                //    MemoryStream img = new MemoryStream();
                //    boxGambarAlat.Image.Save(img, boxGambarAlat.Image.RawFormat);
                //    pict = img.GetBuffer();
                //}
                //catch
                //{
                //    pict = new byte[0];
                //}

                //history
                SqlCommand getHistory = new SqlCommand("SELECT *FROM [Equipment] WHERE [Kode Alat]=@ko", db.GetConnection);
                getHistory.Parameters.Add("@ko", SqlDbType.VarChar).Value = itemEdit;
                DataTable history = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(getHistory);
                adap.Fill(history);
                string hstory = history.Rows[0]["History"].ToString() + "\n" + tglPemakaian.Value.ToString("dd-MMM-yyyy");

                if (posisiAlat == "Office WWT") { hstory += "  :  Disimpan Sebagai Stok"; }
                else if (posisiAlat == txtKet.Text) { hstory += "  :  Terpasang di" + txtKet.Text; }
                else if (posisiAlat == "Maintenance") { hstory += "  :  Terjadi Kerusakan ( " + txtKet.Text + " )"; }
                else { hstory += "  :  Alat Dibuang"; }

                try
                {
                    SqlCommand command = new SqlCommand("UPDATE [Equipment] SET [Kode Alat]=@ko,[Nama Alat]=@na,[Posisi Alat]=@po,[Kondisi Alat]=@ka,[Keterangan]=@ket,[No. NCR]=@ncr,[No. Buang Aktiva Tetap]=@at,[History]=@hi WHERE [Kode Alat]=@kode", db.GetConnection);
                    command.Parameters.AddWithValue("@kode", itemEdit);
                    command.Parameters.AddWithValue("@ko", txtKode.Text);
                    command.Parameters.AddWithValue("@na", txtNama.Text);
                    if (posisiAlat == "") { command.Parameters.AddWithValue("@po", "Terpasang"); }
                    else { command.Parameters.AddWithValue("@po", posisiAlat); }
                    command.Parameters.AddWithValue("@ka", kondisiAlat);
                    command.Parameters.AddWithValue("@ket", ket);
                    command.Parameters.AddWithValue("@ncr", txtNCR.Text);
                    command.Parameters.AddWithValue("@at", txtNoBuang.Text);
                    //command.Parameters.AddWithValue("@im", pict);
                    command.Parameters.AddWithValue("@hi", hstory);
                    command.ExecuteScalar();

                    db.closeConnection();
                    if (MessageBox.Show("Data Berhasil diupdate.", "Update Data Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        equipment eq = new equipment();
                        Menu menu = new Menu();
                        menu.menuClick(eq);

                    }
                }
                catch
                {
                    db.closeConnection();
                    MessageBox.Show("Gagal Update Data!\nMohon periksa kembali data yang anda masukkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DATA AKAN DIHAPUS PERMANEN!\nYakin Akan Menghapus Data Ini?", "Hapus Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                deleteData();
                Menu menu = new Menu();
                equipment eq = new equipment();
                menu.menuClick(eq);
            }
        }

        private void deleteData()
        {
            My_Db db = new My_Db();
            db.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM [Equipment] WHERE [Kode Alat]=@ko", db.GetConnection);
            command.Parameters.AddWithValue("@ko", itemEdit);
            command.ExecuteScalar();
        }
    }
}
