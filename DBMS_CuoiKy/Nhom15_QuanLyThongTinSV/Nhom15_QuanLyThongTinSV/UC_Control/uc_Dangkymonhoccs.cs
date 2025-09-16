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
            string namHoc = cbNamHoc.SelectedItem?.ToString();
            string hocKy = cbHocky.SelectedItem?.ToString();

            if (e.RowIndex >= 0 && dgv_dshp.Columns[e.ColumnIndex].Name == "btnDangky")
            {
                string maHP = dgv_dshp.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // 1. Gọi sp_datDieuKien để kiểm tra
                        using (SqlCommand checkCmd = new SqlCommand("sp_datDieuKien", conn))
                        {
                            checkCmd.CommandType = CommandType.StoredProcedure;

                            checkCmd.Parameters.AddWithValue("@MaSV", mssv);
                            checkCmd.Parameters.AddWithValue("@MaHP", maHP);
                            checkCmd.Parameters.AddWithValue("@NamHoc", namHoc);
                            checkCmd.Parameters.AddWithValue("@HocKy", hocKy);

                            SqlParameter ketQuaParam = new SqlParameter("@KetQua", SqlDbType.NVarChar, 100);
                            ketQuaParam.Direction = ParameterDirection.Output;
                            checkCmd.Parameters.Add(ketQuaParam);

                            // Thực thi
                            checkCmd.ExecuteNonQuery();

                            string ketQua = ketQuaParam.Value?.ToString();

                            if (ketQua == "DaDangKy")
                            {
                                MessageBox.Show("Bạn đã đăng ký học phần này rồi!", "Thông báo");
                            }
                            else if (ketQua != null && ketQua.StartsWith("Đủ điều kiện"))
                            {
                                // 2. Thực hiện đăng ký
                                using (SqlCommand insertCmd = new SqlCommand("sp_DKMH", conn))
                                {
                                    insertCmd.CommandType = CommandType.StoredProcedure;
                                    insertCmd.Parameters.AddWithValue("@MaSV", mssv);
                                    insertCmd.Parameters.AddWithValue("@MaHP", maHP);
                      

                                    insertCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show($"Đăng ký thành công học phần {maHP}!", "Thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Không cho phép: " + ketQua);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message);
                }
            }

        }
    }
}
