using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyOto
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap Fdn = new DangNhap();
            Fdn.ShowDialog();
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void Button_tcbanhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang bh = new BanHang();
            bh.ShowDialog();
        }

        private void Button_tcnhaphang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nh = new NhapHang();
            nh.ShowDialog();
        }

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        private void BánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang bh = new BanHang();
            bh.ShowDialog();
        }

        private void NhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nh = new NhapHang();
            nh.ShowDialog();
        }

        private void Button_tcdoanhthu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoanhThu dt = new DoanhThu();
            dt.ShowDialog();
        }

        private void ThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTin tt = new ThongTin();
            tt.ShowDialog();
        }

        private void DoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoanhThu dt = new DoanhThu();
            dt.ShowDialog();
        }

        private void NhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap ncc = new NhaCungCap();
            ncc.ShowDialog();

        }

        private void BtnThuHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            SapXep SX = new SapXep();
            SX.ShowDialog();
        }

        private void button_tchanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham SP = new SanPham();
            SP.ShowDialog();
        }

        private void button_tchoatdong_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        private void thứHạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham SP = new SanPham();
            SP.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau DMK = new DoiMatKhau();
            DMK.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhGiaKhachHang frm = new DanhGiaKhachHang();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SapXep frm = new SapXep();
            frm.ShowDialog();
        }

        private void hoạtĐộngBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
