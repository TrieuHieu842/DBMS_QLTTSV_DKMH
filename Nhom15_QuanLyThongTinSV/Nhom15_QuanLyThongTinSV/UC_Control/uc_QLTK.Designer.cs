namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    partial class uc_QLTK
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
            this.dgvQLTK = new System.Windows.Forms.DataGridView();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLTK
            // 
            this.dgvQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLTK.Location = new System.Drawing.Point(45, 97);
            this.dgvQLTK.Name = "dgvQLTK";
            this.dgvQLTK.RowHeadersWidth = 62;
            this.dgvQLTK.RowTemplate.Height = 28;
            this.dgvQLTK.Size = new System.Drawing.Size(941, 538);
            this.dgvQLTK.TabIndex = 0;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(786, 15);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(167, 37);
            this.btnThemTK.TabIndex = 1;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(45, 20);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(138, 26);
            this.txtTenDN.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(217, 20);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(150, 26);
            this.txtMatKhau.TabIndex = 3;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "GiangVien",
            "SinhVien"});
            this.cbRole.Location = new System.Drawing.Point(621, 20);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(159, 28);
            this.cbRole.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(413, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(184, 26);
            this.txtHoTen.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(786, 56);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 35);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // uc_QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.dgvQLTK);
            this.Name = "uc_QLTK";
            this.Size = new System.Drawing.Size(1043, 635);
            this.Load += new System.EventHandler(this.uc_QLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnXoa;
    }
}
