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
    public partial class BanHang : Form
    {
        SqlDataAdapter da = null;
        DataSet ds = null;
        public BanHang()
        {
            InitializeComponent();
            load();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
        void load()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
            conn.Open();
            string sqlcmd = "select HDBan.MaHD, HDBan.MaSp, SANPHAM.TenSP, HDBan.SLBan, HDBan.DonGiaBan, HDBan.ThanhTien from HDBan, SANPHAM where HDBan.MaSP = SANPHAM.MaSP";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "HDBan");
            dataGridView_bh.DataSource = ds.Tables["HDBan"];
            conn.Close();
        }
        void renew()
        {
            conn.Open();
            string sqlcmd = "select HDBan.MaHD, HDBan.MaSp, SANPHAM.TenSP, HDBan.SLBan, HDBan.DonGiaBan, HDBan.ThanhTien from HDBan, SANPHAM where HDBan.MaSP = SANPHAM.MaSP";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "HDBan");
            dataGridView_bh.DataSource = ds.Tables["HDBan"];
            conn.Close();
        }
        bool exit;
        DataTable sp2 = new DataTable();
        HoaDonBan hdban1 = new HoaDonBan();

        private void BanHang_Load(object sender, EventArgs e)
        {
            dataGridView_bh.Columns[0].HeaderText = "Mã Hóa Đơn";
            dataGridView_bh.Columns[1].HeaderText = "Mã Sản Phẩm";
            dataGridView_bh.Columns[2].HeaderText = "Tên Sản Phẩm";
            dataGridView_bh.Columns[3].HeaderText = "Số Lượng Bán";
            dataGridView_bh.Columns[4].HeaderText = "Đơn giá bán";
            dataGridView_bh.Columns[5].HeaderText = "Thành Tiền";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From KHACH_HANG", conn);
            da.Fill(dt);
            try
            {
                comboBox_bh_tenkh.DataSource = dt;
                comboBox_bh_tenkh.DisplayMember = "TenKH";
                comboBox_bh_tenkh.ValueMember = "MaKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu của Khách Hàng", ex.ToString());
            }
            DataTable de = new DataTable();
            SqlDataAdapter nv = new SqlDataAdapter("Select * From NHANVIEN", conn);
            nv.Fill(de);
            try
            {
                comboBox_bh_tennv.DataSource = de;
                comboBox_bh_tennv.DisplayMember = "TenNV";
                comboBox_bh_tennv.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu của Nhân Viên",ex.ToString());
            }
            DataTable dt2 = new DataTable();
            SqlDataAdapter masp = new SqlDataAdapter("Select distinct * From SANPHAM", conn);
            masp.Fill(dt2);
            try
            {
                cbB_MSP.DataSource = dt2;
                cbB_MSP.DisplayMember = "MaSP";
                cbB_MSP.ValueMember = "MaSP";
            }
            catch (Exception ex)
            {
               MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            
        }
        void tinhtien()
        {
            int n = int.Parse(txtSL.Text);
            int m = int.Parse(TXTDG.Text);
            int tich = n * m;
            if (textBox_tongtien.Text == "")
            {
                textBox_tongtien.Text += tich;
            }
            else
            {
                int tiencu = int.Parse(textBox_tongtien.Text);
                int tongtien;
                tongtien = tiencu + tich;
                textBox_tongtien.Text = "";
                textBox_tongtien.Text += tongtien;
            }
        }
        private void Button_bh_quaylai_Click(object sender, EventArgs e)
        {
            if (exit == false)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn chưa thanh toán hóa đơn ! \n Bạn có muốn lưu ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                if (thongbao == DialogResult.Yes)
                    MessageBox.Show("Vui lòng nhấn nút thanh toán !");
                else
                {
                    this.Hide();
                    HeThong ht = new HeThong();
                    ht.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                HeThong ht = new HeThong();
                ht.ShowDialog();
            }
        }

        private void Button_bh_luu_Click(object sender, EventArgs e)
        {
            textBox_tongtien.Text = "0";
        }
        private void button_bh_them_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Insert_Query = "INSERT HDBan VALUES ('" + comboBox_bh_mahd.Text + "',N'" + cbB_MSP.Text + "', '" + txtSL.Text + "', '" + TXTDG.Text + "', '" + textBox_tongtien.Text + "')";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                conn.Close();
                renew();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_bh_thanhtoan_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(textBox_tongtien.Text);
            int khachdua = int.Parse(textBox_khachdua.Text);
            textBox_tienthua.Text = "";
            int tinhtoan = khachdua - tong;
            textBox_tienthua.Text += tinhtoan;
            if (tinhtoan >= 0)
            {
                conn.Open();
                string Query = "insert into HoaDonBan values (N'" + comboBox_bh_mahd.Text + "',N'" + comboBox_bh_tennv.SelectedValue + "',N'" + comboBox_bh_tenkh.SelectedValue + "','" + dateTimePicker_bh.Text + "','" + textBox_tongtien.Text + "')";
                SqlCommand xuly = new SqlCommand(Query, conn);
                xuly.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thanh Toán Thành Công!");
                exit = true;
            }
            else
            {
                MessageBox.Show("Thanh Toán thất bại!");
                exit = false;
            }
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void button_bh_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                string Insert_Query = "delete HDBan where MaHD ='" + comboBox_bh_mahd.Text + "'";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công!");
                load();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!");
            }

            
        }

        private void dataGridView_bh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_bh_mahd.Text = dataGridView_bh[0, dataGridView_bh.CurrentRow.Index].Value.ToString();
            cbB_MSP.Text = dataGridView_bh[1, dataGridView_bh.CurrentRow.Index].Value.ToString();
            txtSL.Text = dataGridView_bh[3, dataGridView_bh.CurrentRow.Index].Value.ToString();
            TXTDG.Text = dataGridView_bh[4, dataGridView_bh.CurrentRow.Index].Value.ToString();
        }

        private void button_bh_sua_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                string Insert_Query = "UPDATE HDBan SET MaHD ='" + comboBox_bh_mahd.Text + "', MaSP='" + cbB_MSP.Text + "', SLBan = N'" + txtSL.Text + "', DonGiaBan=N'" + TXTDG.Text + "', ThanhTien='" + textBox_tongtien.Text + "' where MaHD ='" + comboBox_bh_mahd.Text + "'";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thành công!");
                renew();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void comboBox_bh_tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_bh_tennv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
