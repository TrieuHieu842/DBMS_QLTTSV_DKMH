namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    partial class uc_XemDS
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
            this.dgv_QLHP = new System.Windows.Forms.DataGridView();
            this.lblSiso = new System.Windows.Forms.Label();
            this.btnXuatDS = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QLHP
            // 
            this.dgv_QLHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnXem});
            this.dgv_QLHP.Location = new System.Drawing.Point(28, 82);
            this.dgv_QLHP.Name = "dgv_QLHP";
            this.dgv_QLHP.RowHeadersWidth = 62;
            this.dgv_QLHP.RowTemplate.Height = 28;
            this.dgv_QLHP.Size = new System.Drawing.Size(951, 442);
            this.dgv_QLHP.TabIndex = 2;
            this.dgv_QLHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLHP_CellContentClick);
            // 
            // lblSiso
            // 
            this.lblSiso.AutoSize = true;
            this.lblSiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSiso.Location = new System.Drawing.Point(29, 22);
            this.lblSiso.Name = "lblSiso";
            this.lblSiso.Size = new System.Drawing.Size(67, 29);
            this.lblSiso.TabIndex = 4;
            this.lblSiso.Text = "Sĩ số";
            this.lblSiso.Visible = false;
            // 
            // btnXuatDS
            // 
            this.btnXuatDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatDS.Location = new System.Drawing.Point(741, 22);
            this.btnXuatDS.Name = "btnXuatDS";
            this.btnXuatDS.Size = new System.Drawing.Size(164, 40);
            this.btnXuatDS.TabIndex = 5;
            this.btnXuatDS.Text = "Xuất ra File";
            this.btnXuatDS.UseVisualStyleBackColor = true;
            this.btnXuatDS.Click += new System.EventHandler(this.btnXuatDS_Click);
            // 
            // btnXem
            // 
            this.btnXem.HeaderText = "";
            this.btnXem.MinimumWidth = 8;
            this.btnXem.Name = "btnXem";
            this.btnXem.Text = "Xem DS";
            this.btnXem.UseColumnTextForButtonValue = true;
            this.btnXem.Visible = false;
            this.btnXem.Width = 150;
            // 
            // uc_XemDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.btnXuatDS);
            this.Controls.Add(this.lblSiso);
            this.Controls.Add(this.dgv_QLHP);
            this.Name = "uc_XemDS";
            this.Size = new System.Drawing.Size(993, 665);
            this.Load += new System.EventHandler(this.uc_XemDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_QLHP;
        private System.Windows.Forms.Label lblSiso;
        private System.Windows.Forms.Button btnXuatDS;
        private System.Windows.Forms.DataGridViewButtonColumn btnXem;
    }
}
