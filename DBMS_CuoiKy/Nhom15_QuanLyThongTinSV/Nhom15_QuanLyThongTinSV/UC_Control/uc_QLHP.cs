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
    public partial class uc_QLHP : UserControl
    {
        string connectionString = @"Data Source=MSI\TRIEUHIEU; Initial Catalog=QLSV_DoAn; Integrated Security =True;";
        public uc_QLHP()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaHP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã học phần!");
                txtMaHP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã môn học!");
                txtMaMH.Focus();
                return false;
            }
            if (cbHocKy.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Học kỳ!");
                cbHocKy.DroppedDown = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNamHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập Năm học!");
                txtNamHoc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGiangVien.Text))
            {
                MessageBox.Show("Vui lòng nhập Giảng viên!");
                txtGiangVien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTKB.Text))
            {
                MessageBox.Show("Vui lòng nhập Thời khóa biểu!");
                txtTKB.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhonghoc.Text))
            {
                MessageBox.Show("Vui lòng nhập Phòng học!");
                txtPhonghoc.Focus();
                return false;
            }
            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            string sql = "sp_ThemHocPhan";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHP", txtMaHP.Text);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@HocKy", int.Parse(cbHocKy.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@NamHoc", txtNamHoc.Text);
                cmd.Parameters.AddWithValue("@GiangVien", txtGiangVien.Text);
                cmd.Parameters.AddWithValue("@ThoiKhoaBieu", txtTKB.Text);
                cmd.Parameters.AddWithValue("@PhongHoc", txtPhonghoc.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm học phần thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            string sql = "sp_SuaHocPhan";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHP", txtMaHP.Text);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@HocKy", int.Parse(cbHocKy.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@NamHoc", txtNamHoc.Text);
                cmd.Parameters.AddWithValue("@GiangVien", txtGiangVien.Text);
                cmd.Parameters.AddWithValue("@ThoiKhoaBieu", txtTKB.Text);
                cmd.Parameters.AddWithValue("@PhongHoc", txtPhonghoc.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa học phần thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "sp_XoaHocPhan";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType =CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHP", txtMaHP.Text);
                

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa học phần thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void uc_QLHP_Load(object sender, EventArgs e)
        {
            string sql = "sp_LayAllDSHP";
            try
            {
                using (SqlConnection conn= new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvQLHP.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvQLHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh click vào header
            {
                DataGridViewRow row = dgvQLHP.Rows[e.RowIndex];

                txtMaHP.Text = row.Cells["MaHP"].Value?.ToString();
                txtMaMH.Text = row.Cells["MaMH"].Value?.ToString();
                cbHocKy.SelectedItem = row.Cells["HocKy"].Value?.ToString();
                txtNamHoc.Text = row.Cells["NamHoc"].Value?.ToString();
                txtGiangVien.Text = row.Cells["GiangVien"].Value?.ToString();
                txtTKB.Text = row.Cells["ThoiKhoaBieu"].Value?.ToString();
                txtPhonghoc.Text = row.Cells["PhongHoc"].Value?.ToString();
            }
        }
        private void LoadData()
        {
            string sql = "sp_LayAllDSHP";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvQLHP.DataSource = dt;
            }
        }

    }
}
