//using ConsoleApp5;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp5
//{
//    class Department
//    {
//        public void ITDepartment()
//        {
//            Console.WriteLine("IT Department");
//        }
//        public void HRDepartment()
//        {
//            Console.WriteLine("HR Department");
//        }
//        public void AccountDepartment()
//        {
//            Console.WriteLine();
//        }
//    }
//}

//class Employee:Department
//{
//    public int EmployeeID { get; set; }
//    public string EmployeeName { get; set; }
//    public Employee(int employeeID, string employeeName)
//    {
//        EmployeeID=employeeID;
//        EmployeeName=employeeName;
//        Console.WriteLine("{0} is employee of ITDepartment", EmployeeName);
//    }

//    public void Work()
//    {
//        Console.WriteLine("There are 3 departments which are Admin,account and it department");
//    }
//    public void Department()
//    {
//        Console.WriteLine("{0} works in ITDepartment", EmployeeName);

//    }
//    static void Main(string[] args)
//    {
//        Employee emp = new Employee(1,"Shweta");
        
//        emp.ITDepartment();
//        emp.HRDepartment();
//        emp.Work();
//        emp.Department();
//        emp.AccountDepartment();
//    }
//}
