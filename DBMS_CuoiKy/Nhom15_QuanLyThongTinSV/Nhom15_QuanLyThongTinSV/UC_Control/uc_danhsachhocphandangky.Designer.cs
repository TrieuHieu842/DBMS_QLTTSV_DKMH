namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    partial class uc_danhsachhocphandangky
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
            this.dgv_danhsachhocphandadangky = new System.Windows.Forms.DataGridView();
            this.btnHuyDK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblDanhsach = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHovaTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachhocphandadangky)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_danhsachhocphandadangky
            // 
            this.dgv_danhsachhocphandadangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachhocphandadangky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnHuyDK});
            this.dgv_danhsachhocphandadangky.Location = new System.Drawing.Point(25, 149);
            this.dgv_danhsachhocphandadangky.Name = "dgv_danhsachhocphandadangky";
            this.dgv_danhsachhocphandadangky.RowHeadersWidth = 62;
            this.dgv_danhsachhocphandadangky.RowTemplate.Height = 28;
            this.dgv_danhsachhocphandadangky.Size = new System.Drawing.Size(871, 487);
            this.dgv_danhsachhocphandadangky.TabIndex = 0;
            this.dgv_danhsachhocphandadangky.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachhocphandadangky_CellContentClick);
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.HeaderText = "HuyDK";
            this.btnHuyDK.MinimumWidth = 8;
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.Text = "Hủy đăng ký";
            this.btnHuyDK.UseColumnTextForButtonValue = true;
            this.btnHuyDK.Width = 150;
            // 
            // lblDanhsach
            // 
            this.lblDanhsach.AutoSize = true;
            this.lblDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhsach.Location = new System.Drawing.Point(211, 15);
            this.lblDanhsach.Name = "lblDanhsach";
            this.lblDanhsach.Size = new System.Drawing.Size(621, 46);
            this.lblDanhsach.TabIndex = 1;
            this.lblDanhsach.Text = "Danh sách học phần đã đăng ký";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMSSV.Location = new System.Drawing.Point(19, 81);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(102, 32);
            this.lblMSSV.TabIndex = 2;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblHovaTen
            // 
            this.lblHovaTen.AutoSize = true;
            this.lblHovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHovaTen.Location = new System.Drawing.Point(357, 81);
            this.lblHovaTen.Name = "lblHovaTen";
            this.lblHovaTen.Size = new System.Drawing.Size(142, 32);
            this.lblHovaTen.TabIndex = 3;
            this.lblHovaTen.Text = "Họ và tên:";
            // 
            // uc_danhsachhocphandangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.lblHovaTen);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblDanhsach);
            this.Controls.Add(this.dgv_danhsachhocphandadangky);
            this.Name = "uc_danhsachhocphandangky";
            this.Size = new System.Drawing.Size(1035, 716);
            this.Load += new System.EventHandler(this.uc_danhsachhocphandangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachhocphandadangky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_danhsachhocphandadangky;
        private System.Windows.Forms.Label lblDanhsach;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHovaTen;
        private System.Windows.Forms.DataGridViewButtonColumn btnHuyDK;
    }
}
