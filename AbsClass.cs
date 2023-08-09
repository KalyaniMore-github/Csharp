//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    abstract class AbsClass
//    {
//        public int Addtwonumbers(int Num1,int Num2)
//        {
//            return Num1+ Num2;
//        }
//        public abstract int Multiplytwonumbers(int Num1,int Num2);

//    }
//    class AbsDerived : AbsClass
//    {
//        public override int Multiplytwonumbers(int Num1,int Num2)
//        {
//            return Num1*Num2;
//        }
//        static void Main(string[] args) {
//            AbsDerived calculate=new AbsDerived();
//            int added = calculate.Addtwonumbers(10, 10);
//            int multiplied = calculate.Multiplytwonumbers(2, 2);
//            Console.WriteLine("Added :{0},Multiplied:{1}",added,multiplied);
//        }
//    }
//}
