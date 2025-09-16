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
    public partial class uc_Tracuuhocphan : UserControl
    {
        string connectionString = @"Data Source=MSI\TRIEUHIEU; Initial Catalog=QLSV_DoAn; Integrated Security=True;";
        public uc_Tracuuhocphan()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHP = string.IsNullOrWhiteSpace(txtMaHocphan.Text) ? null : txtMaHocphan.Text.Trim();
            string tenHP = string.IsNullOrWhiteSpace(txtTenHocPhan.Text) ? null : txtTenHocPhan.Text.Trim();
            string hocKy = (cbHocKy.SelectedItem == null || cbHocKy.SelectedItem.ToString() == "Tất cả")
                           ? null
                           : cbHocKy.SelectedItem.ToString();
            string query = "sp_TraCuuHocPhan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHP", string.IsNullOrWhiteSpace(maHP) ? (object)DBNull.Value : maHP);
                cmd.Parameters.AddWithValue("@TenHP", string.IsNullOrWhiteSpace(tenHP) ? (object)DBNull.Value : tenHP);
                cmd.Parameters.AddWithValue("@HocKy", string.IsNullOrWhiteSpace(hocKy) ? (object)DBNull.Value : hocKy);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_tracuuhocphan.DataSource = dt;
            }
        }
    }
}
