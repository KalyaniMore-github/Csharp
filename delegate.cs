//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//    internal class @delegate
//    {
//        //Define a custom delegate that has string parameter and return void
//        delegate void CustomDel(string s);
//        static void hello(string s)
//        {
//            Console.WriteLine($"HELLO,{s}");
//        }
//        static void Goodbye(string s)
//        {
//            Console.WriteLine($"BYE,{s}");
//        }
//        static void Main(string[] s)
//        {
//            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;
//            hiDel=hello;
//            byeDel=Goodbye;
//            multiDel=hiDel+byeDel;
//            multiMinusHiDel=multiDel-hiDel;
//            Console.WriteLine("Invoking hiDel :");
//            hiDel("A");
//            Console.WriteLine("Invoking byeDel:");
//            byeDel("b");
//            Console.WriteLine("Invoking multiDe:");
//            multiDel("c");
//            Console.WriteLine("Invoking multiMinusHiDel");
//            multiMinusHiDel("d");
//            Console.Read();
//        }
//    }
//}
