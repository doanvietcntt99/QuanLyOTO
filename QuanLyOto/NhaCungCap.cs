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
    public partial class NhaCungCap : Form
    {
        SqlDataAdapter da = null;
        DataSet ds = null;
        public NhaCungCap()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            string sqlcmd = "select * from NhaCungCap";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "NhaCungCap");
            dataGridView_ncc.DataSource = ds.Tables["NhaCungCap"];
            textBox_ncc_mancc.DataBindings.Add(new Binding("Text", dataGridView_ncc.DataSource, "MaNCC"));
            textBox_ncc_tenncc.DataBindings.Add(new Binding("Text", dataGridView_ncc.DataSource, "TenNCC"));
            textBox_ncc_sdt.DataBindings.Add(new Binding("Text", dataGridView_ncc.DataSource, "SDTNCC"));
            textBox_ncc_dc.DataBindings.Add(new Binding("Text", dataGridView_ncc.DataSource, "DiaChiNCC"));
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable de = new DataTable();
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            SqlDataAdapter nv = new SqlDataAdapter("Select TenNCC From NHACUNGCAP", conn);
            nv.Fill(de);
            conn.Close();
            try
            {
                comboBox_timkiem.DataSource = de;
                comboBox_timkiem.DisplayMember = "TenNCC";
                comboBox_timkiem.ValueMember = "TenNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong ht = new HeThong();
            ht.ShowDialog();

        }

        private void DataGridView_ncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sqlconn);
                string cmd = "select * from NHACUNGCAP where MaNCC in(select MaNCC from NHANVIEN where TenNCC like N'%" + comboBox_timkiem.Text + "%' ) ";
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "NHACUNGCAP");
                dataGridView_ncc.DataSource = ds.Tables["NHACUNGCAP"];
            }
            catch
            {
                MessageBox.Show("Tìm kiếm thất bại!");
            }
        }
        void renew()
        {
            string sqlconn = @"Data Source=VIETDD\SQLEXPRESS;Initial Catalog=QuanlyBanOto;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            string sqlcmd = "select * from NhaCungCap";
            da = new SqlDataAdapter(sqlcmd, conn);
            ds = new DataSet();
            da.Fill(ds, "NhaCungCap");
            dataGridView_ncc.DataSource = ds.Tables["NhaCungCap"];
        }
        private void btnhienthi_Click(object sender, EventArgs e)
        {
            renew();
        }
    }
}
