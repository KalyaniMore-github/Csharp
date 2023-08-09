using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class removeduplicate
    {
        static void Main()
        {
            int i = 0, j = 0;
            int[] arr1 = new int[3];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;
            for (i = 0; i<arr1.Length; i++)
            {
                for (j = 0; j<arr1.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr1[j] == arr1[i])
                        break;
                }
                if (arr1.Length == j)
                {
                    Console.WriteLine(arr1[i] + " ");
                }
            }
        }
    }
}
