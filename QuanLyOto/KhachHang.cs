using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyOto
{
    class KhachHang
    {
        private string MaKH;
        private string TenKH;
        private string DiaChiKH;
        private string SDTKH;
        private int TongTien;


        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string DiaChiKH1 { get => DiaChiKH; set => DiaChiKH = value; }
        public string SDTKH1 { get => SDTKH; set => SDTKH = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }
        public KhachHang(string MaKH, string TenKH, string DiaChiKH, string SDTKH, int TongTien)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.DiaChiKH = DiaChiKH;
            this.SDTKH = SDTKH;
            this.TongTien = TongTien;
        }
        public KhachHang(DataRow row)
        {
            this.MaKH = row["MaKh"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.DiaChiKH = row["DiaChiKH"].ToString();
            this.SDTKH = row["SDTKH"].ToString();
            this.TongTien = (int)Convert.ToInt32(row["TongTien"].ToString());

        }
    }
}
