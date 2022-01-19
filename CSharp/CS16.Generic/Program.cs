using System;
using System.Collections.Generic;
namespace Generic
{
    class Program
    {
        static void Swap(ref int x, ref int y){
            int t = x;
            x = y;
            y = t;
        }
        static void Swap(ref float x, ref float y){
            float t = x;
            x = y;
            y = t;
        }
        static void Swap<T>(ref T x, ref T y){
            T t = x;
            x = y;
            y = t;
        }
        class Product<T>{
            T ID;
            public void SetID(T ID){
                this.ID = ID;
            }
            public void PrintInfo(){
                System.Console.WriteLine($"ID = {ID}");
            }
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            float x = 1.2f, y = 2.5f;
            string z = "Hello World";
            string k = "cc";
            System.Console.WriteLine($"a = {a}, b = {b}");
            // Swap(ref a, ref b);
            // Swap(ref x, ref y); // 2.5 1.2
            System.Console.WriteLine($"x = {x}, y = {y}");

            Swap(ref z, ref k);
            Swap<string>(ref z, ref k);
            System.Console.WriteLine($"z = {z}, k = {k}");

            Product<int> product = new Product<int>();
            product.SetID(12);
            product.PrintInfo();

            Product<string> sp = new Product<string>();
            sp.SetID("SBD001");
            sp.PrintInfo();

            //Giới thiệu List
            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();

            Stack<int> stack;
            Queue<int> q;

        }
    }
}
