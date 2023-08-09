using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class squarearray
    {
        static void Main()
        {
            int[] sq = { 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i<sq.Length; i++)
            {
                int res = sq[i] * sq[i];
                Console.WriteLine("square of the arrays are : " +res);
            }
        }
    }




    }
//    }
