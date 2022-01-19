using System;
namespace BranchingStructureExercises
{
    public class Bai9
    {
        static void Main(){
            System.Console.Write("Nhaap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a == 0){
                if(b == 0){
                    System.Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else{
                    System.Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else{
                System.Console.WriteLine("Phuong trinh co nghiem: " + (double)-b/a);
            }
        }
    }
}