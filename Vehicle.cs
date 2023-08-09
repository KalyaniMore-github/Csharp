//using ConsoleApp12;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//   public abstract class Vehicle
//    {
//        public abstract void startengine();
//    }
//}
//public class Car:Vehicle { 
//    public override void startengine()
//    {
//        Console.WriteLine("car engine has started");
//    }
//}
//public class Motorcycle : Vehicle
//{
//    public override void startengine()
//    {
//        Console.WriteLine("Motorcycle engine has started");
//    }
//}


//class showroom
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car();
//        car.startengine();
//        Motorcycle m = new Motorcycle();
//        m.startengine();
//    }
//}


//interface Ishape
//{
//    public double CalculateArea();
   
    
//}
//class Rectangle: Ishape
//{
//    int len;
//    int br;
//    public Rectangle(int l, int b)
//    {
//        this.len = l;
//        this.br=b;
       
//    }
//    public double CalculateArea()
//    {
//        double res = this.len*this.br;
//        return res;
//    }
//}
//class Circle : Ishape
//{
//    int r;
//    public Circle(int c)
//    {
//        r = c;
//    }
//    public double CalculateArea()
//    {
//      return  this.r*this.r*3.14;
//    }
//}

//class Demo
//{
//    static void Main(string[] args)
//    {
//        Rectangle r = new Rectangle(2,3);
//        r.CalculateArea();
//        Circle c = new Circle(5);
//        c.CalculateArea();
//    }
//}
