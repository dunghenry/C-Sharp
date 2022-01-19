using System;
namespace BranchingStructureExercises
{
    public class Bai4
    {
        static void Main(){
            System.Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > b){
                System.Console.WriteLine($"{a} > {b}", a, b);
            }
            else if(a < b){
                System.Console.WriteLine($"{a} < {b}", a, b);
            }
            else{
                System.Console.WriteLine($"{a} = {b}", a, b);
            }
        }
    }
}