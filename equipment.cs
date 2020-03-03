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
    //to do  :  check kode alat yang sama sebelum submitbutton

    public partial class equipment : UserControl
    {
        DataTable dtbl = new DataTable();
        DataTable tableFilter = new DataTable();

        public equipment()
        {
            InitializeComponent();
        }
        
        private void equipment_Load(object sender, EventArgs e)
        {
            loadData();
            dgv.CellClick += Dgv_CellClick;
            comboStatusAlat.SelectedItem = "Semua Alat";
        }


        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["Edit/Delete"].Index)
            {
                if(e.RowIndex != -1)
                {
                    Menu menu = new Menu();
                    InputEquipment ei = new InputEquipment();
                    var kode = dgv.Rows[e.RowIndex].Cells[0].Value;
                    ei.editData(kode.ToString());
                    ei.btnUpdate.Visible = true;
                    ei.btnSubmit.Visible = false;
                    menu.menuClick(ei);
                }
                
            }
        }

        private void buildTable(List<string> kolom)
        {
            for (int i = 0; i < dgv.Columns.Count-1; i++)
            {
                dgv.Columns[i].Visible = false;
            }
            foreach (string item in kolom)
            {
                dgv.Columns[item].Visible = true;
            }
        }

        private void loadData()
        {
            try
            {
                My_Db db = new My_Db();
                db.openConnection();
                SqlCommand command = new SqlCommand("SELECT *FROM equipment", db.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtbl);
                dtbl.Columns.Remove("Id");
                dtbl.Columns.Remove("Keterangan");
                dtbl.Columns.Remove("Image");
                if (User.statusLogin == true)
                {
                    dtbl.Columns.Add("Edit/Delete");
                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        dtbl.Rows[i]["Edit/Delete"] = "...";
                    }
                }
                dgv.DataSource = dtbl;

                Setting setEq = new Setting();
                setEq.buildColoumEquipment();
                buildTable(setEq.kolomEquipment);
                //color row

                db.closeConnection();
            }
            catch { }

        }

        private void btnInputData_Click(object sender, EventArgs e)
        {
            if (User.statusLogin == true)
            {
                Menu menu = new Menu();
                InputEquipment ie = new InputEquipment();
                ie.btnSubmit.Visible = true;
                ie.btnUpdate.Visible = false;
                ie.statusAlat.Items.Remove("Rusak");
                ie.statusAlat.Items.Remove("Dibuang");
                ie.statusAlat.SelectedItem = "Cadangan";
                menu.menuClick(ie);
            }
            else
            {
                if(MessageBox.Show("Anda Harus Login Untuk Bisa Input Data\nLogin sekarang?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    FormLogin fl = new FormLogin();
                    if(fl.ShowDialog() == DialogResult.OK)
                    {
                        Menu menu = new Menu();
                        menu.menuClick(new InputEquipment());
                    }
                }
            }
        }

        private void comboStatusAlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStatusAlat.SelectedItem.Equals("Semua Alat"))
            {
                dgv.DataSource = dtbl;
            }
            else if (comboStatusAlat.SelectedItem.Equals("Cadangan"))
            {
                filterTable("Office WWT");
                dgv.DataSource = tableFilter;
            }
            else if (comboStatusAlat.SelectedItem.Equals("Rusak"))
            {
                filterTable("Maintenance");
                dgv.DataSource = tableFilter;
            }
            else if (comboStatusAlat.SelectedItem.Equals("Dibuang"))
            {
                filterTable("Dibuang");
                dgv.DataSource = tableFilter;
            }
            else
            {
                filterTable("Terpasang");
                dgv.DataSource = tableFilter;
            }
        }
        private void filterTable(string filter)
        {
            tableFilter = dtbl.Clone();
            tableFilter.Rows.Clear();
            for (int i = 0; i < dtbl.Rows.Count; i++)
            {
                DataRow dr = dtbl.Rows[i];
                if (filter == "Terpasang")
                {
                    if (!dr["Posisi Alat"].Equals("Office WWT") ^ !dr["Posisi Alat"].Equals("Maintenance") ^ !dr["Posisi Alat"].Equals("Dibuang"))
                    {
                        tableFilter.ImportRow(dr);
                    }
                }
                else if (dr["Posisi Alat"].Equals(filter))
                {
                    tableFilter.ImportRow(dr);
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = true;
            dgv.Width = 726;
            if (Setting.kodeAlat == true) { checkedListSetting.SetItemCheckState(0, CheckState.Checked); }
            if (Setting.namaAlat == true) { checkedListSetting.SetItemCheckState(1, CheckState.Checked); }
            if (Setting.tahunBeli == true) { checkedListSetting.SetItemCheckState(2, CheckState.Checked); }
            if (Setting.posisiAlat == true) { checkedListSetting.SetItemCheckState(3, CheckState.Checked); }
            if (Setting.kondisiAlat == true) { checkedListSetting.SetItemCheckState(4, CheckState.Checked); }
            if (Setting.noNCR == true) { checkedListSetting.SetItemCheckState(5, CheckState.Checked); }
            if (Setting.noBAT == true) { checkedListSetting.SetItemCheckState(6, CheckState.Checked); }
            if (Setting.history == true) { checkedListSetting.SetItemCheckState(7, CheckState.Checked); }
            //if (Setting.image == true) { checkedListSetting.SetItemCheckState(8, CheckState.Checked); }
        }

        private void btnCloseSetting_Click(object sender, EventArgs e)
        {
            dgv.Width = 961;
            panelSetting.Visible = false;
            Setting.kodeAlat = checkedListSetting.CheckedItems.Contains("Kode Alat") ? true : false;
            Setting.namaAlat = checkedListSetting.CheckedItems.Contains("Nama Alat") ? true : false;
            Setting.tahunBeli = checkedListSetting.CheckedItems.Contains("Tahun Beli") ? true : false;
            Setting.posisiAlat = checkedListSetting.CheckedItems.Contains("Posisi Alat") ? true : false;
            Setting.kondisiAlat = checkedListSetting.CheckedItems.Contains("Kondisi Alat") ? true : false;
            Setting.noNCR = checkedListSetting.CheckedItems.Contains("No. NCR") ? true : false;
            Setting.noBAT = checkedListSetting.CheckedItems.Contains("No. Buang Aktiva Tetap") ? true : false;
            Setting.history = checkedListSetting.CheckedItems.Contains("History") ? true : false;
            //Setting.image = checkedListSetting.CheckedItems.Contains("Image") ? true : false;
        }
        private void checkedListSetting_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                dgv.Columns[checkedListSetting.Items[e.Index].ToString()].Visible = true;
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                dgv.Columns[checkedListSetting.Items[e.Index].ToString()].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kodeAlat = false;
            //button1.Text = kodeAlat.ToString();
        }
    }
}
