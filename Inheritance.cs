//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//    internal class Inheritance
//    {
//        static void Main(string[] args)
//        {
//            Rectangle rect = new Rectangle(8,9);
//            rect.CalculateArea();
//            Circle circle = new Circle(25);
//            circle.CalculateCircleArea();
//        }
//    }
//}
//class Shape
//{
//    public virtual int CalculateArea()
//    {
//        return 0;
//    }
//    public virtual double CalculateCircleArea()
//    {
//        return 0;
//    }

//}
//class Rectangle:Shape
//{
//    public int len;
//    public int br;

//    public Rectangle(int l, int b)
//    {
//        this.len = l;
//        this.br = b;
//    }

//    public override int CalculateArea()
//    {
//        int res = len*br;
//        return res;
//    }
//}
//class Circle : Shape
//{
//    public double Radius;
//    public Circle(int r)
//    {
//        this.Radius = r;
//    }
//    public override double CalculateCircleArea()
//    {
//        return this.Radius*this.Radius*3.14;
//    }
   
//}
