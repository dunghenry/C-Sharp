using System;
namespace MyExpectations{
    public class NameEmtyException : Exception{
        public NameEmtyException() : base("Ten phai khac rong"){
            
        }
        
    }
    public class AgeException : Exception{
        public int age{ get; set; }
        public AgeException(int _age) : base("Tuoi khong phu hop"){
           age = _age;
        }
        public void Details(){
            Console.WriteLine($"Tuoi = {age} khong phu hop");
        }
    }
}