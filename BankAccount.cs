//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//    internal class BankAccount
//    {
//        private string accountNumber { get; set; }
//        private decimal balance { get; set; }
//        public BankAccount(decimal balance)
//        {
//            this.balance = balance;
//        }
//        public void Deposit(decimal cash)
//        {
//            this.balance += cash;
//            Console.WriteLine(balance);
//        }
//        public void Withraw(decimal cashwithdrawl)
//        {
//            this.balance -= this.balance-cashwithdrawl;
//            Console.WriteLine(balance);
//        }
//        static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount(15000);
//            account.Deposit(2000);
//            account.Withraw(1000);
//        }

//    }
//}
