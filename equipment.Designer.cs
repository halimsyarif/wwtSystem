namespace wwtSystem
{
    partial class equipment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEksport = new System.Windows.Forms.Button();
            this.btnInputData = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.comboStatusAlat = new System.Windows.Forms.ComboBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.checkedListSetting = new System.Windows.Forms.CheckedListBox();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEksport
            // 
            this.btnEksport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEksport.Location = new System.Drawing.Point(774, 48);
            this.btnEksport.Name = "btnEksport";
            this.btnEksport.Size = new System.Drawing.Size(187, 30);
            this.btnEksport.TabIndex = 17;
            this.btnEksport.Text = "Eksport Data";
            this.btnEksport.UseVisualStyleBackColor = true;
            // 
            // btnInputData
            // 
            this.btnInputData.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputData.Location = new System.Drawing.Point(42, 48);
            this.btnInputData.Name = "btnInputData";
            this.btnInputData.Size = new System.Drawing.Size(112, 30);
            this.btnInputData.TabIndex = 18;
            this.btnInputData.Text = "Input Data";
            this.btnInputData.UseVisualStyleBackColor = true;
            this.btnInputData.Click += new System.EventHandler(this.btnInputData_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "-";
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 29;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Location = new System.Drawing.Point(42, 84);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(961, 462);
            this.dgv.TabIndex = 19;
            // 
            // comboStatusAlat
            // 
            this.comboStatusAlat.DisplayMember = "Cadangan";
            this.comboStatusAlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatusAlat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatusAlat.FormattingEnabled = true;
            this.comboStatusAlat.Items.AddRange(new object[] {
            "Semua Alat",
            "Cadangan",
            "Terpasang",
            "Rusak",
            "Dibuang"});
            this.comboStatusAlat.Location = new System.Drawing.Point(160, 49);
            this.comboStatusAlat.Name = "comboStatusAlat";
            this.comboStatusAlat.Size = new System.Drawing.Size(116, 29);
            this.comboStatusAlat.TabIndex = 20;
            this.comboStatusAlat.SelectedIndexChanged += new System.EventHandler(this.comboStatusAlat_SelectedIndexChanged);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = global::wwtSystem.Properties.Resources.Set_svg_vector_icon_32px;
            this.btnSetting.Location = new System.Drawing.Point(967, 48);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(36, 29);
            this.btnSetting.TabIndex = 22;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // checkedListSetting
            // 
            this.checkedListSetting.BackColor = System.Drawing.Color.LemonChiffon;
            this.checkedListSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListSetting.CheckOnClick = true;
            this.checkedListSetting.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListSetting.FormattingEnabled = true;
            this.checkedListSetting.Items.AddRange(new object[] {
            "Kode Alat",
            "Nama Alat",
            "Tahun Beli",
            "Posisi Alat",
            "Kondisi Alat",
            "No. NCR",
            "No. Buang Aktiva Tetap",
            "History"});
            this.checkedListSetting.Location = new System.Drawing.Point(3, 34);
            this.checkedListSetting.Name = "checkedListSetting";
            this.checkedListSetting.Size = new System.Drawing.Size(221, 209);
            this.checkedListSetting.TabIndex = 23;
            this.checkedListSetting.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListSetting_ItemCheck);
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.SystemColors.Control;
            this.panelSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSetting.Controls.Add(this.panel1);
            this.panelSetting.Controls.Add(this.label2);
            this.panelSetting.Controls.Add(this.label1);
            this.panelSetting.Controls.Add(this.checkedListSetting);
            this.panelSetting.Controls.Add(this.btnCloseSetting);
            this.panelSetting.Location = new System.Drawing.Point(774, 84);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(229, 462);
            this.panelSetting.TabIndex = 24;
            this.panelSetting.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(3, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 57);
            this.panel1.TabIndex = 25;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(4, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 25);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Berwarna";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 25);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hitam - Putih";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Indikator Warna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filter kolom";
            // 
            // btnCloseSetting
            // 
            this.btnCloseSetting.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSetting.Location = new System.Drawing.Point(64, 417);
            this.btnCloseSetting.Name = "btnCloseSetting";
            this.btnCloseSetting.Size = new System.Drawing.Size(112, 30);
            this.btnCloseSetting.TabIndex = 18;
            this.btnCloseSetting.Text = "Close";
            this.btnCloseSetting.UseVisualStyleBackColor = true;
            this.btnCloseSetting.Click += new System.EventHandler(this.btnCloseSetting_Click);
            // 
            // equipment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.comboStatusAlat);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnEksport);
            this.Controls.Add(this.btnInputData);
            this.Name = "equipment";
            this.Size = new System.Drawing.Size(1055, 587);
            this.Load += new System.EventHandler(this.equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEksport;
        private System.Windows.Forms.Button btnInputData;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboStatusAlat;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.CheckedListBox checkedListSetting;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseSetting;
    }
}
