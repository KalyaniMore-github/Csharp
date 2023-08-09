using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class equal
    {
        static void Main(string[] args)
        {
           
            Boolean Equal = true;

         
            int[] arr1 = { 1, 2, 3};
            int[] arr2 = { 1, 2, 3};

            
            if (arr1.Length == arr2.Length)
            {

                
                for (int i = 0; i < arr2.Length; i++)
                {

                   
                    if (arr2[i] != arr1[i])
                    {

                        Equal = false;
                    }
                }
            }
            else
            {

                Equal = false;
            }

            
            if (Equal)
            {
                Console.WriteLine("Both arrays are equal");

            }
            else
            {
                Console.WriteLine("Both arrays are not equals");

            }
        }
    }
}

