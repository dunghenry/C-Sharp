using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranVanDung_537_C2
{
    class CongNhan : Nguoi
    {
        private string _TenCongTy;
        public string TenCongTy
        {
            get { return _TenCongTy; }
            set { _TenCongTy = value; }
        }
        private string _NgayVao;
        public string NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }
        private double _HeSoLuong;
        public double HeSoLuong
        {
            get { return _HeSoLuong; }
            set { _HeSoLuong = value; }
        }
        public CongNhan() { }
        public CongNhan(string hoten, string gioitinh, int tuoi, string diachi, string tencongty) : base(hoten, gioitinh, tuoi, diachi)
        {
            this.TenCongTy = tencongty;
        }
        public CongNhan(string hoten, string gioitinh, int tuoi, string diachi, string tencongty, string ngayvao) : base(hoten, gioitinh, tuoi, diachi)
        {
            this.TenCongTy = tencongty;
            this.NgayVao = ngayvao;
        }
        public CongNhan(string hoten, string gioitinh, int tuoi, string diachi, string tencongty, string ngayvao, double hesoluong) : base(hoten, gioitinh, tuoi, diachi)
        {
            this.TenCongTy = tencongty;
            this.NgayVao = ngayvao;
            this.HeSoLuong = hesoluong;
        }
        public override string ToString()
        {
            return string.Format("\n{0,-20}{1,-10}{2,-10}{3,-20}{4,-20}{5,-10}{6,-10}", this.HoTen, this.GioiTinh, this.Tuoi, this.DiaChi, this.TenCongTy, this.NgayVao, this.HeSoLuong);
        }
    }

}
