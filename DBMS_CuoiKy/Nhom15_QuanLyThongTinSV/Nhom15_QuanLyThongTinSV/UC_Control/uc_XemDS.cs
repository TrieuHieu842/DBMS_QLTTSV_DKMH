using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    public partial class uc_XemDS : UserControl
    {
        string connectionString = @"Data Source=MSI\TRIEUHIEU;Initial Catalog=QLSV_DoAn;Integrated Security=True";
        private string maGV;
        private string maHP;
        public uc_XemDS(string MaGV)
        {
            InitializeComponent();
            this.maGV = MaGV;
        }


        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maHP))
                {
                    MessageBox.Show("Vui lòng chọn học phần trước khi xuất danh sách!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Tạo ứng dụng Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Không bật Excel lên khi chạy

                // Tạo workbook và worksheet
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "DanhSach_" + maHP;

                // Xuất tiêu đề cột từ DataGridView
                for (int i = 1; i <= dgv_QLHP.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgv_QLHP.Columns[i - 1].HeaderText;
                }

                // Xuất dữ liệu từng dòng
                for (int i = 0; i < dgv_QLHP.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_QLHP.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv_QLHP.Rows[i].Cells[j].Value?.ToString();
                    }
                }
                // Lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu danh sách sinh viên";
                saveFileDialog.FileName = $"DanhSach_{maHP}.xlsx";
                saveFileDialog.InitialDirectory = @"D:\MonHoc\N3_HK1\DBMS\DBMS_CuoiKy";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất danh sách ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Đóng workbook và ứng dụng Excel
                workbook.Close();
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uc_XemDS_Load(object sender, EventArgs e)
        {
            btnXem.Visible = true;
            string sql = "sp_LayDSHPGV";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaGV", maGV);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                        dgv_QLHP.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
         
        }

        private void dgv_QLHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXem.Visible = false;
            lblSiso.Visible = true;
            if (e.RowIndex >= 0 && dgv_QLHP.Columns[e.ColumnIndex].Name == "btnXem")
            {
                string maHP = dgv_QLHP.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();
                this.maHP = maHP;
                string sql = "sp_XemSinhVienTrongLop";
                try
                {
                    using (SqlConnection conn= new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand( sql, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_QLHP.DataSource = dt;
                        lblSiso.Text = "Số lượng sinh viên: "+ ((dgv_QLHP.RowCount) - 1).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi "+ ex.Message);
                }
            }
        }
    }
}
