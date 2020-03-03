namespace wwtSystem
{
    partial class Domestik
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaterMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahLimbah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NH4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judgement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Option = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(762, 27);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(241, 35);
            this.button10.TabIndex = 14;
            this.button10.Text = "Eksport Data";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(162, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 35);
            this.button9.TabIndex = 15;
            this.button9.Text = "Input Data";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "Januari",
        "Februari",
        "Maret",
        "April",
        "Mei",
        "Juni",
        "Juli",
        "Agustus",
        "September",
        "Oktober",
        "November",
        "Desember"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(42, 27);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(120, 35);
            this.bunifuDropdown1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "-";
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tanggal,
            this.WaterMeter,
            this.JumlahLimbah,
            this.pH,
            this.eC,
            this.TDS,
            this.COD,
            this.NH4,
            this.Judgement,
            this.Option});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(42, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 462);
            this.dataGridView1.TabIndex = 12;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 80;
            // 
            // WaterMeter
            // 
            this.WaterMeter.HeaderText = "WaterMeter";
            this.WaterMeter.MinimumWidth = 6;
            this.WaterMeter.Name = "WaterMeter";
            this.WaterMeter.Width = 120;
            // 
            // JumlahLimbah
            // 
            this.JumlahLimbah.HeaderText = "Jumlah Limbah";
            this.JumlahLimbah.MinimumWidth = 6;
            this.JumlahLimbah.Name = "JumlahLimbah";
            this.JumlahLimbah.Width = 125;
            // 
            // pH
            // 
            this.pH.HeaderText = "pH";
            this.pH.MinimumWidth = 6;
            this.pH.Name = "pH";
            this.pH.ToolTipText = "6-9";
            this.pH.Width = 90;
            // 
            // eC
            // 
            this.eC.HeaderText = "eC";
            this.eC.MinimumWidth = 6;
            this.eC.Name = "eC";
            this.eC.Width = 90;
            // 
            // TDS
            // 
            this.TDS.HeaderText = "TDS";
            this.TDS.MinimumWidth = 6;
            this.TDS.Name = "TDS";
            this.TDS.Width = 90;
            // 
            // COD
            // 
            this.COD.HeaderText = "COD";
            this.COD.MinimumWidth = 6;
            this.COD.Name = "COD";
            this.COD.Width = 90;
            // 
            // NH4
            // 
            this.NH4.HeaderText = "NH4";
            this.NH4.MinimumWidth = 6;
            this.NH4.Name = "NH4";
            this.NH4.Width = 90;
            // 
            // Judgement
            // 
            this.Judgement.HeaderText = "Judgement";
            this.Judgement.MinimumWidth = 6;
            this.Judgement.Name = "Judgement";
            this.Judgement.Width = 125;
            // 
            // Option
            // 
            this.Option.HeaderText = "Option";
            this.Option.MinimumWidth = 6;
            this.Option.Name = "Option";
            this.Option.Width = 90;
            // 
            // Domestik
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Domestik";
            this.Size = new System.Drawing.Size(1055, 587);
            this.Load += new System.EventHandler(this.Domestik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaterMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahLimbah;
        private System.Windows.Forms.DataGridViewTextBoxColumn pH;
        private System.Windows.Forms.DataGridViewTextBoxColumn eC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NH4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judgement;
        private System.Windows.Forms.DataGridViewLinkColumn Option;
    }
}
