using System;
namespace BranchingStructureExercises
{
    public class Bai5
    {
        static void Main(){
            System.Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap so d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int min = default;
            if(a == b && b == c && c == d){
                System.Console.WriteLine("Khong co so nho nhat!!!");
            }
            else{
                min = a;
                if(min > b){
                    min = b;
                }
                if(min > c){
                    min = c;
                }
                if(min > d){
                    min = d;
                }
            }
            System.Console.WriteLine("Min la: " + min);
        }
    }
}