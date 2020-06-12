using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyOto
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang bh = new BanHang();
            bh.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nh = new NhapHang();
            nh.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap ncc = new NhaCungCap();
            ncc.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoanhThu dt = new DoanhThu();
            dt.ShowDialog();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sqlcmd = "select * from Soluongdonhang";
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "NhanVien");
            dgv_doanhthu.DataSource = ds.Tables["NhanVien"];
            conn.Close();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham SP = new SanPham();
            SP.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTin TT = new ThongTin();
            TT.ShowDialog();
        }
    }
}
