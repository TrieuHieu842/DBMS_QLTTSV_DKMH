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
    public partial class uc_ThongKeHP : UserControl
    {
        string connectionString = @"Data Source=MSI\TRIEUHIEU; Initial Catalog=QLSV_DoAn; Integrated Security =True;";
        public uc_ThongKeHP()
        {
            InitializeComponent();
        }

        private void uc_ThongKeHP_Load(object sender, EventArgs e)
        {
            string sql = "sp_ThongKeHP";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTKHP.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public static implicit operator uc_ThongKeHP(uc_QLHP v)
        {
            throw new NotImplementedException();
        }
    }
}
