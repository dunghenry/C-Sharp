using System;
namespace BranchingStructureExercises
{
    public class Bai6
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
            int max = default;
            int min = default;
            int max2 = default;
            if(a == b && b == c && c == d){
                System.Console.WriteLine("Khong co so lon thu hai!!!");
            }
            else{
                // Tìm max
                max = a;
                if(max < b){
                    max = b;
                }
                if(max < c){
                    max = c;
                }
                if(max < d){
                    max = d;
                }
                // Tìm min
                min = a;
                if (min > b)
                {
                    min = b;
                }
                if (min > c)
                {
                    min = c;
                }
                if (min > d)
                {
                    min = d;
                }
                // Ví dụ: 1 2 3 4 max=d; min = a 
                max2 = min;
                if(max2 < a && a != max){
                    max2 = a;
                }
                if(max2 < b && b != max){
                    max2 = b;
                }
                if(max2 < c && c != max){
                    max2 = c;
                }
                if(max2 < d && d != max){
                    max2 = d;
                }
            }
            System.Console.WriteLine("Max thu hai la: " + max2);
        }
    }
}