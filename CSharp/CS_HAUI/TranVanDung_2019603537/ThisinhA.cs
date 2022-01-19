using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranVanDung_2019603537_proj51
{
    class ThisinhA
    {
        private int _SoBaoDanh;
        public int SoBaoDanh
        {
            get { return _SoBaoDanh; }
            set { _SoBaoDanh = value; }
        }
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private double _DToan;
        public double DToan
        {
            get { return _DToan; }
            set { _DToan = value; }
        }
        private double _DLy;
        public double DLy
        {
            get { return _DLy; }
            set { _DLy = value; }
        }
        private double _DHoa;
        public double DHoa
        {
            get { return _DHoa; }
            set { _DHoa = value; }
        }
        private double _DUuTien;
        public double DUuTien
        {
            get { return _DUuTien; }
            set { _DUuTien = value; }
        }
        public ThisinhA() { }
        public ThisinhA(int sbd, string hoten, string diachi, double dtoan, double dly, double dhoa, double duutien)
        {
            this.SoBaoDanh = sbd;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.DToan = dtoan;
            this.DLy = dly;
            this.DHoa = dhoa;
            this.DUuTien = duutien;
        }
        public virtual double TongDiem()
        {
            return this.DToan + this.DLy + this.DHoa + DUuTien;
        }
        public double TongDiem(double dtoan, double dly, double dhoa, double duutien)
        {
            return dtoan + dly + dhoa + duutien;
        }

        public override string ToString()
        {
            return string.Format("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-15}{6,-18}{7,-15}", this.SoBaoDanh, this.HoTen, this.DiaChi, this.DToan, this.DLy, this.DHoa, this.DUuTien, this.TongDiem());
        }
    }
}
