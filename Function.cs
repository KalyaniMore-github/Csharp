using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Function
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
        //here we are giving three int values first two are inputs which are given to sum method and third int is the result which is returning int value
            Func<int, int, int>add = Sum;//so here we are giving func delecate which is returning value
                                         //(func we used when we used to return something) and action
                                         //delegate we use when we are not returning anything(i.e. when we are using void)
            int result =add(10, 10);//add means-->sum we are calling sum method and giving arguments
            Console.WriteLine(result);
        }
    }
}
