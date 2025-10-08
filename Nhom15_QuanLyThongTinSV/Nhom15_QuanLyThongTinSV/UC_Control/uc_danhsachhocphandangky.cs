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
                string query = "SELECT * FROM dbo.fn_LayDSHPDaDK(@MaSV)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
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
            layTongTinChi();
        }
        private void layTongTinChi()
        {
            if (dgv_danhsachhocphandadangky.Rows.Count == 0)
            {
                lblTongTinChi.Text = "Tổng tín chỉ: 0";
                return;
            }

            // Gom các cặp HocKy + NamHoc duy nhất từ DataGridView
            var hocKyNamHocList = new HashSet<(string HocKy, string NamHoc)>();

            foreach (DataGridViewRow row in dgv_danhsachhocphandadangky.Rows)
            {
                if (row.Cells["HocKy"].Value != null && row.Cells["NamHoc"].Value != null)
                {
                    string hocKy = row.Cells["HocKy"].Value.ToString();
                    string namHoc = row.Cells["NamHoc"].Value.ToString();
                    hocKyNamHocList.Add((hocKy, namHoc));
                }
            }

            StringBuilder sb = new StringBuilder();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (var hkNh in hocKyNamHocList)
                {
                    string query = "SELECT dbo.fn_TongSoTinChiSV(@MaSV, @HocKy, @NamHoc)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", mssv);
                        cmd.Parameters.AddWithValue("@HocKy", hkNh.HocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", hkNh.NamHoc);

                        object result = cmd.ExecuteScalar();
                        int tongTinChi = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                        sb.AppendLine($"- {hkNh.HocKy} - {hkNh.NamHoc}: {tongTinChi} tín chỉ");
                    }
                }

                conn.Close();
            }

            // Hiển thị tổng cho từng học kỳ/năm học
            lblTongTinChi.Text = "Tổng tín chỉ:\n" + sb.ToString();
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

                            object procresult = cmd.ExecuteScalar(); // đọc SELECT @@ROWCOUNT
                            int rows = (procresult != null) ? Convert.ToInt32(procresult) : 0;

                            if (rows > 0)
                            {
                                MessageBox.Show($"Đã hủy đăng ký học phần {maHP}!", "Thông báo");
                                // Cập nhật lại danh sách
                                LoadData();
                                layTongTinChi();

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
