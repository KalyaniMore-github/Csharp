////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleApp13
////{
////    internal class person
////    {

////    }
////}
////enum Gender
////{
////    Male,
////    Female
////}
////using System.Linq;
////class Person
////{
////    public string Name { get; set; }
////    public int Age { get; set; }
////    public string City { get; set; }
////    public Gender Gender { get; set; }
////    static void Main(string[] args)
////    {
////        List<Person>people= new List<Person>();
////        {
////           new Person { Name="Alice", Age=25, City="New York", Gender=Gender.Female},
////            new Person { Name="Bob", Age=35, City="London", Gender=Gender.Male },
////            new Person { Name="Charlie", Age=28, City="Paris", Gender=Gender.Male },
////            new Person { Name="Dave", Age=40, City="Berlin", Gender=Gender.Male },
////           new Person { Name="Eve", Age=45, City="Tokya", Gender=Gender.Male }
////           };
////        }
////        foreach (Person in person)

////        {



////    }
////}
//using example;
//using System.Security.Cryptography.X509Certificates;

//namespace example
//{
//    class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public int CityId { get; set; }
//    }

//    class City
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//    }
//}
//class Demo
//{
//    public static void Main(string[] args)
//    {
//        List<Person> people = new List<Person>();
//        {
//            new Person { Name="Alice", Age=25, CityId=1 };
//            new Person { Name="Bob", Age=35, CityId=2};
//            new Person { Name="Charlie", Age=28, CityId=2 };
//            new Person { Name="Dave", Age=40, CityId=3 };
//            new Person { Name="Eve", Age=45, CityId=2};
//        };
//        List<City> cities = new List<City>();
//        {
//            new City { Id=1, Name="York" };
//            new City { Id=2, Name="London" };
//            new City { Id=3, Name="Paris" };
//        };
//        var groupbyCity = people.GroupBy(people => people.CityId);
//        Console.WriteLine("People Count By City : - ");



//        //var GroupByCity = people.GroupBy(person => person.CityId);

//        //foreach (var group in GroupByCity)
//        //{
//        //    foreach (var city in cities)
//        //    {
//        //        if (group.Key == city.Id)
//        //        {
//        //            Console.WriteLine($"City : {city.Name}, Count : {group.Count()}");


//        //        }
//        //    }
//        //}
//        var cityCountQuery = from city in cities
//                             join person in people on city.Id equals person.CityId into citypeople
//                             select new { City = city.Name, Count = citypeople.Count() };
//        Console.WriteLine("people count by city");
//        foreach(var result in cityCountQuery)
//        {
//            Console.WriteLine(result);
//        }
//        }
//    }

