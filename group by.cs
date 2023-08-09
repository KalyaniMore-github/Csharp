//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp13
//{
//    internal class group_by
//    {
//        static void Main(string[] args)
//        {
//            List<Person> people = new List<Person>();
//            {
//                new Person { Name="Alice", Age=25, City="New York", Gender=Gender.Female },
//            new Person { Name="Bob", Age=35, City="London", Gender=Gender.Male },
//            new Person { Name="Charlie", Age=28, City="Paris", Gender=Gender.Male },
//            new Person { Name="Dave", Age=40, City="Berlin", Gender=Gender.Male },
//           new Person { Name="Eve", Age=45, City="Tokya", Gender=Gender.Male }
//               };
//            var groupedByCity = people.GroupBy(person => person.City);
//            foreach(var group in groupedByCity)
//            {
//                Console.WriteLine($"City:{group.Key}");
//                foreach(Person person in group)
//                {
//                    Console.WriteLine($"-{person.Name}({person.Age} years old");
//                }
//            }
//            Console.WriteLine("press any key to exit");
//            Console.ReadKey();
      
//    }
//}
