//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//    delegate void CustomDel(string s);
//    internal class TestClass
//    {
//        static void Hello(string s)
//        {
//            Console.WriteLine($" Hello,{s}!");
//        }
//        static void GoodBye(string s)
//        {
//            Console.WriteLine($" Goodbye,{s}!");
//        }
//        static void Main(string[] args)
//        {
//            //declare the instance of customdel
//            CustomDel hiDel, bydel, multiDel, multiMinusHiDel;
//            //create the delegate object hidel that references the method hello
//            hiDel=Hello;
//            //create the delegate object bydel that references the method goodbye
//            bydel=GoodBye;
//            //the two del hidel and multidel are combined to form multidel
//            //multicast delecate,innvocation
//            multiDel=hiDel+bydel;
//            multiMinusHiDel=multiDel-hiDel;

//            Console.WriteLine("Invoking hiDel:");
//            hiDel("kalyani");
//            Console.WriteLine("Invoking bydel:");
//            bydel("b");
//            Console.WriteLine("Invoking multidel:");
//            multiDel("c");
//            Console.WriteLine("Invoking multiminushidel:");
//            multiDel("d");
//            Console.Read();

//        }

//    }
//}
