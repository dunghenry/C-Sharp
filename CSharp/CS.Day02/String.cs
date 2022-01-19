using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic02
{
    class String
    {
        static void Main()
        {
            string ten = "Dung";
            Console.WriteLine(ten);
            StringBuilder thongbao = new StringBuilder();
            thongbao.Append("Xin");
            thongbao.Append(" chao cac ban");
            thongbao.Replace("Xin chao", "Chao mung");
            Console.WriteLine(thongbao);
        }
    }
}
