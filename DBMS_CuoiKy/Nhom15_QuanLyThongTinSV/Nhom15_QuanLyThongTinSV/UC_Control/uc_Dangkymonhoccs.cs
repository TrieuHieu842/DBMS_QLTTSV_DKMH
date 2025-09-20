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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nhom15_QuanLyThongTinSV.UC_Control
{
    public partial class uc_Dangkymonhoccs : UserControl
    {
        string connectionString = @"Data Source=MSI\TRIEUHIEU; Initial Catalog=QLSV_DoAn; Integrated Security =True;";
        private string mssv;
        private string hoten;
        public uc_Dangkymonhoccs(string mssv, string hoten)
        {
            InitializeComponent();
            this.mssv = mssv;
            this.hoten = hoten;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbNamHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Năm học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNamHoc.Focus();
                return;
            }

            if (cbHocky.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Học kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbHocky.Focus();
                return;
            }
            string namHoc = cbNamHoc.SelectedItem?.ToString();
            string hocKy = cbHocky.SelectedItem?.ToString();
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_LayDSHP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                    cmd.Parameters.AddWithValue("@HocKy", hocKy);
                    
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }

                    dgv_dshp.DataSource = dt;

                    // Xây dựng điều kiện lọc
                    string filter = "";

                    if (!string.IsNullOrEmpty(namHoc))
                        filter += $"NamHoc = '{namHoc}'";

                    if (!string.IsNullOrEmpty(hocKy))
                    {
                        if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                        filter += $"HocKy = '{hocKy}'";
                    }

                    // Áp dụng filter
                    dt.DefaultView.RowFilter = filter;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void dgv_dshp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_dshp.Columns[e.ColumnIndex].Name == "btnDangky")
            {
                string maHP = dgv_dshp.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();
                string namHoc = cbNamHoc.SelectedItem?.ToString();
                string hocKy = cbHocky.SelectedItem?.ToString();

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_DKMH", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaSV", mssv);
                            cmd.Parameters.AddWithValue("@MaHP", maHP);
                            cmd.Parameters.AddWithValue("@HocKy", hocKy);
                            cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Đăng ký thành công học phần {maHP}!", "Thông báo");
                    }
                }
                catch (SqlException ex)
                {
                    // Nếu sp_DKMH raise error (vd: trùng lịch, quá tín chỉ, đầy lớp...) thì báo ra
                    MessageBox.Show("Không thể đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void uc_Dangkymonhoccs_Load(object sender, EventArgs e)
        {

        }
    }
}
