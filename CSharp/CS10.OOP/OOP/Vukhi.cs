using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Vukhi
    {
        public string name = "Ten sung";
        public int dosatthuong = 0;

        //Cách 1
        public Vukhi()
        {
            Console.WriteLine("Khoi tao!!!");
        }

        //Cách 2
        public Vukhi(string name, int dosatthuong)
        {
            this.name = name;
            this.dosatthuong = dosatthuong;
        }

        //Tạo phương thức sát thương
        public void DoSatThuong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;
        }

        //Tạo phương thức tấn công
        public void TanCong()
        {
            Console.Write(name + ":\t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
        
        //Phương thức set get
        public int SatThuong
        {
            //Toán tử gán
            set
            {
                Console.WriteLine("Thực hiện set!!!");
                Console.WriteLine("Value: " + value);
                //Ta có thể gán giát trị cho độ sát thương
                dosatthuong = value;
            }
            //Truy cập
            get
            {
                // return 10;
                return dosatthuong;
            }
        }

        public string Noisanxuat { set; get; }
    }
}
