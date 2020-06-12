using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyOto
{
    class Soluong
    {
        private string MaNV;
        private string TenNV;
        private int SoLuong;
        private int DoanhThu;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int DoanhThu1 { get => DoanhThu; set => DoanhThu = value; }

        public Soluong(string MaNV, string TenNV, int SoLuong, int DoanhThu)
    {
        this.MaNV = MaNV;
        this.TenNV = TenNV;
        this.SoLuong = SoLuong;
        this.DoanhThu = DoanhThu;  
    }
    public Soluong(DataRow row)
    {
        this.MaNV = row["MaNV"].ToString();
        this.TenNV = row["TenNV"].ToString();
        this.SoLuong = (int)Convert.ToInt32(row["SoLuong"].ToString());
        this.DoanhThu = (int)Convert.ToInt32(row["DoanhThu"].ToString());
        }
    }
}
