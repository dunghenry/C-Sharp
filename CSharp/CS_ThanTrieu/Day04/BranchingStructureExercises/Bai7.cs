using System;
namespace BranchingStructureExercises
{
    public class Bai7
    {
        static void Main(){
            System.Console.Write("Nhap chieu dai: ");
            int d = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap chieu rong: ");
            int r = Convert.ToInt32(Console.ReadLine());
            int cv = (d + r) * 2;
            int dt = d * r;
            System.Console.WriteLine("Chu vi la: " + cv);
            System.Console.WriteLine("Dien tich la: " + dt);
        }
    }
}