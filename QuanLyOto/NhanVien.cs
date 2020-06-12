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
    public partial class NhanVien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
        SqlDataAdapter da = null;
        DataSet ds = null;
        public NhanVien()
        {
            InitializeComponent();
            renew();
        }
        void renew()
        {
            conn.Open();
            string sqlcmd = "select * from NhanVien";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "NhanVien");
            dataGridView_nv.DataSource = ds.Tables["NhanVien"];
            conn.Close();
        }
    
        private void NhanVien_Load(object sender, EventArgs e)
        {
        }

        private void TextBox_nv_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_bh_them_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string Insert_Query = "INSERT NHANVIEN (MaNV, MaCV, TenNV, DiaChiNV, SDTNV, GioiTinh, NgaySinh) VALUES ('" + cbB_MNV.Text + "', N'" + textBox_nv_macv.Text + "', N'" + cbB_TNV.Text + "', N'" + textBox_nv_dc.Text + "','" + textBox_nv_sdt.Text + "', N'" + textBox_nv_gt.Text + "','" + this.dateTimePicker_ns.Text + "')";
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

        private void Button_bh_xoa_Click(object sender, EventArgs e)
        {
            if (cbB_MNV.Text != "")
            {
                try
                {
                    conn.Open();
                    string Insert_Query = "delete from NHANVIEN where MaNV='" + cbB_MNV.Text + "'";
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
                MessageBox.Show("Không có nhân viên để xóa");
        }

        private void TextBox_nv_tennv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong ht = new HeThong();
            ht.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmd = "select * from NHANVIEN where MaNV in(select MaNV from NHANVIEN where TenNV like N'%" + comboBox_timkiem.Text + "%' ) ";
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "sinhvien");
                dataGridView_nv.DataSource = ds.Tables["sinhvien"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Tìm kiếm thất bại!");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            renew();
        }

        private void cbB_MNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            cbB_MNV.Text = dataGridView_nv[0, dataGridView_nv.CurrentRow.Index].Value.ToString();
            cbB_TNV.Text = dataGridView_nv[2, dataGridView_nv.CurrentRow.Index].Value.ToString();
            textBox_nv_macv.Text = dataGridView_nv[1, dataGridView_nv.CurrentRow.Index].Value.ToString();
            textBox_nv_sdt.Text = dataGridView_nv[4, dataGridView_nv.CurrentRow.Index].Value.ToString();
            textBox_nv_gt.Text = dataGridView_nv[5, dataGridView_nv.CurrentRow.Index].Value.ToString();
            dateTimePicker_ns.Text = dataGridView_nv[6, dataGridView_nv.CurrentRow.Index].Value.ToString();
            textBox_nv_dc.Text = dataGridView_nv[3, dataGridView_nv.CurrentRow.Index].Value.ToString();
        }

        private void button_bh_sua_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                string Insert_Query = "UPDATE NHANVIEN SET MANV ='" + cbB_MNV.Text + "', MACV='" + textBox_nv_macv.Text + "', TENNV = N'" + cbB_TNV.Text + "', DiaChiNV=N'" + textBox_nv_dc.Text + "',SDTNV = '"+ textBox_nv_sdt.Text+ "', GioiTinh=N'" + textBox_nv_gt.Text + "',NgaySinh='" + this.dateTimePicker_ns.Text + "' where MaNV ='" + cbB_MNV.Text + "'";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                conn.Close();
                renew();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void dataGridView_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_bh_luu_Click(object sender, EventArgs e)
        {

        }

        private void button_bh_luu_Click_1(object sender, EventArgs e)
        {
            if (comboBox_timkiem.Text!="")
            {
                try
                {
                    conn.Open();
                    string cmd = "select * from NHANVIEN where MaNV in(select MaNV from NHANVIEN where TenNV like N'%" + comboBox_timkiem.Text + "%' ) ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "sinhvien");
                    dataGridView_nv.DataSource = ds.Tables["sinhvien"];
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm thất bại!");
                }
            }
            else
                MessageBox.Show("Chưa nhập thông tin tìm kiếm!");
        }

        private void label_nv_gt_Click(object sender, EventArgs e)
        {

        }
    }
}
