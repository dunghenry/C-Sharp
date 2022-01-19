using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hang so PI: " + System.Math.PI);
            Console.WriteLine("Hang so E: " + System.Math.E);
            Console.WriteLine("Max cua hai so la: " + System.Math.Max(2, 10));
            Console.WriteLine("Max cua hai so la: " + System.Math.Min(2, 10));
            
            Console.WriteLine("Gia tri tuyet doi la: " + System.Math.Abs(-10));
            

            Console.WriteLine("Sin: " + System.Math.Sin(System.Math.PI / 4));

            for (int i = 0; i <= 90; i++){
                double rad = System.Math.PI * i / 180;
                System.Console.WriteLine("Sin" + i + " : " + System.Math.Sin(rad));

            }

            System.Console.WriteLine(System.Math.Sqrt(25)); //5
            System.Console.WriteLine(System.Math.Pow(2, 3)); // 8
            System.Console.WriteLine(System.Math.Log(125));
            System.Console.WriteLine(System.Math.Log10(100)); // 2
            
            System.Console.WriteLine(System.Math.Round(5.5)); //6
            System.Console.WriteLine(System.Math.Round(5.1)); //5

            System.Console.WriteLine(System.Math.Ceiling(5.5)); //6
            System.Console.WriteLine(System.Math.Ceiling(5.1)); //6

            System.Console.WriteLine(System.Math.Floor(5.5)); //5
            System.Console.WriteLine(System.Math.Floor(5.1)); //5

            System.Console.WriteLine(System.Math.Truncate(3.6345)); //3
        }
    }
}
