
using ConsoleApp21;

class Program
{
    static void Main(string[] args)
    {
        using(var context=new NorthwindContext())
        {
           List<Customer>customers=context.Customers.ToList();
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }
    }
}