using System;
    public class Vector{
        public double x;
        public double y;
        public Vector(double _x, double _y){
            this.x = _x;
            this.y = _y;
        }
        public void Info(){
            Console.WriteLine($"x = {x}, y = {y}");
        }
        public static Vector operator+(Vector v1, Vector v2){
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vector operator+(Vector v1, double value){
            return new Vector(v1.x + value, v1.y + value);
        }
        public double this[int index] {
            set {
                switch (index)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so bi sai");
                }
            }
            get{
                switch (index)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new Exception("Chi so bi sai");
                }
            }
        }

        public double this[string str]{
            set{
                switch (str)
                {
                    case "toadox":
                        x = value;
                        break;
                    case "toadoy":
                        y = value;
                        break;
                    default:
                        throw new Exception("Chuoi sai hehe");
                }
            }
            get{
                switch (str)
                {
                    case "toadox":
                        return x;
                    case "toadoy":
                        return y;
                    default:
                        throw new Exception("Chuoi sai hehe");
                }
            }
        }
    }
