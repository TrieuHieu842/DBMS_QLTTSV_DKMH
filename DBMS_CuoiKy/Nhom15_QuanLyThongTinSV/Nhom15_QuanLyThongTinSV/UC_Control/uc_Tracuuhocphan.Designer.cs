namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    partial class uc_Tracuuhocphan
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblMahocphan = new System.Windows.Forms.Label();
            this.txtMaHocphan = new System.Windows.Forms.TextBox();
            this.lblTenhocphan = new System.Windows.Forms.Label();
            this.txtTenHocPhan = new System.Windows.Forms.TextBox();
            this.dgv_tracuuhocphan = new System.Windows.Forms.DataGridView();
            this.lblTittle = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tracuuhocphan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(561, 103);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(155, 62);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tra cứu";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMahocphan
            // 
            this.lblMahocphan.AutoSize = true;
            this.lblMahocphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMahocphan.Location = new System.Drawing.Point(31, 64);
            this.lblMahocphan.Name = "lblMahocphan";
            this.lblMahocphan.Size = new System.Drawing.Size(214, 29);
            this.lblMahocphan.TabIndex = 1;
            this.lblMahocphan.Text = "Nhập mã học phần";
            // 
            // txtMaHocphan
            // 
            this.txtMaHocphan.Location = new System.Drawing.Point(275, 67);
            this.txtMaHocphan.Name = "txtMaHocphan";
            this.txtMaHocphan.Size = new System.Drawing.Size(207, 26);
            this.txtMaHocphan.TabIndex = 2;
            // 
            // lblTenhocphan
            // 
            this.lblTenhocphan.AutoSize = true;
            this.lblTenhocphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenhocphan.Location = new System.Drawing.Point(31, 100);
            this.lblTenhocphan.Name = "lblTenhocphan";
            this.lblTenhocphan.Size = new System.Drawing.Size(214, 29);
            this.lblTenhocphan.TabIndex = 3;
            this.lblTenhocphan.Text = "Nhập tên học phần";
            // 
            // txtTenHocPhan
            // 
            this.txtTenHocPhan.Location = new System.Drawing.Point(275, 103);
            this.txtTenHocPhan.Name = "txtTenHocPhan";
            this.txtTenHocPhan.Size = new System.Drawing.Size(207, 26);
            this.txtTenHocPhan.TabIndex = 4;
            // 
            // dgv_tracuuhocphan
            // 
            this.dgv_tracuuhocphan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tracuuhocphan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tracuuhocphan.Location = new System.Drawing.Point(38, 242);
            this.dgv_tracuuhocphan.Name = "dgv_tracuuhocphan";
            this.dgv_tracuuhocphan.RowHeadersWidth = 62;
            this.dgv_tracuuhocphan.RowTemplate.Height = 28;
            this.dgv_tracuuhocphan.Size = new System.Drawing.Size(948, 452);
            this.dgv_tracuuhocphan.TabIndex = 5;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTittle.Location = new System.Drawing.Point(33, 199);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(229, 29);
            this.lblTittle.TabIndex = 6;
            this.lblTittle.Text = "Danh sách học phần";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbHocKy.Location = new System.Drawing.Point(275, 137);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(207, 28);
            this.cbHocKy.TabIndex = 7;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocKy.Location = new System.Drawing.Point(31, 137);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(85, 29);
            this.lblHocKy.TabIndex = 8;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(256, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tra cứu dễ dàng – Định hướng rõ ràng";
            // 
            // uc_Tracuuhocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.dgv_tracuuhocphan);
            this.Controls.Add(this.txtTenHocPhan);
            this.Controls.Add(this.lblTenhocphan);
            this.Controls.Add(this.txtMaHocphan);
            this.Controls.Add(this.lblMahocphan);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "uc_Tracuuhocphan";
            this.Size = new System.Drawing.Size(1090, 740);
            this.Load += new System.EventHandler(this.uc_Tracuuhocphan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tracuuhocphan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMahocphan;
        private System.Windows.Forms.TextBox txtMaHocphan;
        private System.Windows.Forms.Label lblTenhocphan;
        private System.Windows.Forms.TextBox txtTenHocPhan;
        private System.Windows.Forms.DataGridView dgv_tracuuhocphan;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label label1;
    }
}
