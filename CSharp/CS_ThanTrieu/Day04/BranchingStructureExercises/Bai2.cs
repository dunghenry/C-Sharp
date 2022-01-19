using System;
namespace Controls
{
    public class Bai2
    {
        static void Main(){
            System.Console.Write("Nhap so n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n % 2 == 0){
                System.Console.WriteLine($"{n} la so chan!!", n);
            }
            else{
                System.Console.WriteLine($"So {n} la so le!!", n);
            }
            if(n % 3 == 0){
                System.Console.WriteLine($"{n} chia hết cho 3!!", n);
            }
            else{
                System.Console.WriteLine($"So {n} khong chia het cho 3!!", n);
            }
        }
    }
}