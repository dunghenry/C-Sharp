using System;
namespace BranchingStructureExercises
{
    public class Bai8
    {
        static void Main(){
            System.Console.Write("Nhap ban khinh hinh tron: ");
            float r = Convert.ToSingle(Console.ReadLine());
            double cv, dt;
            cv = 2 * 3.14 * r;
            dt = 3.14 * r * r;
            System.Console.WriteLine("Chu vi la: " + cv);
            System.Console.WriteLine("Dien tich vi la: " + cv);
        }
    }
}