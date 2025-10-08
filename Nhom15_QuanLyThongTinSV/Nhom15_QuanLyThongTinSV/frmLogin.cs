using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Nhom15_QuanLyThongTinSV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Tên đăng nhập chỉ được chứa chữ cái, số và dấu gạch dưới!");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            string connectionString = @"Data Source=MSI\TRIEUHIEU;Initial Catalog=QLSV_DoAn;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SP_LOGIN", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string vaitro = reader["VaiTro"].ToString();
                        string mssv = reader["MaDinhDanh"].ToString();
                        string hoten = reader["HoTen"].ToString();
                        MessageBox.Show("Đăng nhập thành công!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                        // Mở form chính
                        frmDKMH f = new frmDKMH(mssv, hoten, vaitro);
                        this.Hide();
                        f.Size = new Size(950, 550);
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
