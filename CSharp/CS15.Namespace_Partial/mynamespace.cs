using System;

namespace MyNamespace{
    //struct, class, enum, interface, ...namespace
    class Class1{
        public static void XinChao(){
            Console.WriteLine("Xin chao class One!!!");
        }
    }
    namespace Abc{
        class Class1{
            public static void XinChao(){
                Console.WriteLine("Xin chao tu  Class1 / Abc");
            }
        }
    }
}