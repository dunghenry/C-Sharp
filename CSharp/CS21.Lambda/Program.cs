using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
namespace Lambda
{
    //Lambda
    //delegate action
    //1, (int a, int b) => a + b;

    //delegate func
    //2 (int a, int b) =>{
        //int kq = a + b;
        //return kq;
    // }

    class Program
    {
        static void Main(string[] args)
        {
            Action thongbao;
            thongbao = () => System.Console.WriteLine("Hello moi nguoi!");
            thongbao?.Invoke();

            Action<string, string> action;

            // action = (s) => System.Console.WriteLine($"Chuoi la: {s}"); //~ delegate void Kieu(string s) = Action<string>
            // action = (str, name) => System.Console.WriteLine($"{str}, {name}");
            action = (str, name) => {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Str = " + str);
                System.Console.WriteLine("Name = " + name);
                Console.ResetColor();
            };
            action?.Invoke("Xin chao", "Tran Van Dung");

        
            Func<int, int, int> Sum;
            Sum = (a, b) =>{
                int kq = a + b;
                return kq;
            };

           int a = Sum(2, 3);
           System.Console.WriteLine("Tong la: " + a);


           int[] mang = {10, 25, 30, 35, 40, 45, 50};

        //    var ketqua = mang.Select(
        //        (int x) => {
        //        return Math.Sqrt(x);
        //     }
        //    );
        //    foreach (var result in ketqua)
        //    {
        //        Console.Write(result + " ");
        //    }

           mang.ToList().ForEach(
               (y) => {
                    if(y % 2 != 0)
                        System.Console.WriteLine(y);
                }
           );

        //    var kq = mang.Where(
        //        (x) =>{
        //            return x % 4 == 0;
        //        }
        //    );

           var kq = mang.Where(x => x % 4 == 0);

            foreach (var item in kq){
                System.Console.WriteLine(item);
            }
        }
    }
}
