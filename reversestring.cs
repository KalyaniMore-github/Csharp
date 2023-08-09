using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class reversestring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string firstString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = firstString.Length - 1; i >= 0; i--)
            {
                reverseString += firstString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
    }
}


