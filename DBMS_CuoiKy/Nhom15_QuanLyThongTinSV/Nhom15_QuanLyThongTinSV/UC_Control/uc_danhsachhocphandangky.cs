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

namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    public partial class uc_danhsachhocphandangky : UserControl
    {
        private string mssv;
        private string hoTen;
        string connectionString = @"Data Source=MSI\TRIEUHIEU;Initial Catalog=QLSV_DoAn;Integrated Security=True";
        public uc_danhsachhocphandangky(string mssv, string hoten)
        {
            InitializeComponent();
            this.mssv = mssv;
            this.hoTen = hoten;
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "sp_LayDSHPDaDK";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", mssv);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_danhsachhocphandadangky.DataSource = dt;
                }
            }
        }


        private void uc_danhsachhocphandangky_Load(object sender, EventArgs e)
        {
            lblMSSV.Text = "MSSV: " + mssv;
            lblHovaTen.Text = "Họ và tên: " + hoTen;
            LoadData();
        }

        private void dgv_danhsachhocphandadangky_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_danhsachhocphandadangky.Columns[e.ColumnIndex].Name == "btnHuyDK")
            {
                string maHP = dgv_danhsachhocphandadangky.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();
                if (string.IsNullOrEmpty(maHP))
                {
                    MessageBox.Show("Không tìm thấy mã học phần!", "Lỗi");
                    return;
                }
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn hủy đăng ký học phần {maHP} không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string deleteSql = "sp_HuyDangKy";
                            SqlCommand cmd = new SqlCommand(deleteSql, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaSV", mssv);
                            cmd.Parameters.AddWithValue("@MaHP", maHP);

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show($"Đã hủy đăng ký học phần {maHP}!", "Thông báo");
                                // Cập nhật lại danh sách
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu để hủy!", "Thông báo");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi hủy đăng ký: " + ex.Message);
                    }
                }
            }
        }
    }
}
