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
    public partial class DanhGiaKhachHang : Form
    {
        public DanhGiaKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
        void update()
        {
            lbTop1.Text = dgv_KH[1, 0].Value.ToString();
            lbTop2.Text = dgv_KH[1, 1].Value.ToString();
            lbTop3.Text = dgv_KH[1, 2].Value.ToString();
        }
        List<KhachHang> QuickSort(List<KhachHang> a, int left, int right)
        {
            int i, j;
            int x;
            x = a[(left + right) / 2].TongTien1;
            i = left; j = right;
            while (i < j)
            {
                while (a[i].TongTien1 > x) i++;
                while (a[j].TongTien1 < x) j--;
                if (i <= j)
                {
                    KhachHang tam;
                    tam = a[i];
                    a[i] = a[j];
                    a[j] = tam;
                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(a, left, j);
            if (i < right)
                QuickSort(a, i, right);
            return a;
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (Khong.Checked == true || DoanhThu.Checked == false && Khong.Checked == false)
            {
                conn.Open();
                string sqlcmd = "select * from Khachhang";
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Khachhang");
                dgv_KH.DataSource = ds.Tables["Khachhang"];
                conn.Close();
                update();
            }
            else 
                if (DoanhThu.Checked == true)
                {
                    conn.Open();
                    string sqlcmd = "select * from Khachhang";
                    List<KhachHang> ListSL = new List<KhachHang>();
                    SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow items in ds.Rows)
                    {
                        KhachHang SL = new KhachHang(items);
                        ListSL.Add(SL);
                    }
                    dgv_KH.DataSource = QuickSort(ListSL, 0, ListSL.Count - 1);
                    conn.Close();
                    update();
                }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTin frm = new ThongTin();
            frm.ShowDialog();

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoanhThu frm = new DoanhThu();
            frm.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham SP = new SanPham();
            SP.ShowDialog();
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

        private void hệThốngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau DMK = new DoiMatKhau();
            DMK.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap Fdn = new DangNhap();
            Fdn.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }
    }
}
