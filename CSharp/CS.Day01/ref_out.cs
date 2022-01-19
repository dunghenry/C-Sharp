using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class ref_out
    {
        public static void binhphuong(int x)
        {
            x *= x;
            Console.WriteLine(x);
        }
        public static void BINHPHUONG(ref int x)
        {
            x *= x;
            Console.WriteLine(x);
        }
        public static void BP(ref int x, out int kq)
        {
            kq = x * x;
            Console.WriteLine(kq);
        }
        static void Main()
        {
            //Tham trị là sau khi tính toán vẫn giữ nguyên gía trị
            //Tham chiếu là dùng ref phải đc khởi tạo trước ròi ms truền cho phuong thức mà sau khi tính toán giá trị của biến bị thay đổi
           //Khi dùng out biến ko cần khởi tạo trước khi truyền cho phương thức nhưng bên trong phương thức  bắt buộc phải gán gái trị cho biến
            int a = 2;
            binhphuong(a);
            Console.WriteLine(a);
            int b = 4;
            BINHPHUONG(ref b);
            Console.WriteLine(b);
            //Khi dùng tham chiếu sau khi tính toán b = BINHPHUONG(ref b)
            int y = 3;
            int c;
            BP(ref y, out c);
        }
    }
}
