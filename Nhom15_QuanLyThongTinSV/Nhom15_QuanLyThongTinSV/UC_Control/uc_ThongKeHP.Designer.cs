namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    partial class uc_ThongKeHP
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
            this.dgvTKHP = new System.Windows.Forms.DataGridView();
            this.lblThongKe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTKHP
            // 
            this.dgvTKHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHP.Location = new System.Drawing.Point(36, 84);
            this.dgvTKHP.Name = "dgvTKHP";
            this.dgvTKHP.RowHeadersWidth = 62;
            this.dgvTKHP.RowTemplate.Height = 28;
            this.dgvTKHP.Size = new System.Drawing.Size(897, 516);
            this.dgvTKHP.TabIndex = 0;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongKe.Location = new System.Drawing.Point(36, 28);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(373, 37);
            this.lblThongKe.TabIndex = 1;
            this.lblThongKe.Text = "Thống kê các học phần";
            // 
            // uc_ThongKeHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.dgvTKHP);
            this.Name = "uc_ThongKeHP";
            this.Size = new System.Drawing.Size(960, 622);
            this.Load += new System.EventHandler(this.uc_ThongKeHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKHP;
        private System.Windows.Forms.Label lblThongKe;
    }
}
