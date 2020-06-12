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
    public partial class NhapHang : Form
    {
        SqlDataAdapter da = null;
        DataSet ds = null;
        public NhapHang()
        {
            InitializeComponent();
            load();
        }
        void renew()
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            string sqlcmd = "select CTPhieunhap.MaPN, CTPhieunhap.MaSP, SANPHAM.TenSp, CTPhieunhap.SLNhap, CTPhieunhap.DonGiaNhap, CTPhieunhap.ThanhTienNhap from CTPhieuNhap, SANPHAM where CTPhieuNhap.MaSP = SANPHAM.MaSP";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "CTPhieuNhap");
            dgv_nhaphang.DataSource = ds.Tables["CTPhieuNhap"]; ;
        }
        void load()
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            string sqlcmd = "select CTPhieunhap.MaPN, CTPhieunhap.MaSP, SANPHAM.TenSp, CTPhieunhap.SLNhap, CTPhieunhap.DonGiaNhap, CTPhieunhap.ThanhTienNhap from CTPhieuNhap, SANPHAM where CTPhieuNhap.MaSP = SANPHAM.MaSP";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "CTPhieuNhap");
            dgv_nhaphang.DataSource = ds.Tables["CTPhieuNhap"];
            

        }
        
        private void NhapHang_Load(object sender, EventArgs e)
        {
            dgv_nhaphang.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dgv_nhaphang.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgv_nhaphang.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgv_nhaphang.Columns[3].HeaderText = "Số Lượng Nhập";
            dgv_nhaphang.Columns[4].HeaderText = "Đơn Giá Nhập";
            dgv_nhaphang.Columns[5].HeaderText = "Thành Tiền Nhập";
            DataTable dt = new DataTable();
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select MaNCC From NHACUNGCAP", conn);
            da.Fill(dt);
            conn.Close();
            try
            {
                comboBox_nh_mancc.DataSource = dt;
                comboBox_nh_mancc.DisplayMember = "MaNCC";
                comboBox_nh_mancc.ValueMember = "MaNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            DataTable de = new DataTable();
            conn.Open();
            SqlDataAdapter nv = new SqlDataAdapter("Select TenNV From NHANVIEN", conn);
            nv.Fill(de);
            conn.Close();
            try
            {
                comboBox_nh_tennv.DataSource = de;
                comboBox_nh_tennv.DisplayMember = "TenNV";
                comboBox_nh_tennv.ValueMember = "TenNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            DataTable dt2 = new DataTable();
            conn.Open();
            SqlDataAdapter nhom = new SqlDataAdapter("Select TenNhom From NHOMSANPHAM", conn);
            nhom.Fill(dt2);
            conn.Close();
            try
            {
                comboBox_nh_tennhom.DataSource = dt2;
                comboBox_nh_tennhom.DisplayMember = "TenNhom";
                comboBox_nh_tennhom.ValueMember = "TenNhom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            DataTable dt3 = new DataTable();
            conn.Open();
            SqlDataAdapter manhom = new SqlDataAdapter("Select MaNhom From NHOMSANPHAM", conn);
            manhom.Fill(dt3);
            conn.Close();
            try
            {
                comboBox_nh_manhom.DataSource = dt3;
                comboBox_nh_manhom.DisplayMember = "MaNhom";
                comboBox_nh_manhom.ValueMember = "MaNhom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        
        private void DataGridView_nh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_bh_them_Click(object sender, EventArgs e)
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string Insert_Query = "INSERT CTPhieuNhap (MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap) VALUES ('"+ txtPN.Text + "',N'"+ comboBox_nh_mh.Text+ "', '"+ textBox_nh_sl.Text+ "', '" + comboBox_nh_dgn.Text+ "', '"+ txtThanhTien.Text+"')";
            SqlCommand cmd = new SqlCommand(Insert_Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công!");
            conn.Close();
            renew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong ht = new HeThong();
            ht.ShowDialog();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            renew();
        }

        private void button_bh_xoa_Click(object sender, EventArgs e)
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string Insert_Query = "delete from CTPhieuNhap where MaPN ='" + txtPN.Text + "'";
            SqlCommand cmd = new SqlCommand(Insert_Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công!");
            conn.Close();
            renew();
        }

        private void button_bh_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sqlconn);
                conn.Open();
                string Insert_Query = "update CTPhieuNhap set MaPN = '"+ txtPN.Text+ "', MaSP = '"+ comboBox_nh_mh.Text+ "','"+ comboBox_nh_dgn.Text+ "','"+ txtThanhTien.Text + "' where MaPN ='" + txtPN.Text + "'";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                conn.Close();
                renew();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại");
            }
        }

       private void dgv_nhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_nh_mh.Text = dgv_nhaphang[1, dgv_nhaphang.CurrentRow.Index].Value.ToString();
            txtPN.Text = dgv_nhaphang[0, dgv_nhaphang.CurrentRow.Index].Value.ToString();
            textBox_nh_sl.Text = dgv_nhaphang[3, dgv_nhaphang.CurrentRow.Index].Value.ToString();
            comboBox_nh_dgn.Text = dgv_nhaphang[4, dgv_nhaphang.CurrentRow.Index].Value.ToString();
        //    txtThanhTien.Text = dgv_nhaphang[5, dgv_nhaphang.CurrentRow.Index].Value.ToString();
            comboBox_nh_tenhang.Text = dgv_nhaphang[2, dgv_nhaphang.CurrentRow.Index].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_bh_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sqlconn);
                string cmd = "select * from HDbanver1 where MaPN in(select MaPN from HDbanver1 where HDbanver1.TenSP like N'%" + comboBox_nh_tenhang.Text + "%' ) ";
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "CTPhieuNhap");
                dgv_nhaphang.DataSource = ds.Tables["CTPhieuNhap"];
            }
            catch
            {
                MessageBox.Show("Tìm kiếm thất bại!");
            }
        }
        void tinhtien()
        {
            int n = int.Parse(textBox_nh_sl.Text);
            int m = int.Parse(comboBox_nh_dgn.Text);
            int tich = n * m;
            if (txtThanhTien.Text == "")
            {
                txtThanhTien.Text += tich;
            }
            else
            {
                int tiencu = int.Parse(txtThanhTien.Text);
                int tongtien;
                tongtien = tiencu + tich;
                txtThanhTien.Text = "";
                txtThanhTien.Text += tongtien;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            tinhtien();
        }
    }
}
