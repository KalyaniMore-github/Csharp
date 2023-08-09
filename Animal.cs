//using ConsoleApp12;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//    internal class Animal
//    {
//        public virtual void MakeSound()
//        {
//            Console.WriteLine("Animals make sound");

//        }

//    }
//}
//class Dog:Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Dog sound is bark-bark");

//    }
//}
//class Cat : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Cat sound is Meow-Meow");
//    }
//}
// class Cow:Animal
//{
//    public override void MakeSound()
//    {
//       Console.WriteLine("Cow sound is Hmm-Hmm");
//    }
//}

//class Zoo
//{
//    static void Main(string[] args)
//    {
//        Animal[] animals = { new Cat(), new Dog(), new Cow() };
//        foreach (Animal item in animals)
//        {
//            item.MakeSound();
//        }
//    }
//}