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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
        private void btnDMK_Click(object sender, EventArgs e)
        {
            if (this.txtDangNhap.TextLength == 0 || this.txtMatKhau.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập tài khoản ! ");
            }
            else
            {
                conn.Open();
                string sqlcmd = "select count(*) from TaiKhoan where taikhoan='" + txtDangNhap.Text + "' and matkhau='" + txtMatKhau.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                string kq = cmd.ExecuteScalar().ToString();
                conn.Close();
                if (kq == "1")
                {
                    if (txtMatKhauMoi.Text == txtMatKhauMoi2.Text)
                    {
                        conn.Open();
                        string Insert_Query = "update TaiKhoan set matkhau = '" + txtMatKhauMoi.Text + "' where taikhoan ='" + txtDangNhap.Text + "'";
                        SqlCommand thucthi = new SqlCommand(Insert_Query, conn);
                        thucthi.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Hide();
                        DangNhap DN = new DangNhap();
                        DN.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tài Khoản và Mật khẩu sai ! \nVui lòng nhập lại !", "Thông báo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong HT = new HeThong();
            HT.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
