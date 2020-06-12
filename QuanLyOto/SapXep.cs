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
    public partial class SapXep : Form
    {
        public SapXep()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<Soluong> QuickSort(List<Soluong> a, int left, int right)
        {
            int i, j;
            int x;
            x = a[(left + right) / 2].DoanhThu1;
            i = left; j = right;
            while (i < j)
            {
                while (a[i].DoanhThu1 > x) i++;
                while (a[j].DoanhThu1 < x) j--;
                if (i<=j)
                {
                    Soluong tam;
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
        List<Soluong> QuickSort2(List<Soluong> a, int left, int right)
        {
            int i, j;
            int x;
            x = a[(left + right) / 2].SoLuong1;
            i = left; j = right;
            while (i < j)
            {
                while (a[i].SoLuong1 > x) i++;
                while (a[j].SoLuong1 < x) j--;
                if (i <= j)
                {
                    Soluong tam;
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
        List<DanhSach> QuickSort(List<DanhSach> a, int left, int right)
        {
            int i, j;
            int x;
            x = a[(left + right) / 2].TongTienBan1;
            i = left; j = right;
            while (i < j)
            {
                while (a[i].TongTienBan1 > x) i++;
                while (a[j].TongTienBan1 < x) j--;
                if (i <= j)
                {
                    DanhSach tam;
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

        private void SapXep_Load(object sender, EventArgs e)
        {
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void HệThốngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong ht = new HeThong();
            ht.ShowDialog();

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

        private void NhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap ncc = new NhaCungCap();
            ncc.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham SP = new SanPham();
            SP.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien NV = new NhanVien();
            NV.ShowDialog();
        }
        void update ()
        {
            lbTop1.Text = dgv_SapXep[1, 0].Value.ToString();
            lbTop2.Text = dgv_SapXep[1, 1].Value.ToString();
            lbTop3.Text = dgv_SapXep[1, 2].Value.ToString();
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (SapXepTheoDoanhThu.Checked == false && SapXepTheoSoLuong.Checked == false)
            {
                conn.Open();
                string sqlcmd = "select * from Soluongdonhang";
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Soluongdonhang");
                dgv_SapXep.DataSource = ds.Tables["Soluongdonhang"];
                conn.Close();
                update();
            }
            else
                if (SapXepTheoDoanhThu.Checked == true)
            {
                conn.Open();
                string sqlcmd = "select * from Soluongdonhang";
                List<Soluong> ListSL = new List<Soluong>();
                SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                foreach (DataRow items in ds.Rows)
                {
                    Soluong SL = new Soluong(items);
                    ListSL.Add(SL);
                }
                dgv_SapXep.DataSource = QuickSort(ListSL, 0, ListSL.Count - 1);
                conn.Close();
                update();
            }
            else
                if (SapXepTheoSoLuong.Checked == true)
            {
                conn.Open();
                string sqlcmd = "select * from Soluongdonhang";
                List<Soluong> ListSL = new List<Soluong>();
                SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                foreach (DataRow items in ds.Rows)
                {
                    Soluong SL = new Soluong(items);
                    ListSL.Add(SL);
                }
                dgv_SapXep.DataSource = QuickSort2(ListSL, 0, ListSL.Count - 1);
                conn.Close();
                update();
            }
        }

        private void dgv_SapXep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tennvkiemtra = dgv_SapXep[0, dgv_SapXep.CurrentRow.Index].Value.ToString();
            conn.Open();
            string Query = "select * from HoaDonBan where MaNV = (select MaNV from Soluongdonhang where MaNV = '" + tennvkiemtra + "')";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "HoaDonBan");
            dgv_danhsach.DataSource = ds.Tables["HoaDonBan"];
            conn.Close();
        }
        
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            if (TongTienBan.Checked == true)
            {
                string tennvkiemtra = dgv_SapXep[0, dgv_SapXep.CurrentRow.Index].Value.ToString();
                conn.Open();
                string Query = "select * from HoaDonBan where MaNV = (select MaNV from Soluongdonhang where MaNV = '" + tennvkiemtra + "') ";
                List<DanhSach> ListDS = new List<DanhSach>();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                foreach (DataRow items in ds.Rows)
                {
                    DanhSach DS = new DanhSach(items);
                    ListDS.Add(DS);
                }
                dgv_danhsach.DataSource = QuickSort(ListDS, 0, ListDS.Count - 1);
                conn.Close();
            }
            else
            {
                if (NgayBan.Checked == true)
                {
                    string tennvkiemtra = dgv_SapXep[0, dgv_SapXep.CurrentRow.Index].Value.ToString();
                    conn.Open();
                    string Query = "select * from HoaDonBan where MaNV = (select MaNV from Soluongdonhang where MaNV = '" + tennvkiemtra + "') order by NgayBan";
                    SqlDataAdapter da = new SqlDataAdapter(Query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "HoaDonBan");
                    dgv_danhsach.DataSource = ds.Tables["HoaDonBan"];
                    conn.Close();
                }
            }

        }
    }
}
