using System;
using System.Linq;

namespace CS.OnTapLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action  = () => Console.WriteLine("Hello world");
            action?.Invoke();

            Action<string> action1 = (string str)=>{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(str);
                Console.ResetColor();
            };
            action1?.Invoke("Kaka");

            Func<int, int, int> func = (int a, int b) =>{
                int kq = a + b;
                return kq;
            };
            Console.WriteLine(func?.Invoke(5, 10));


            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //Lấy ra các phần tử chia hết cho 2 trong mảng
            arr.ToList().ForEach(
                item =>{
                    if(item % 2 == 0){
                        Console.WriteLine(item);
                    }
                }
            );
            
            // lấy ra các phần tử chia hết cho 4 gtrong mảng
           var kq = arr.Where(x => x % 4 == 0);

            foreach (var item in kq){
                System.Console.WriteLine(item);
            }

            //tính căn bậc hai của các phần tử trong mảng
            var ketqua = arr.Select(
               (int x) => {
               return Math.Sqrt(x);
            }
           );
           foreach (var result in ketqua)
           {
               Console.Write(result + " ");
           }

        }
    }
}
