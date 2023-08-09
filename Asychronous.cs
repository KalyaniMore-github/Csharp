//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp13
//{
//    internal class Asychronous
//    {
//        static async Task Main()
//        {
//            Console.WriteLine("Starting  Asynchronous operation ..");
//            string response = await GetResponseAsync();
//            Console.WriteLine("Asynchronous operation completed");
//            Console.WriteLine($"Response:{response}");
//           Console.WriteLine("Press any key to exit");
//            Console.ReadKey();

//        }
//        static async Task<string> GetResponseAsync()
//        {
//            using(HttpClient client = new HttpClient())
//            {
//                HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
//                string result=await response.Content.ReadAsStringAsync();
//                return result;
//            }
//        }
//    }
//}
