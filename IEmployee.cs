using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface IEmployee
    {
        public void PrintEmployeeName();
    }
    public class Employee : IEmployee
    {
        public void PrintEmployeeName()
        {
            //print to the console
            Console.WriteLine("kalyani more");
        }
    }
}
