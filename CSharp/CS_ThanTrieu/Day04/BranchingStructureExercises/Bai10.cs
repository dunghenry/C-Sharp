using System;
namespace BranchingStructureExercises
{
    public class Bai10
    {
        static void Main()
        {
            System.Console.WriteLine("Giai phuong trinh bac hai!!!!");
            System.Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem"); ;
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem: " + -c / b);
                }
            }
            else
            {
                int delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep: " + -b / (2 * a));
                }
                else if (delta > 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem: " + (-b + Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("phuong trinh co nghiem: " + (-b - Math.Sqrt(delta)) / (2 * a));
                }
            }
        }
    }
}