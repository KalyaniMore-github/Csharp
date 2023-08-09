using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class countstring
    {
        static void Main(string[] args)
        {

            string phrase;
            int word = 1;


            Console.Write("Enter a phrase: ");
            phrase = Console.ReadLine();

            for (int i = 0; i<phrase.Length; i++)
            {
                if (phrase[i] == ' ')
                {
                    word++;
                }
            }
            Console.WriteLine(word);
        }
    }
}
