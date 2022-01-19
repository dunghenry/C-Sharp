using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace CS29.Asynchronous
{
    class Program
    {
        static void DoSomething(int seconds, string message, ConsoleColor color){
           
           lock(Console.Out){
                Console.ForegroundColor = color;
                Console.WriteLine($"{message, 10}... Start");
                Console.ResetColor();
            }

             //!
            string str = "abc";
            lock (str)
            {
                //
            }

            for (int i = 0; i <= seconds; i++){

                lock(Console.Out){
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{message, 10} {i, 2}");
                    Console.ResetColor();
                }
               
                Thread.Sleep(1000);
            }
            lock(Console.Out){
                Console.ForegroundColor = color;
                Console.WriteLine($"{message, 10}... End");
                Console.ResetColor();
            }
        }

        static async Task Task2(){
             Task t2 = new Task(
                () =>{
                    DoSomething(10, "T2", ConsoleColor.Green);
                }
            );
            t2.Start();
            // t2.Wait();
            await t2;
            Console.WriteLine("T2 da hoan thanh");
        }

        static async Task Task3(){
            Task t3 = new Task(
                (object obj) =>{
                    string name = (string) obj;
                    DoSomething(9, name, ConsoleColor.Yellow);

                }, "T3"
            );
            t3.Start();
            // t3.Wait();
            await t3;
            Console.WriteLine("T3 da hoan thanh");
            // return t3;
        }
        static async Task Abc(){
            Task task = new Task(
                () =>{
                    // ...
                }
            );
            task.Start();
            await task;
            // ...

            await File.WriteAllTextAsync("1.txt", "Chuoi ki tu kaka");
            //...
        }
        static async Task Main(string[] args)
        {
            // Console.WriteLine("----------------------");
            // DoSomething(5, "Hi", ConsoleColor.Red);
         

            // Synchronous
            // DoSomething(5, "T1", ConsoleColor.Magenta);
            // DoSomething(7, "T2", ConsoleColor.Green);
            // DoSomething(9, "T3", ConsoleColor.Yellow);
            // Console.WriteLine("Hello World!");

            // Asynchronous

            // Task t2 = new Task(
            //     () =>{
            //         DoSomething(10, "T2", ConsoleColor.Green);
            //     }
            // );

            // Task t3 = new Task(
            //     (object obj) =>{
            //         string name = (string) obj;
            //         DoSomething(9, name, ConsoleColor.Yellow);

            //     }, "T3"
            // );

            // t2.Start();
            // t3.Start();

            Task t2 = Task2();

            Task t3 = Task3();

            DoSomething(6, "T1", ConsoleColor.Magenta);

            // t2.Wait();
            // t3.Wait();

            // Task.WaitAll(t2, t3);
            await t2;
            await t3;
            Console.Write("Press any key: ");
            Console.ReadKey();
        }
    }
}
