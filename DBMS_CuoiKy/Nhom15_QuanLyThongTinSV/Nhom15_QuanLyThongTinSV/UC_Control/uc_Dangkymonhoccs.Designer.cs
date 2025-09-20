namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    partial class uc_Dangkymonhoccs
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbHocky = new System.Windows.Forms.ComboBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.dgv_dshp = new System.Windows.Forms.DataGridView();
            this.lblDshp = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.lblHocky = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshp)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(477, 52);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(193, 57);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbHocky
            // 
            this.cbHocky.FormattingEnabled = true;
            this.cbHocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbHocky.Location = new System.Drawing.Point(183, 83);
            this.cbHocky.Name = "cbHocky";
            this.cbHocky.Size = new System.Drawing.Size(221, 28);
            this.cbHocky.TabIndex = 1;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Items.AddRange(new object[] {
            "2025-2026",
            "2024-2025",
            "2023-2024",
            "2022-2023"});
            this.cbNamHoc.Location = new System.Drawing.Point(183, 40);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(221, 28);
            this.cbNamHoc.TabIndex = 2;
            // 
            // dgv_dshp
            // 
            this.dgv_dshp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dshp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dshp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDangky});
            this.dgv_dshp.Location = new System.Drawing.Point(54, 180);
            this.dgv_dshp.Name = "dgv_dshp";
            this.dgv_dshp.RowHeadersWidth = 62;
            this.dgv_dshp.RowTemplate.Height = 28;
            this.dgv_dshp.Size = new System.Drawing.Size(997, 460);
            this.dgv_dshp.TabIndex = 3;
            this.dgv_dshp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dshp_CellContentClick);
            // 
            // lblDshp
            // 
            this.lblDshp.AutoSize = true;
            this.lblDshp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDshp.Location = new System.Drawing.Point(48, 134);
            this.lblDshp.Name = "lblDshp";
            this.lblDshp.Size = new System.Drawing.Size(291, 32);
            this.lblDshp.TabIndex = 4;
            this.lblDshp.Text = "Danh sách học phần";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNamHoc.Location = new System.Drawing.Point(52, 40);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(115, 29);
            this.lblNamHoc.TabIndex = 5;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // lblHocky
            // 
            this.lblHocky.AutoSize = true;
            this.lblHocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocky.Location = new System.Drawing.Point(52, 80);
            this.lblHocky.Name = "lblHocky";
            this.lblHocky.Size = new System.Drawing.Size(91, 29);
            this.lblHocky.TabIndex = 6;
            this.lblHocky.Text = "Học kỳ:";
            // 
            // btnDangky
            // 
            this.btnDangky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btnDangky.HeaderText = "Đăng ký";
            this.btnDangky.MinimumWidth = 8;
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseColumnTextForButtonValue = true;
            this.btnDangky.Width = 73;
            // 
            // uc_Dangkymonhoccs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.lblHocky);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblDshp);
            this.Controls.Add(this.dgv_dshp);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.cbHocky);
            this.Controls.Add(this.btnTim);
            this.Name = "uc_Dangkymonhoccs";
            this.Size = new System.Drawing.Size(1085, 667);
            this.Load += new System.EventHandler(this.uc_Dangkymonhoccs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbHocky;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.DataGridView dgv_dshp;
        private System.Windows.Forms.Label lblDshp;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblHocky;
        private System.Windows.Forms.DataGridViewButtonColumn btnDangky;
    }
}
