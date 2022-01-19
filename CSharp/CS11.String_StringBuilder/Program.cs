using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string loichao;
            string ten = "Tran Van Dung";
            loichao = "Xin chao";
            string thongbao = loichao + " " + ten;

            Console.WriteLine(thongbao);

            string chuoi = "\"Hello\"";
            string chuoimoi = "Hello World \t cac \n \\ban";
            string str = @"Xin
            chao tat
            ca
            cac ban";

            Console.WriteLine(chuoi);
            Console.WriteLine(chuoimoi);
            Console.WriteLine(str);

            int age = 20;
            Console.WriteLine($"Tuoi cua ban la {age}");

            int length = chuoimoi.Length;
            Console.WriteLine(length);

            for (var i = 0; i < length; i++)
            {
                char c = chuoimoi[i];
                Console.Write(c + " ");
            }

            foreach (var item in ten){
                Console.WriteLine(item);
            }

            System.Console.WriteLine(ten.ToUpper());
            System.Console.WriteLine(ten.ToLower());

            //Trim Cắt chuỗi
            string name = "   Tran Van Dung**     *";
            System.Console.WriteLine(name.Trim()); 

            //!Cắt khoảng trắng(space) ở đầu dòng
            System.Console.WriteLine(name.TrimStart());

            // Cắt kí tự * ở cuối dòng
            System.Console.WriteLine(name.TrimEnd('*'));

            //Thay thế chuỗi
            System.Console.WriteLine(name.Replace("Tran", "Quach"));


            //? Insert

            string xinchao = "Xin chao, cac ban";
            System.Console.WriteLine(xinchao.Insert(10, "tat"));
            System.Console.WriteLine(xinchao.Insert(0, "Hi")); //Chèn vào đầu chuỗi

            //Chuỗi con
            System.Console.WriteLine(xinchao.Substring(10)); // cac ban
            System.Console.WriteLine(xinchao.Substring(10, 4)); // cac

            //Remove
            System.Console.WriteLine(name.Remove(12)); //Tran Van
            System.Console.WriteLine(name.Remove(12, 2)); // xóa 2 kí tự

            //Tách chuỗi thành mảng các chuỗi con
            string str1 = "Hello cac ban";
            string[] str2 = str1.Split(" ");
            foreach (string item in str2){
                System.Console.WriteLine(item);
            }

            string[]  arr = {"Tran", "Van", "Dung"};
            string str3 = string.Join(" ", arr);
            System.Console.WriteLine(str3);


            StringBuilder ThongBao = new StringBuilder();
            ThongBao.Append("Xin");
            ThongBao.Append(" chao cac ban");
            ThongBao.Replace("Xin chao", "Chao mung");
            System.Console.WriteLine(ThongBao);
           
        }
    }
}
