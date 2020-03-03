namespace wwtSystem
{
    partial class ProsesWWT
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
            this.btnInput = new System.Windows.Forms.Button();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SulfuricAcid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SodTiosulfat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KarbonAktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metanol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solar = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button10.TabIndex = 10;
            this.button10.Text = "Eksport Data";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(162, 27);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(120, 35);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = "Input Data";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
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
            this.bunifuDropdown1.TabIndex = 9;
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
            this.SulfuricAcid,
            this.SodTiosulfat,
            this.KarbonAktif,
            this.Kapur,
            this.PAC,
            this.Metanol,
            this.Solar,
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
            this.dataGridView1.TabIndex = 8;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 80;
            // 
            // SulfuricAcid
            // 
            this.SulfuricAcid.HeaderText = "Sulfuric Acid (Kg)";
            this.SulfuricAcid.MinimumWidth = 6;
            this.SulfuricAcid.Name = "SulfuricAcid";
            this.SulfuricAcid.Width = 130;
            // 
            // SodTiosulfat
            // 
            this.SodTiosulfat.HeaderText = "Sod. Tiosulfat (Kg)";
            this.SodTiosulfat.MinimumWidth = 6;
            this.SodTiosulfat.Name = "SodTiosulfat";
            this.SodTiosulfat.Width = 145;
            // 
            // KarbonAktif
            // 
            this.KarbonAktif.HeaderText = "Karbon Aktif (Kg)";
            this.KarbonAktif.MinimumWidth = 6;
            this.KarbonAktif.Name = "KarbonAktif";
            this.KarbonAktif.Width = 130;
            // 
            // Kapur
            // 
            this.Kapur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Kapur.HeaderText = "Kapur (Kg)";
            this.Kapur.MinimumWidth = 6;
            this.Kapur.Name = "Kapur";
            this.Kapur.Width = 110;
            // 
            // PAC
            // 
            this.PAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PAC.HeaderText = "PAC (Kg)";
            this.PAC.MinimumWidth = 6;
            this.PAC.Name = "PAC";
            this.PAC.Width = 97;
            // 
            // Metanol
            // 
            this.Metanol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Metanol.HeaderText = "Metanol (L)";
            this.Metanol.MinimumWidth = 6;
            this.Metanol.Name = "Metanol";
            this.Metanol.Width = 116;
            // 
            // Solar
            // 
            this.Solar.HeaderText = "Solar (L)";
            this.Solar.MinimumWidth = 6;
            this.Solar.Name = "Solar";
            this.Solar.Width = 80;
            // 
            // Option
            // 
            this.Option.HeaderText = "Option";
            this.Option.MinimumWidth = 6;
            this.Option.Name = "Option";
            this.Option.Width = 75;
            // 
            // ProsesWWT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProsesWWT";
            this.Size = new System.Drawing.Size(1055, 587);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnInput;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SulfuricAcid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SodTiosulfat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KarbonAktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metanol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solar;
        private System.Windows.Forms.DataGridViewLinkColumn Option;
    }
}
