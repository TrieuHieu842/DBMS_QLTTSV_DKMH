using Nhom15_QuanLyThongTinSV.UC_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom15_QuanLyThongTinSV
{
    public partial class frmDKMH : Form
    {
        string connectionString = @"Data Source=MSI\TRIEUHIEU; Initial Catalog=QLSV_DoAn; Integrated Security =True;";
        private string mssv;
        private string hoten;
        private string vaitro;
        public frmDKMH(string mssv, string hoten, string vaitro)
        {
            InitializeComponent();
            this.mssv = mssv;
            this.hoten = hoten;
            this.vaitro = vaitro;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangkyHocphan_Click(object sender, EventArgs e)
        {
            panel_DKMH.Controls.Clear();
            uc_Dangkymonhoccs ucDKMH=new uc_Dangkymonhoccs(mssv,hoten);
            ucDKMH.Dock = DockStyle.Fill;
            panel_DKMH.Controls.Add(ucDKMH);


        }

        private void btnTracuuHocphan_Click(object sender, EventArgs e)
        {
            panel_DKMH.Controls.Clear();
            uc_Tracuuhocphan ucTracuu = new uc_Tracuuhocphan();
            ucTracuu.Dock = DockStyle.Fill;
            panel_DKMH.Controls.Add(ucTracuu);
        }

        private void btnHocPhanDaDangky_Click(object sender, EventArgs e)
        {
            panel_DKMH.Controls.Clear();
            uc_danhsachhocphandangky ucDSHP = new uc_danhsachhocphandangky(mssv,hoten);
            ucDSHP.Dock = DockStyle.Fill;
            panel_DKMH.Controls.Add(ucDSHP);
        }

        private void frmDKMH_Load(object sender, EventArgs e)
        {
            lblMSSV.Text =  mssv;
            lblHovaten.Text = hoten;
            if (vaitro == "SinhVien")
            {
                btnDangkyHocphan.Visible = true;
                btnHocPhanDaDangky.Visible = true;
                btnTracuuHocphan.Visible = true;
            }
            else if (vaitro == "GiangVien")
            {
                btnXemDSLop.Visible = true;
            }
            else if (vaitro == "Admin")
            {
                btnQLHP.Visible = true;
                btnThongKe.Visible = true;
            }

        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnXemDSLop_Click(object sender, EventArgs e)
        {
            panel_DKMH.Controls.Clear();
            uc_XemDS uc_XemDS = new uc_XemDS(mssv);
            uc_XemDS.Dock= DockStyle.Fill;
            panel_DKMH.Controls.Add(uc_XemDS);

        }

        private void btnQLHP_Click(object sender, EventArgs e)
        {
            panel_DKMH.Controls.Clear();
            uc_QLHP uc_QLHP = new uc_QLHP();
            uc_QLHP.Dock = DockStyle.Fill;
            panel_DKMH.Controls.Add(uc_QLHP);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel_DKMH.Controls.Clear();
            uc_ThongKeHP uc_TKHP = new uc_ThongKeHP();
            uc_TKHP.Dock = DockStyle.Fill;
            panel_DKMH.Controls.Add(uc_TKHP);
        }
    }
}
