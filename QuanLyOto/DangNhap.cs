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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True");
        private void Txtidngdung_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_dangnhap_Click(object sender, EventArgs e)
        {
            if (this.txtDangNhap.Text.Length == 0 || this.txtMatKhau.Text.Length == 0)
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
                    this.Hide();
                    HeThong ht = new HeThong();
                    ht.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài Khoản và Mật khẩu sai ! \nVui lòng nhập lại !", "Thông báo");
                }
            }
        }

        private void Button_thoatdangnhap_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
