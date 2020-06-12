using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyOto
{
    class DanhSach
    {
        private string MaHD;
        private string MaNV;
        private string MaKH;
        private DateTime NgayBan;
        private int TongTienBan;

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public DateTime NgayBan1 { get => NgayBan; set => NgayBan = value; }
        public int TongTienBan1 { get => TongTienBan; set => TongTienBan = value; }

        public DanhSach(string MaHD, string MaNV, string MaKH, DateTime NgayBan, int TongTienBan)
        {
            this.MaHD = MaHD;
            this.MaNV = MaNV;
            this.MaKH = MaKH;
            this.NgayBan = NgayBan;
            this.TongTienBan = TongTienBan;
        }
        public DanhSach(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.NgayBan = (DateTime)Convert.ToDateTime(row["NgayBan"].ToString());
            this.TongTienBan = (int)Convert.ToInt32(row["TongTienBan"].ToString());
        }
    }
    
}
