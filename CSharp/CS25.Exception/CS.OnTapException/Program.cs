using System;
using System.IO;
using MyExpectations;

namespace CS.OnTapException
{
    class Program
    {
        static void Register(string name, int age){
            if(string.IsNullOrEmpty(name)){
                // Exception exception = new Exception("Ten phao khac rong.");
                // throw exception;
                throw new NameEmtyException();
            }
            Console.WriteLine($"Xin chao {name} - {age}");
            if(age < 18 || age > 100){
                // throw new Exception("Tuoi khong phu hop");
                throw new AgeException(age);
            }
        }
        static void Main(string[] args)
        {
            // try
            // {
            //     int a = 4;
            //     int b = 1;
            //     int x = a / b;
            //     int[] arr = {1, 2};
            //     var c = arr[4];
            //     Console.WriteLine(x);
            // }
            // catch(DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            //     // Console.WriteLine(e.StackTrace);
            //     Console.WriteLine(e.GetType().Name);
            //     Console.WriteLine("Khong duoc phep chi cho so 0");
            // }
            // catch(Exception e1){
            //     Console.WriteLine(e1.Message);
            //     Console.WriteLine(e1.GetType().Name);
            // }
            // Console.WriteLine("Chuong trinh ket thuc");

            // string path = "1.txt";
            // try
            // {
            //     string s = File.ReadAllText(path);
            //     Console.WriteLine(s);
            // }
            // catch (FileNotFoundException e)
            // {
            //     Console.WriteLine(e.Message);
            //     Console.WriteLine("File khong ton tai");
            // }
            // catch(ArgumentException e1){
            //     Console.WriteLine(e1.Message);
            //     Console.WriteLine("Duong dan phai khac null");
            // }
           
            try{
                Register("Dung", 10);
            }
            catch (NameEmtyException e1){
                Console.WriteLine(e1.Message);
            }
            catch (AgeException e2){
                Console.WriteLine(e2.Message);
                e2.Details();
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
