using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranVanDung_537_C2
{
    class Nguoi
    {
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _GioiTinh;
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private int _Tuoi;
        public int Tuoi
        {
            get { return _Tuoi; }
            set { _Tuoi = value; }
        }
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public Nguoi(string hoten, string gioitinh, int tuoi, string diachi)
        {
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.Tuoi = tuoi;
            this.DiaChi = diachi;
        }
        public Nguoi() { }
        public override string ToString()
        {
            return string.Format("\n{0,-20}{1,-10}{2,-10}{3,-20}", this.HoTen, this.GioiTinh, this.Tuoi, this.DiaChi);
        }

    }

}
