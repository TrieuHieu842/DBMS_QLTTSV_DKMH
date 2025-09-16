namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    partial class uc_QLHP
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvQLHP = new System.Windows.Forms.DataGridView();
            this.lblDSHP = new System.Windows.Forms.Label();
            this.lblChinhSua = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNamhoc = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.lblTKB = new System.Windows.Forms.Label();
            this.txtTKB = new System.Windows.Forms.TextBox();
            this.lblPhongHoc = new System.Windows.Forms.Label();
            this.txtPhonghoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(341, 162);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(174, 53);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(555, 162);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(174, 53);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(771, 162);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(174, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvQLHP
            // 
            this.dgvQLHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLHP.Location = new System.Drawing.Point(25, 292);
            this.dgvQLHP.Name = "dgvQLHP";
            this.dgvQLHP.RowHeadersWidth = 62;
            this.dgvQLHP.RowTemplate.Height = 28;
            this.dgvQLHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLHP.Size = new System.Drawing.Size(934, 405);
            this.dgvQLHP.TabIndex = 3;
            this.dgvQLHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLHP_CellClick);
            // 
            // lblDSHP
            // 
            this.lblDSHP.AutoSize = true;
            this.lblDSHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDSHP.Location = new System.Drawing.Point(20, 240);
            this.lblDSHP.Name = "lblDSHP";
            this.lblDSHP.Size = new System.Drawing.Size(278, 29);
            this.lblDSHP.TabIndex = 4;
            this.lblDSHP.Text = "Danh sách các học phần:";
            this.lblDSHP.Visible = false;
            // 
            // lblChinhSua
            // 
            this.lblChinhSua.AutoSize = true;
            this.lblChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChinhSua.Location = new System.Drawing.Point(3, 4);
            this.lblChinhSua.Name = "lblChinhSua";
            this.lblChinhSua.Size = new System.Drawing.Size(322, 37);
            this.lblChinhSua.TabIndex = 5;
            this.lblChinhSua.Text = "Chỉnh sửa học phần";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(99, 71);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(159, 26);
            this.txtMaHP.TabIndex = 6;
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(20, 73);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(57, 20);
            this.lblMaHP.TabIndex = 7;
            this.lblMaHP.Text = "Mã HP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã MH";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(99, 117);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(159, 26);
            this.txtMaMH.TabIndex = 8;
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbHocKy.Location = new System.Drawing.Point(99, 165);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(159, 28);
            this.cbHocKy.TabIndex = 14;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(20, 170);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(57, 20);
            this.lblHocKy.TabIndex = 15;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // lblNamhoc
            // 
            this.lblNamhoc.AutoSize = true;
            this.lblNamhoc.Location = new System.Drawing.Point(343, 72);
            this.lblNamhoc.Name = "lblNamhoc";
            this.lblNamhoc.Size = new System.Drawing.Size(72, 20);
            this.lblNamhoc.TabIndex = 17;
            this.lblNamhoc.Text = "Năm học";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(435, 70);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(159, 26);
            this.txtNamHoc.TabIndex = 16;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(343, 120);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(84, 20);
            this.lblGiangVien.TabIndex = 19;
            this.lblGiangVien.Text = "Giảng viên";
            // 
            // txtGiangVien
            // 
            this.txtGiangVien.Location = new System.Drawing.Point(435, 118);
            this.txtGiangVien.Name = "txtGiangVien";
            this.txtGiangVien.Size = new System.Drawing.Size(159, 26);
            this.txtGiangVien.TabIndex = 18;
            // 
            // lblTKB
            // 
            this.lblTKB.AutoSize = true;
            this.lblTKB.Location = new System.Drawing.Point(641, 72);
            this.lblTKB.Name = "lblTKB";
            this.lblTKB.Size = new System.Drawing.Size(39, 20);
            this.lblTKB.TabIndex = 21;
            this.lblTKB.Text = "TKB";
            // 
            // txtTKB
            // 
            this.txtTKB.Location = new System.Drawing.Point(733, 70);
            this.txtTKB.Name = "txtTKB";
            this.txtTKB.Size = new System.Drawing.Size(159, 26);
            this.txtTKB.TabIndex = 20;
            // 
            // lblPhongHoc
            // 
            this.lblPhongHoc.AutoSize = true;
            this.lblPhongHoc.Location = new System.Drawing.Point(641, 116);
            this.lblPhongHoc.Name = "lblPhongHoc";
            this.lblPhongHoc.Size = new System.Drawing.Size(85, 20);
            this.lblPhongHoc.TabIndex = 23;
            this.lblPhongHoc.Text = "Phòng học";
            // 
            // txtPhonghoc
            // 
            this.txtPhonghoc.Location = new System.Drawing.Point(733, 114);
            this.txtPhonghoc.Name = "txtPhonghoc";
            this.txtPhonghoc.Size = new System.Drawing.Size(159, 26);
            this.txtPhonghoc.TabIndex = 22;
            // 
            // uc_QLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.lblPhongHoc);
            this.Controls.Add(this.txtPhonghoc);
            this.Controls.Add(this.lblTKB);
            this.Controls.Add(this.txtTKB);
            this.Controls.Add(this.lblGiangVien);
            this.Controls.Add(this.txtGiangVien);
            this.Controls.Add(this.lblNamhoc);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.txtMaHP);
            this.Controls.Add(this.lblChinhSua);
            this.Controls.Add(this.lblDSHP);
            this.Controls.Add(this.dgvQLHP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "uc_QLHP";
            this.Size = new System.Drawing.Size(999, 721);
            this.Load += new System.EventHandler(this.uc_QLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvQLHP;
        private System.Windows.Forms.Label lblDSHP;
        private System.Windows.Forms.Label lblChinhSua;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNamhoc;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.TextBox txtGiangVien;
        private System.Windows.Forms.Label lblTKB;
        private System.Windows.Forms.TextBox txtTKB;
        private System.Windows.Forms.Label lblPhongHoc;
        private System.Windows.Forms.TextBox txtPhonghoc;
    }
}
