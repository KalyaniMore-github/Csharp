//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp13
//{
//    internal class asynchronous2
//    {
//        static async Task Main(string[] args)
//        {
//            Console.WriteLine("starting asynchronous operation...");
//            string filecontent = await ReadFileAsync(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt"));
//            Console.WriteLine("Asynchronous operation completed");
//            Console.WriteLine($"File content:{filecontent}");
//            Console.WriteLine("Press any key to exit");
//        }
//        static async Task<string> ReadFileAsync(string filePath)
//        {
//            try
//            {
//                using (StreamReader reader = new StreamReader(filePath))
//                {
//                    string content = await reader.ReadToEndAsync();
//                    return content;
//                }
//            }
//            catch(Exception ex) 
//            {
//                Console.WriteLine("Error reading file : {ex.Message}");
//                return string.Empty;
//            }

//}
//    }
//}
