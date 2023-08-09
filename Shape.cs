using ConsoleApp11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        
    }
}
public interface IDrawable
{

    public void draw();
}
public class Rectangle:Shape,IDrawable
{
    int len;
    int br;
    public Rectangle(int len, int br)
    {
        this.len=len;
        this.br=br;
    }

    public override double CalculateArea()
    {
        return len*br;
    }
    public void draw()
    {
        Console.WriteLine("Drawing shape from rectangle class");
    }

}
public class Circle : Shape,IDrawable
{
    int radius;
    public Circle(int r)
    {
        this.radius=r;
    }
    public override double CalculateArea()
    {
        return radius*radius*3.14;
    }
    public void draw()
    {
        Console.WriteLine("Drawing shape from circle class");
    }




}

class Demo
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(12, 22);
        rect.CalculateArea();
       // rect.draw();
        Circle c = new Circle(18);
        c.CalculateArea();
       // c.draw();
        IDrawable i=new Circle(23);
        i.draw();
        IDrawable i1 = new Rectangle(10, 11);
        i1.draw();

    }
}
