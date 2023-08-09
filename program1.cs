using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class program1
    {
        static void Increment(int i)
        {
             i=i+1;
        }
        static void main(string[] args) {
            int x = 1;
            Increment( ref x);
            Console.WriteLine("the value of x is : " +x);
            Console.Read();
        }

    }
}
