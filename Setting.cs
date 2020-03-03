using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace wwtSystem
{
    class Setting
    {
        ///Tabel Equipment
        public static bool kodeAlat { get; set; } = true;
        public static bool namaAlat { get; set; } = true;
        public static bool tahunBeli { get; set; } = true;
        public static bool posisiAlat { get; set; } = true;
        public static bool kondisiAlat { get; set; } = true;
        public static bool noNCR { get; set; } = false;
        public static bool noBAT { get; set; } = false;
        public static bool history { get; set; } = true;
        //public static bool image { get; set; } = false;

        public List<string> kolomEquipment = new List<string>();

        public void buildColoumEquipment()
        {
            kolomEquipment.Clear();
            if (kodeAlat == true) { kolomEquipment.Add("Kode Alat"); }
            if (namaAlat == true) { kolomEquipment.Add("Nama Alat"); }
            if (tahunBeli == true) { kolomEquipment.Add("Tahun Beli"); }
            if (posisiAlat == true) { kolomEquipment.Add("Posisi Alat"); }
            if (kondisiAlat == true) { kolomEquipment.Add("Kondisi Alat"); }
            if (noNCR == true) { kolomEquipment.Add("No. NCR"); }
            if (noBAT == true) { kolomEquipment.Add("No. Buang Aktiva Tetap"); }
            if (history == true) { kolomEquipment.Add("History"); }
            //if (image == true) { kolomEquipment.Add("Image"); }
        }
    }
}
