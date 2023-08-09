using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
    {
        public int id;
        public string firstname { get; set; }
        public string lastname{ get; set; }
        public string location{ get; set; }
        public string address{ get; set; }
        public void printfirstname()
        {
            Console.WriteLine(firstname);
        }
        public void printlastname()
        {
            Console.WriteLine(lastname);
        }
       
    }
}
