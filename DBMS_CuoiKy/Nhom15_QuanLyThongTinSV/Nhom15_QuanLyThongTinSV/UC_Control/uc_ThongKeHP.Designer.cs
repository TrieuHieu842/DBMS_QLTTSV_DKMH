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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTKHP
            // 
            this.dgvTKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHP.Location = new System.Drawing.Point(87, 84);
            this.dgvTKHP.Name = "dgvTKHP";
            this.dgvTKHP.RowHeadersWidth = 62;
            this.dgvTKHP.RowTemplate.Height = 28;
            this.dgvTKHP.Size = new System.Drawing.Size(795, 488);
            this.dgvTKHP.TabIndex = 0;
            // 
            // uc_ThongKeHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTKHP);
            this.Name = "uc_ThongKeHP";
            this.Size = new System.Drawing.Size(960, 622);
            this.Load += new System.EventHandler(this.uc_ThongKeHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKHP;
    }
}
