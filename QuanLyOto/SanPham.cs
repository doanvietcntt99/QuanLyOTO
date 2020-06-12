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
    public partial class SanPham : Form
    {
        SqlDataAdapter da = null;
        DataSet ds = null;
        public SanPham()
        {
            InitializeComponent();
            load();
        }

        void load()
        { 
            renew();
        }
        void renew()
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            string sqlcmd = "select * from SANPHAM";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "SANPHAM");
            dgv_SanPham.DataSource = ds.Tables["SANPHAM"];
        }
        
        private void SanPham_Load(object sender, EventArgs e)
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
         
            DataTable dt1 = new DataTable();
            conn.Open();
            SqlDataAdapter nv2 = new SqlDataAdapter("Select MaNhom From SANPHAM", conn);
            nv2.Fill(dt1);
            conn.Close();
            try
            {
                CBB_MN.DataSource = dt1;
                CBB_MN.DisplayMember = "MaNhom";
                CBB_MN.ValueMember = "MaNhom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }

            DataTable dt3 = new DataTable();
            conn.Open();
            SqlDataAdapter nv4 = new SqlDataAdapter("Select distinct MaNCC From SANPHAM", conn);
            nv4.Fill(dt3);
            conn.Close();
            try
            {
                cbB_NCC.DataSource = dt3;
                cbB_NCC.DisplayMember = "MaNCC";
                cbB_NCC.ValueMember = "MaNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            DataTable dt4 = new DataTable();
            conn.Open();
            SqlDataAdapter nv5 = new SqlDataAdapter("Select TenSP From SANPHAM", conn);
            nv5.Fill(dt4);
            conn.Close();
            try
            {
                comboBox_timkiem.DataSource = dt4;
                comboBox_timkiem.DisplayMember = "TenSP";
                comboBox_timkiem.ValueMember = "TenSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sqlconn);
                string cmd = "select * from SANPHAM where MaSP in(select MASP from SANPHAM where TenSP like N'%" + comboBox_timkiem.Text + "%' ) ";
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "SANPHAM");
                dgv_SanPham.DataSource = ds.Tables["SANPHAM"];
            }
            catch
            {
                MessageBox.Show("Tìm kiếm thất bại!");
            }
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

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cbB_MSP.Text = dgv_SanPham[0, dgv_SanPham.CurrentRow.Index].Value.ToString();
            CBB_MN.Text = dgv_SanPham[1, dgv_SanPham.CurrentRow.Index].Value.ToString();
            TenSanPham.Text = dgv_SanPham[2, dgv_SanPham.CurrentRow.Index].Value.ToString();
            cbB_NCC.Text = dgv_SanPham[7, dgv_SanPham.CurrentRow.Index].Value.ToString();
            TXT_DVT.Text = dgv_SanPham[3, dgv_SanPham.CurrentRow.Index].Value.ToString();
            TXT_GIABAN.Text = dgv_SanPham[5, dgv_SanPham.CurrentRow.Index].Value.ToString();
            TXT_GIANHAP.Text = dgv_SanPham[6, dgv_SanPham.CurrentRow.Index].Value.ToString();
            TXT_SL.Text = dgv_SanPham[4, dgv_SanPham.CurrentRow.Index].Value.ToString();
        }

        private void button_bh_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sqlconn);
                conn.Open();
                string Insert_Query = "UPDATE SANPHAM SET MaSP ='" + cbB_MSP.Text + "', MaNhom='" + CBB_MN.Text + "', TenSP = N'" + TenSanPham.Text + "', DonViTinh=N'" + TXT_DVT.Text + "', SLTon='" + TXT_SL.Text + "',GiaBan='" + TXT_GIABAN.Text + "', GiaNhap = '" + TXT_GIANHAP.Text + "', MaNCC = '"+ cbB_NCC.Text + "' where MaSP ='" + cbB_MSP.Text + "'";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                conn.Close();
                renew();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void button_bh_them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sqlconn);
                conn.Open();
                string Insert_Query = "INSERT SANPHAM VALUES ('" + cbB_MSP.Text + "', '" + CBB_MN.Text + "',N'" + TenSanPham.Text + "',N'" + TXT_DVT.Text + "', '" + TXT_SL.Text + "','" + TXT_GIABAN.Text + "','" + TXT_GIANHAP.Text + "','" + cbB_NCC.Text + "')";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                conn.Close();
                renew();
            }
            catch
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void button_bh_xoa_Click(object sender, EventArgs e)
        {
            if (cbB_MSP.Text != "")
            {
                try
                {
                    string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(sqlconn);
                    conn.Open();
                    string Insert_Query = "delete from SANPHAM where MaSP='" + cbB_MSP.Text + "'";
                    SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    conn.Close();
                    renew();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
                MessageBox.Show("Không có sản phẩm để xóa");
        }
    }
}
