using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;


namespace ConsoleApp9
{
    public class oddnumber
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;
            while (a<b)
            {
                if (a%2==1)
                {
                    Console.WriteLine("{0} is a odd number", a);
                    a++;
                }
                else
                {
                    Console.WriteLine("{0} ia a even number", a);
                }
            }
        }
        
    }
}
