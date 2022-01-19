using System;
using System.IO;

namespace MyExpectations
{
    public class NameEmtyException : Exception{
        public NameEmtyException() : base("Ten phai khac rong"){
            
        }
    }
    public class AgeException : Exception{
        public int age { get; set; }
        public AgeException(int _age) : base("Do tuoi khong phu hop?"){
            age = _age;
        }
        public void Detail(){
            Console.WriteLine($"Tuoi = {age} qua nho so voi quy dinh");
        }
    }
}