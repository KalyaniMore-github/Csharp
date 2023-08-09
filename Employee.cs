//using ConsoleApp13;
////using example;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp13
//{
//    internal class Employee
//    {
//        public int deptid { get; set; }
//        public string name { get; set; }
//        public string Gender { get; set; }

//    }

    
//}

//class Department
//{
//    public int deptid { get; set; }
//    public string deptname { get; set; }

//}
//class Test
//{
//    static void Main(string[] args)
//    {
        //List<Employee> employee = new List<Employee>();
        //{
        //    new Employee { name="Alice", deptid=1, Gender="female" };
        //    new Employee { name="jack", deptid=2, Gender="Male" };
        //    new Employee { name="john", deptid=2, Gender="Male" };
        //    new Employee { name="heena", deptid=1, Gender="Female" };
        //};
        //List<Department>dept= new List<Department>();
        //{
        //    new Department { deptid=1, deptname="HR" };
        //    new Department { deptid=2, deptname="Admin" };
        //    new Department { deptid=3, deptname="IT" };
        //}
        //var empdept = from emp in employee
        //              join d in dept on emp.deptid equals d.deptid
        //              select new(Id=emp.id, name=emp.name, Gen=emp.Gender,
        //              id=dept.id);


        //    }

        //}
        //    }

        //}   }

        //}
        using System;
        using System.Linq;
        using System.Collections.Generic;
namespace employee{

    
    public class Employee
    {
        public int id;
        public string name;
        public int dept_id;
        
        public string Gender;
    }

    
    public class Department
    {
        public int dept_id;
        public string dept_name;
    }


    class GFG
    {

       
        static void Main(string[] args)
        {

          
            List<Employee> employees = new List<Employee>()
    {
        new Employee{ id = 234, name = "Kalyani More",
                      dept_id = 1,Gender="female" },
        new Employee{ id = 244, name = "Swapnil Vaidya",
                      dept_id = 2,Gender="Male"},
        new Employee{ id = 734, name = "Ajaj A",
                      dept_id = 1,Gender="Male"},
        new Employee{ id = 533, name = "Mayur Pakhle",
                      dept_id = 4, Gender = "Male"},
    };

            List<Department> departments = new List<Department>()
    {
        new Department{ dept_id = 1, dept_name = "CSE" },
        new Department{ dept_id = 2, dept_name = "CSE" },
        new Department{ dept_id = 3, dept_name = "IT " },
    };

            // Join the employees  and other two tables
            var result = (from stu in employees

                          join dept in departments on stu
                          .dept_id equals dept
                          .dept_id

                          select new
                          {
                              ID = stu.id,
                              Name = stu.name,
                              DeptName = dept.dept_name,
                              Gen = stu.Gender,
                          }).ToList();

            // Display the result
            foreach (var e in result)
            {
                Console.WriteLine("ID: " + e.ID +
                            "--> Name: " + e.Name +
                      "--> Department: " + e.DeptName +
                       "--> Gender: " + e.Gen
                      );

                var count= (from stu in employees

                            join dept in departments on stu
                            .dept_id equals dept
                            .dept_id

                           
            }
        }
    }
}
