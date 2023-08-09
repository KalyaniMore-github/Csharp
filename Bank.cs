using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Bank
    {
        int id;
        public string custname;
        public string custaddress;
        public abstract string CustomerName( string custname); 
        public abstract string Customeraddress(string custaddress);
    }
}
class SBI : Bank
{
    public override string CustomerName(string custname) 
    {
        return custname;
    }
    public override string Customeraddress(string custaddress)
    {
        return custaddress;
    }
    static void Main(string[] args)
    {
        SBI s = new SBI();
        string name = s.CustomerName("kalyani");
        string addr = s.Customeraddress("pune");
        Console.WriteLine("Details of Customer [State Bank of India]");
        Console.WriteLine("Name : {0}", name);
        Console.WriteLine("Address :{0}", addr);
    }


}
