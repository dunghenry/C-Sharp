using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic02
{
    class Vukhi
    {
        //Dữ liệu
        public string name = "Dung";
        int dosatthuong = 0;
        //Thuộc tính
        public string Noisanxuat { set; get; }
        public int Satthuong
        {
            //Gán
            set
            {
                dosatthuong = value;
            }
            //truy cập
            get {
                return dosatthuong;
            }
        }
        public Vukhi()
        {
            //Console.WriteLine("This is hello");
            dosatthuong = 1;
        }
        public Vukhi(string name, int _dosatthuong)
        {
            this.name = name;
            this.dosatthuong = _dosatthuong;
        }
        public void doSatThuong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;
        }
        public void tanCong()
        {
            Console.Write(this.name);
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
    
}
