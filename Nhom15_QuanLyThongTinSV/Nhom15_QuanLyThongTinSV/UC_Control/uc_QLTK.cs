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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    public partial class uc_QLTK : UserControl
    {
        string connectionString= @"Data Source=MSI\TRIEUHIEU; Initial Catalog=QLSV_DoAn; Integrated Security =True;";
        public uc_QLTK()
        {
            InitializeComponent();
        }
        private void SetPlaceholder(System.Windows.Forms.TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        private void uc_QLTK_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtTenDN, "Nhập tên đăng nhập");
            SetPlaceholder(txtMatKhau, "Nhập mật khẩu");
            SetPlaceholder(txtHoTen, "Nhập họ tên");
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM v_ChiTietTaiKhoan"; 
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (!dt.Columns.Contains("TrangThaiDangKy"))
                    dt.Columns.Add("TrangThaiDangKy", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    string maDN = row["MaDinhDanh"].ToString();

                    if (maDN.StartsWith("SV"))
                    {
                        bool daDK = KiemTraDaDangKy(maDN);
                        row["TrangThaiDangKy"] = daDK ? "Đã đăng ký" : "Chưa đăng ký";
                    }
                    else
                    {
                        row["TrangThaiDangKy"] = "Không áp dụng";
                    }
                }

                dgvQLTK.DataSource = dt;   
            }
        }
        private bool KiemTraDaDangKy(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT dbo.fn_KiemTraDaDangKy(@MaSV)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    object result = cmd.ExecuteScalar();
                    return (result != DBNull.Value) && Convert.ToBoolean(result);
                }
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string role=cbRole.Text.Trim();
            string maDinhDanh = tenDN.ToUpper();
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenDN", tenDN);
                        cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                        cmd.Parameters.AddWithValue("@HoTen", hoten);
                        cmd.Parameters.AddWithValue("@VaiTro", role);
                        cmd.Parameters.AddWithValue("@MaDinhDanh", maDinhDanh);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            uc_QLTK_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQLTK.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDinhDanh = dgvQLTK.SelectedRows[0].Cells["MaDinhDanh"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_XoaTaiKhoan", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaDinhDanh", maDinhDanh);

                            object resultRow = cmd.ExecuteScalar();
                            int rows = (resultRow != null) ? Convert.ToInt32(resultRow) : 0;

                            if (rows > 0)
                            {
                                MessageBox.Show("Xóa tài khoản thành công!");
                                uc_QLTK_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tài khoản để xóa!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
